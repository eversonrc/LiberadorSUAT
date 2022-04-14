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

        public String arquivo { get; set; }

        public String destino { get; set; }

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
                arquivo = caminho + nome;
                destino = nome;
                listarDiretorio();
            }
        }

        public void listarDiretorio()
        {
            List<ConfiguracaoFTP> lista = conexaoMongo.getConfigFTP();
            string nomeSistema = telaLiberador.Sistema.ToString().ToUpper();
            string versaoSistema = telaLiberador.txbVersao.Text;
            string releaseSistema = telaLiberador.txbRelease.Text;
            string caminhoFTP = "";
            string senhaFTP;
            string usuarioFTP;
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
                        caminhoFTP = lista[0].Caminho.ToString() + "Evasores/";
                        senhaFTP = lista[0].Senha.ToString();
                        usuarioFTP = lista[0].Usuario.ToString();
                        break;

                    case "SUATMobilidade":
                        caminhoFTP = lista[0].Caminho.ToString() +  "SUATMobilidade/";
                        senhaFTP = lista[0].Senha.ToString();
                        usuarioFTP = lista[0].Usuario.ToString();
                        break;

                    case "Automatizador Rodovias":
                        caminhoFTP = lista[0].Caminho.ToString() + "Automatizador Rodovias/";
                        senhaFTP = lista[0].Senha.ToString();
                        usuarioFTP = lista[0].Usuario.ToString();
                        break;

                    case "Automatizador Mobilidade":
                        caminhoFTP = lista[0].Caminho.ToString() + "Automatizador Mobilidade/";
                        senhaFTP = lista[0].Senha.ToString();
                        usuarioFTP = lista[0].Usuario.ToString();
                        break;

                    case "Barcas":
                        caminhoFTP = lista[0].Caminho.ToString() + "Barcas/";
                        senhaFTP = lista[0].Senha.ToString();
                        usuarioFTP = lista[0].Usuario.ToString();
                        break;
                }
            }

            nomeDiretorio = versaoSistema + releaseSistema;

            //verificando se existe o diretório acima (nomeDiretorio)
                try
                {
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(caminhoFTP);
                    ftpRequest.Credentials = new NetworkCredential("adnccr", "Adn@cr123");
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
                        uploadFTP(caminhoFTP, nomeDiretorio, arquivo, destino);
                    }
                    else
                    {
                        criarDiretorio(nomeDiretorio, caminhoFTP);
                        uploadFTP(caminhoFTP, nomeDiretorio, arquivo, destino);
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
                var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(caminhoFTP + nomeDiretorio +"/" + destino);
                request.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new System.Net.NetworkCredential("adnccr", "Adn@cr123");

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
                FtpWebRequest requisicaoFTP;
                try
                {
                    requisicaoFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(caminhoFTP + nomeDiretorio));
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



