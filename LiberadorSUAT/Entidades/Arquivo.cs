using LiberadorSUAT.Models.Auxiliares;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LiberadorSUAT.Models
{
    class Arquivo
    {
        public TelaLiberador telaLiberador { get; set; }
        public ConexaoMongo conexaoMongo;
        public bool DiretorioExiste { get; set; }
        public String arquivo { get; set; }
        public String destino { get; set; }
        public String usuarioFTP { get; set; }
        public String senhaFTP { get; set; }

        public Arquivo (TelaLiberador tela){
            telaLiberador = tela;
            conexaoMongo = new ConexaoMongo();
        }

        string[] optionList = new string[2]
        {
            "Arquivos de texto|*.doc;*.docx;*.pdf;*.txt;*.txt,*.ppt;*.xls",
            "Arquivos de Bancos de Dados|*.sql;*.seq;*.syn;*.tab;*.trg;*.tps;*.vw;*.fnc;*.bdy;*.prc;*.pck;*.spc" +
            ";*.pdy;*.typ;*.tps;*.tpb;*.trg;"
        };

        public void AdicionarArquivos(ListView listView, int i, string tipo)
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
                        switch (tipo)
                        {
                            case "documentos":
                                File.Copy(caminho, Directory.GetCurrentDirectory() + @"\documentacao\" + Path.GetFileName(caminho), true);
                                break;

                            case "scripts":
                                File.Copy(caminho, Directory.GetCurrentDirectory() + @"\scripts\" + Path.GetFileName(caminho), true);
                                break;
                        }

                        ListViewItem arquivos = new ListViewItem();
                        arquivos.SubItems.Add(nome);
                        arquivos.SubItems.Add(caminho);
                        listView.Items.Add(arquivos);
                    }
                }
            }
        }
        public void percorrerDiretorioArquivos(string caminho, string tipo)
        {
            string[] files = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                string substringNome = file.Substring(file.LastIndexOf('\\'));
                string[] splitNome = substringNome.Split('\\');
                string nome = splitNome[1];
                arquivo = caminho + nome;
                destino = nome;
                listarDiretorio(tipo);
            }
        }
        public void listarDiretorio(string tipo)
        {
            List<ConfiguracaoFTP> lista = conexaoMongo.getConfigFTP();
            string nomeSistema = telaLiberador.Sistema.ToString().ToUpper();
            string versaoSistema = telaLiberador.txbVersao.Text;
            string releaseSistema = telaLiberador.txbRelease.Text;

            string caminhoFTP = "";
            senhaFTP = lista[0].Senha.ToString();
            usuarioFTP = lista[0].Usuario.ToString();

            string nomeDiretorio;

            if (nomeSistema == "VLTRIO")
            {
                caminhoFTP = lista[1].Caminho.ToString();
                senhaFTP = lista[1].Senha.ToString();
                usuarioFTP = lista[1].Usuario.ToString();
            }
            else
            {
                switch (telaLiberador.Sistema)
                {
                    case "Evasores":
                        caminhoFTP = lista[0].Caminho.ToString() + "EVASORES/";
                        break;

                    case "SUATMobilidade":
                        caminhoFTP = lista[0].Caminho.ToString() + "SUATMOBILIDADE/";
                        break;

                    case "Automatizador Rodovias":
                        caminhoFTP = lista[0].Caminho.ToString() + "AUTOMATIZADOR RODOVIAS/";
                        break;

                    case "Automatizador Mobilidade":
                        caminhoFTP = lista[0].Caminho.ToString() + "AUTOMATIZADOR MOBILIDADE/";
                        break;

                    case "Barcas":
                        caminhoFTP = lista[0].Caminho.ToString() + "BARCAS/";
                        break;
                }
            }

            nomeDiretorio = versaoSistema + releaseSistema;
            string pastaScript = nomeDiretorio + "/" + "scripts";
            string pastaDocumentos = nomeDiretorio + "/" + "documentacao";
            string pastaSistema = nomeDiretorio + "/" + "sistema";

            //verificando se existe o diretório acima (nomeDiretorio)
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(caminhoFTP);
                ftpRequest.Credentials = new NetworkCredential(usuarioFTP, senhaFTP);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());

                List<string> diretorios = new List<string>();
                string linha = streamReader.ReadLine();
                while (!string.IsNullOrEmpty(linha))
                {
                    diretorios.Add(linha);
                    linha = streamReader.ReadLine();
                }

                bool diretorioExiste = false;
                foreach (var diretorio in diretorios)
                {
                    if (diretorio == nomeDiretorio)
                    {
                        diretorioExiste = true;
                    }
                }

                if (diretorioExiste)
                {
                    switch (tipo)
                    {
                        case "scripts":
                            uploadFTP(caminhoFTP, pastaScript, arquivo, destino);
                            break;

                        case "documentos":
                            uploadFTP(caminhoFTP, pastaDocumentos, arquivo, destino);
                            break;

                        case "sistema":
                            uploadFTP(caminhoFTP, pastaSistema, arquivo, destino);
                            break;
                    }
                }
                else
                {
                    criarDiretorio(nomeDiretorio, caminhoFTP);
                    criarDiretorio(pastaScript, caminhoFTP);
                    criarDiretorio(pastaDocumentos, caminhoFTP);
                    criarDiretorio(pastaSistema, caminhoFTP);
                    switch (tipo)
                    {
                        case "scripts":
                            uploadFTP(caminhoFTP, pastaScript, arquivo, destino);
                            break;

                        case "documentos":
                            uploadFTP(caminhoFTP, pastaDocumentos, arquivo, destino);
                            break;

                        case "sistema":
                            uploadFTP(caminhoFTP, pastaSistema, arquivo, destino);
                            break;
                    }
                }

                streamReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void uploadFTP(string caminhoFTP, string nomeDiretorio, string arquivo, string destino)
        {
            try
            {
                var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP + nomeDiretorio + "/" + destino);
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
        public void criarDiretorio(string nomeDiretorio, string caminhoFTP)
        {
            try
            {
                FtpWebRequest requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(caminhoFTP + nomeDiretorio));
                requisicaoFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                requisicaoFTP.UseBinary = true;
                requisicaoFTP.Credentials = new NetworkCredential(usuarioFTP, senhaFTP);

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
