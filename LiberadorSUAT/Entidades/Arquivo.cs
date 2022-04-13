using LiberadorSUAT.Models.Auxiliares;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LiberadorSUAT.Models
{
    class Arquivo
    {
        public TelaLiberador telaLiberador { get; set; }
        public ConexaoMongo conexaoMongo;

        public Arquivo (TelaLiberador tela){
            telaLiberador = tela;
            conexaoMongo = new ConexaoMongo();
        }

        string[] optionList = new string[2]
        {
            "Text Files|*.doc;*.docx;*.pdf;*.txt;*.txt,*.ppt;*.xls",
            "DB Files|*.sql;*.seq;*.syn;*.tab;*.trg;*.tps;*.vw;*.fnc;*.bdy;*.prc;*.pck;*.spc" +
            ";*.pdy;*.typ;*.tps;*.tpb;*.trg;"
        };

        public void AdicionarArquivos(ListView listView, int i)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = optionList[i];

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        string substringNome = file.Substring(file.LastIndexOf('\\'));
                        string[] splitNome = substringNome.Split('\\');
                        string nome = splitNome[1];
                        string caminho = file;

                        File.Copy(caminho,Directory.GetCurrentDirectory()+ @"\arquivos\" + Path.GetFileName(caminho), true);

                        ListViewItem arquivos = new ListViewItem();
                        arquivos.SubItems.Add(nome);
                        arquivos.SubItems.Add(caminho);
                        listView.Items.Add(arquivos);

                    }
                }
            }
        }

        public void percorrerDiretorioArquivos(string caminho)
        {
            string[] files = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach(var file in files)
            {
                string substringNome = file.Substring(file.LastIndexOf('\\'));
                string[] splitNome = substringNome.Split('\\');
                string nome = splitNome[1];
                uploadFTP(caminho+nome, nome);
            }
        }

        public void uploadFTP(string arquivo, string destino)
        {
            List<ConfiguracaoFTP> lista = conexaoMongo.getConfigFTP();

            string nomeSistema = telaLiberador.Sistema.ToString().ToUpper();
            string versaoSistema = telaLiberador.txbVersao.Text;
            string releaseSistema = telaLiberador.txbRelease.Text;

            string caminhoFTP = lista[0].Caminho.ToString() + nomeSistema + "/" + versaoSistema + releaseSistema; ;
            string senhaFTP = lista[0].Senha.ToString();
            string usuarioFTP = lista[0].Usuario.ToString();

            //Existem 2 conexões ao FTP: 1-Mobilidade e Rodovias em geral; 2-VLTRio.
            //Caso o sistema selecionado seja VLTRio, a conexão ao FTP será diferente;
            if (nomeSistema == "VLTRIO")
            {
                caminhoFTP = lista[1].Caminho.ToString() + nomeSistema + "/" + versaoSistema + releaseSistema;
                senhaFTP = lista[1].Senha.ToString();
                usuarioFTP = lista[1].Usuario.ToString();
            }

            bool DirectoryExists = Directory.Exists(caminhoFTP);

            try
            {
                if (DirectoryExists == false)
                {
                    //Criar a conexão com o caminho FTP e CRIAR o diretório, até então inexistente, adicionando o arquivo
                    var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP);
                    request.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory;
                    request.Credentials = new System.Net.NetworkCredential(usuarioFTP, senhaFTP);
                    var response = (System.Net.FtpWebResponse)request.GetResponse();
                    DirectoryExists = true;
                    response.Close();
                }
                else
                {
                    //Criar a conexão com o caminho FTP e adiciona o arquivo selecionado (sem necessidade de criar o diretório anteriormente)
                    var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP + "/" + destino);
                    request.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new System.Net.NetworkCredential(usuarioFTP, senhaFTP);

                    //Faz a leitura do arquivo e insere-o na pasta destino do FTP
                    var conteudoArquivo = System.IO.File.ReadAllBytes(arquivo);
                    request.ContentLength = conteudoArquivo.Length;

                    var requestStream = request.GetRequestStream();

                    requestStream.Write(conteudoArquivo, 0, conteudoArquivo.Length);
                    requestStream.Close();

                    var response = (System.Net.FtpWebResponse)request.GetResponse();
                    response.Close();
                }
            }
            catch
            {
            }
            finally
            {
                //Deleta o arquivo temporário na pasta Debug após o arquivo já ter sido alocado no FTP
                File.Delete(arquivo);
            }
        }

        public void ExcluirArquivos(ListView listView)
        {
            if (listView.Items.Count > 0)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.Checked)
                    {
                        listView.Items.RemoveAt(item.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma alteração foi selecionada.");
            }
        }
    }
}
