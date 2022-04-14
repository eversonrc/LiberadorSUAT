using LiberadorSUAT.Models.Auxiliares;
using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Models
{
    class Arquivo
    {
        public TelaLiberador telaLiberador { get; set; }
        public ConexaoMongo conexaoMongo;
        public bool DiretorioExiste { get; set; }

        public Arquivo(TelaLiberador tela)
        {
            telaLiberador = tela;
            conexaoMongo = new ConexaoMongo();
        }

        string[] optionList = new string[2]
        {
            "Word Documents|*.doc|PDF Documents|*.pdf",
            "DB Files|*.sql|*.seq|*.syn|*.tab|*.trg|*.tps|*.vw|*.fnc|*.bdy|*.prc|*.pck|*.spc" +
            "|*.pdy|*.typ|*.tps|*.tpb|*.trg|All Files|*.*"
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

                        File.Copy(caminho, Directory.GetCurrentDirectory() + @"\arquivos\" + Path.GetFileName(caminho), true);

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

            foreach (var file in files)
            {
                string substringNome = file.Substring(file.LastIndexOf('\\'));
                string[] splitNome = substringNome.Split('\\');
                string nome = splitNome[1];
                uploadFTP(caminho + nome, nome);
            }
        }
        /*public void uploadFTP(string arquivo, string destino)
        {
            List<ConfiguracaoFTP> lista = conexaoMongo.getConfigFTP();
            string caminhoFTP = lista[0].Caminho.ToString();
            string senhaFTP = lista[0].Senha.ToString();
            string usuarioFTP = lista[0].Usuario.ToString();

            var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP + destino);
            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new System.Net.NetworkCredential(usuarioFTP, senhaFTP);

            var conteudoArquivo = System.IO.File.ReadAllBytes(arquivo);
            request.ContentLength = conteudoArquivo.Length;

            var requestStream = request.GetRequestStream();

            requestStream.Write(conteudoArquivo, 0, conteudoArquivo.Length);
            requestStream.Close();

            var response = (System.Net.FtpWebResponse)request.GetResponse();
            response.Close();
            File.Delete(arquivo);

        }*/

        public void uploadFTP(string arquivo, string destino)
        {
            List<ConfiguracaoFTP> lista = conexaoMongo.getConfigFTP();

            string nomeSistema = telaLiberador.Sistema.ToString().ToUpper();
            string versaoSistema = telaLiberador.txbVersao.Text;
            string releaseSistema = telaLiberador.txbRelease.Text;
            string caminhoFTP;
            string senhaFTP;
            string usuarioFTP;

            if (nomeSistema == "VLTRIO")
            {
                caminhoFTP = lista[1].Caminho.ToString();
                senhaFTP = lista[1].Senha.ToString();
                usuarioFTP = lista[1].Usuario.ToString();
            }
            else
            {
                //teste com barcas
                caminhoFTP = lista[0].Caminho.ToString() + "LIBERADOR_SUAT/" + "Barcas/";
                senhaFTP = lista[0].Senha.ToString();
                usuarioFTP = lista[0].Usuario.ToString();
            }
            string diretorio = caminhoFTP + versaoSistema + releaseSistema + "/";
            DiretorioExiste = Directory.Exists(diretorio); //colocar dentro da requisição FTP

            if (DiretorioExiste == false)
            {
                criarDiretorio(versaoSistema + releaseSistema);
                caminhoFTP = caminhoFTP + "/"+ versaoSistema + releaseSistema;
            }

            try
            {
                var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP  + "/" + destino);
                request.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new System.Net.NetworkCredential(usuarioFTP, senhaFTP);

                var conteudoArquivo = System.IO.File.ReadAllBytes(arquivo);
                request.ContentLength = conteudoArquivo.Length;

                var requestStream = request.GetRequestStream();

                requestStream.Write(conteudoArquivo, 0, conteudoArquivo.Length);
                requestStream.Close();

                var response = (System.Net.FtpWebResponse)request.GetResponse();
                response.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                File.Delete(arquivo);
            }
        }


        public void criarDiretorio(string nomeDiretorio)
        {
            FtpWebRequest requisicaoFTP;
            try
            {
                // _nomeDiretorio = nome do diretorio a ser criado
                requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://adnccr@ftp.adn.com.br/CCR/Versao/LIBERADOR_SUAT/Barcas/" + nomeDiretorio));
                requisicaoFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                DiretorioExiste = true;
                requisicaoFTP.UseBinary = true;
                requisicaoFTP.Credentials = new NetworkCredential("adnccr", "Adn@cr123");
                FtpWebResponse response = (FtpWebResponse)requisicaoFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ExcluirArquivos(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Checked)
                {
                    listView.Items.RemoveAt(item.Index);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
        }
    }
}

