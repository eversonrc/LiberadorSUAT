using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Models
{
    class Arquivo
    {
        string[] optionList = new string[2]
        {
            "Word Documents|*.doc|PDF Documents|*.pdf",
            "DB Files|*.sql|*.seq|*.syn|*.tab|*.trg|*.tps|*.vw|*.fnc|*.bdy"
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

                        File.Copy(caminho, @"C:\Workspace\CCR\DesafioTecnico\LiberadorSUAT\bin\Debug\" + Path.GetFileName(caminho), true);

                        ListViewItem arquivos = new ListViewItem();
                        arquivos.SubItems.Add(nome);
                        arquivos.SubItems.Add(caminho);
                        listView.Items.Add(arquivos);

                        uploadFTP(nome, nome);
                        
                    }
                }
            }
        }

        private void uploadFTP(string arquivo, string destino)
        {
            var request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(@"ftp://adnccr@ftp.adn.com.br/CCR/Versao/LIBERADOR_SUAT/" + destino);
            request.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new System.Net.NetworkCredential("adnccr", "Adn@cr123");

            var conteudoArquivo = System.IO.File.ReadAllBytes(arquivo);
            request.ContentLength = conteudoArquivo.Length;

            var requestStream = request.GetRequestStream();

            requestStream.Write(conteudoArquivo, 0, conteudoArquivo.Length);
            requestStream.Close();

            var response = (System.Net.FtpWebResponse)request.GetResponse();
            Console.WriteLine("Upload completo. Status: {0}", response.StatusDescription);
            response.Close();
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
