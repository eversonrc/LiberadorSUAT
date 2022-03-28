using LiberadorSUAT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LiberadorSUAT.Screens.Modals
{
    public partial class ModalAnexos : Form
    {
        private SideBarLayout sideBar;
        public TelaLiberador telaLiberador { get; set; }
        public static bool isAcessivel { get; set; }
        public ModalAnexos(SideBarLayout side)
        {
            InitializeComponent();
            ConfigurarToolTip();
            gerarGrade();
            sideBar = side;
            isAcessivel = false;
        }

        public bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return false;
        }

        private void ConfigurarToolTip()
        {
            toolTipModalAnexo.AutoPopDelay = 4000;
            toolTipModalAnexo.InitialDelay = 100;
            toolTipModalAnexo.ReshowDelay = 200;
            toolTipModalAnexo.ToolTipTitle = "Dica";
            toolTipModalAnexo.IsBalloon = true;
            toolTipModalAnexo.ToolTipIcon = ToolTipIcon.Info;

            toolTipModalAnexo.SetToolTip(btnAjudaArquivos, "Selecione o diretório de arquivos desejado.");
            toolTipModalAnexo.SetToolTip(btnAjudaScripts, "Selecione arquivos de banco de dados.");
            toolTipModalAnexo.SetToolTip(btnAjudaDocs, "Selecione arquivos com extensões .doc ou .pdf");
        }

        private void gerarGrade()
        {
            listViewArquivos.Columns.Add("", -2).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.View = View.Details;

            listViewArquivos.FullRowSelect = true;
            listViewArquivos.GridLines = true;
            listViewArquivos.CheckBoxes = true;
            
            /*Scripts*/
            listViewScripts.Columns.Add("", -2).TextAlign = HorizontalAlignment.Center;
            listViewScripts.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Center;
            listViewScripts.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Center;
            listViewScripts.View = View.Details;

            listViewScripts.FullRowSelect = true;
            listViewScripts.GridLines = true;
            listViewScripts.CheckBoxes = true;

            /*Documentações*/
            listViewDocumentos.Columns.Add("", -2).TextAlign = HorizontalAlignment.Center;
            listViewDocumentos.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Center;
            listViewDocumentos.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Center;
            listViewDocumentos.View = View.Details;

            listViewDocumentos.FullRowSelect = true;
            listViewDocumentos.GridLines = true;
            listViewDocumentos.CheckBoxes = true;
        }

        // ANEXAR Arquivos de compilação
        //
        private void btnAdicionarArquivos_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo diretorioInicial = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                DirectoryInfo[] directories = diretorioInicial.GetDirectories("*", SearchOption.AllDirectories);
                FileInfo[] files = diretorioInicial.GetFiles("*.*", SearchOption.AllDirectories);
               
                if (directories.Length != 0)
                {
                    foreach (DirectoryInfo dir in directories)
                    {
                        foreach (FileInfo file in files)
                        {
                            if (!this.IsFileLocked(file))
                            {
                                string nome = file.Name;
                                string caminho = file.FullName;

                                ListViewItem listView = new ListViewItem();
                                listView.SubItems.Add(nome);
                                listView.SubItems.Add(caminho);
                                listViewArquivos.Items.Add(listView);

                               // criarPastaFTP(listViewArquivos);
                            }
                        }
                    }
                }
                else
                {
                    foreach (FileInfo file in files)
                    {
                        if (!this.IsFileLocked(file))
                        {
                            string nome = file.Name;
                            string caminho = file.FullName;

                            ListViewItem listView = new ListViewItem();
                            listView.SubItems.Add(nome);
                            listView.SubItems.Add(caminho);
                            listViewArquivos.Items.Add(listView);

                            //criarPastaFTP(listViewArquivos);
                        }
                    }
                }
            }
        }

        /*private void criarPastaFTP(ListView lista)
        {
            string caminhoFtp = @"ftp:/adnccr@ftp.adn.com.br/CCR/Versao/";
            //caminhoFtp += telaLiberador.txbVersao.Text + telaLiberador.txbRelease.Text;
 
            FtpWebResponse ftpResponse;

            try
            {
                //define os requesitos para se conectar com o servidor
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(@"ftp://ftp.adn.com.br/");            
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.Proxy = null;
                ftpRequest.UseBinary = true;
                ftpRequest.Credentials = new NetworkCredential("adnccr", "Adn@cr123");

                //Seleção do arquivo a ser enviado
                FileInfo arquivo = new FileInfo(lista.Items[0].SubItems[1].ToString());
                byte[] fileContents = new byte[arquivo.Length];

                using (FileStream fr = arquivo.OpenRead())
                {
                    fr.Read(fileContents, 0, Convert.ToInt32(arquivo.Length));
                }

                using (Stream writer = ftpRequest.GetRequestStream())
                {
                    writer.Write(fileContents, 0, fileContents.Length);
                }

                //obtem o FtpWebResponse da operação de upload
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                MessageBox.Show(ftpResponse.StatusDescription);
            }
            catch (WebException webex)
            {
                MessageBox.Show(webex.ToString());
            }
        }*/

        private void btnExcluirArquivos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewArquivos.Items)
            {
                if (item.Checked)
                {
                    listViewArquivos.Items.RemoveAt(item.Index);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
        }

        // ANEXAR Documentação
        private void btnAdcionarDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.AdicionarArquivos(listViewDocumentos, 0);
        }
        private void btnExcluirDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.ExcluirArquivos(listViewDocumentos);
        }

        private bool validadorCampos()
        {
            if (
                listViewArquivos.Items.Count > 0 &&
                listViewScripts.Items.Count > 0 &&
                listViewDocumentos.Items.Count > 0 
            )
            {
                return true;
            }

            return false;
        }

        // ANEXAR Scripts de Banco de Dados
        private void btnExcluirScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.ExcluirArquivos(listViewScripts);
        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.AdicionarArquivos(listViewScripts, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sideBar.openChildForm(telaLiberador);

            sideBar.btnInfos.BackColor = Color.DarkGray;
            sideBar.btnAnexos.BackColor = Color.Transparent;
            sideBar.btnAnexos.Enabled = false;
            sideBar.btnEmail.Enabled = false;
            sideBar.btnEnvio.Enabled = false;
        }

        private void btnTelaEmail_Click(object sender, EventArgs e)
        {
            if (validadorCampos() == true)
            {
                isAcessivel = true;
                this.Hide();
                ModalEmail modalEmail = new ModalEmail(sideBar, telaLiberador);
                modalEmail.modalAnexo = this;
                sideBar.openChildForm(modalEmail);
                sideBar.btnEmail.BackColor = Color.DarkGray;
                sideBar.btnAnexos.BackColor = Color.Transparent;
                sideBar.btnAnexos.Enabled = false;
                sideBar.btnInfos.Enabled = false;
                sideBar.btnEnvio.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos os campo devem ser preenchidos antes de avançar para a próxima etapa. Por favor verifique os dados novamente.");
            } 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewScripts.Items.Count; i++)
            {
               MessageBox.Show(listViewScripts.Items[i].ToString());
            }
        }

        private void btnAjudaArquivos_Click(object sender, EventArgs e)
        {

        }

        private void ModalAnexos_Load(object sender, EventArgs e)
        {

        }
    }
}