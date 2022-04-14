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
        public string tipoDocumento { get; set; }
        public string tipoScript { get; set; }
        public string tipoArquivoSistema { get; set; }
        public ModalAnexos(SideBarLayout side)
        {
            InitializeComponent();
            ConfigurarToolTip();
            gerarGrade();
            RegrasLiberacao regra = new RegrasLiberacao();
            regra.ShowDialog();
            sideBar = side;
            isAcessivel = false;
            tipoScript = "scripts";
            tipoDocumento = "documentos";
            tipoArquivoSistema = "sistema";
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
            listViewArquivos.ForeColor = System.Drawing.Color.Red;
            listViewScripts.ForeColor = System.Drawing.Color.Red;
            listViewDocumentos.ForeColor = System.Drawing.Color.Red;

            listViewArquivos.Columns.Add("", -2).TextAlign = HorizontalAlignment.Left;
            listViewArquivos.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Left;
            listViewArquivos.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Left;
            listViewArquivos.View = View.Details;

            listViewArquivos.FullRowSelect = true;
            listViewArquivos.GridLines = true;
            listViewArquivos.CheckBoxes = true;
            
            /*Scripts*/
            listViewScripts.Columns.Add("", -2).TextAlign = HorizontalAlignment.Left;
            listViewScripts.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Left;
            listViewScripts.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Left;
            listViewScripts.View = View.Details;

            listViewScripts.FullRowSelect = true;
            listViewScripts.GridLines = true;
            listViewScripts.CheckBoxes = true;

            /*Documentações*/
            listViewDocumentos.Columns.Add("", -2).TextAlign = HorizontalAlignment.Left;
            listViewDocumentos.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Left;
            listViewDocumentos.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Left;
            listViewDocumentos.View = View.Details;

            listViewDocumentos.FullRowSelect = true;
            listViewDocumentos.GridLines = true;
            listViewDocumentos.CheckBoxes = true;
        }

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
                        percorrerArquivos(files);    
                    }
                }
                else
                {
                    percorrerArquivos(files);
                }
            }
        }

        private void percorrerArquivos(FileInfo[] files)
        {
            foreach (FileInfo file in files)
            {
                if (!this.IsFileLocked(file))
                {
                    string nome = file.Name;
                    string caminho = file.FullName;
                    file.CopyTo(Directory.GetCurrentDirectory() + @"\sistema\" + nome, true);

                    ListViewItem listView = new ListViewItem();
                    listView.SubItems.Add(nome);
                    listView.SubItems.Add(caminho);
                    listViewArquivos.Items.Add(listView);
                }
            }
        }

        private void btnExcluirArquivos_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.ExcluirArquivos(listViewArquivos, tipoArquivoSistema);
            checkBox1.Checked = false;
        }

        private void btnAdcionarDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.AdicionarArquivos(listViewDocumentos, 0, tipoDocumento);
        }

        private void btnExcluirDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.ExcluirArquivos(listViewDocumentos, tipoDocumento);
            checkBox3.Checked = false;
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

        private void btnExcluirScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.ExcluirArquivos(listViewScripts, tipoScript);
            checkBox2.Checked = false;
        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.AdicionarArquivos(listViewScripts, 1, tipoScript);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaLiberador.modalAnexos = this;
            telaLiberador.contadorClickModalAnexo++;
            sideBar.openChildForm(telaLiberador);

            sideBar.btnInfos.BackColor = Color.DarkGray;
            sideBar.btnAnexos.BackColor = Color.Transparent;
            sideBar.btnAnexos.Enabled = false;
            sideBar.btnEmail.Enabled = false;
        }

        private void btnTelaEmail_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo(telaLiberador);
            arquivo.percorrerDiretorioArquivos(Directory.GetCurrentDirectory() + @"\sistema\", tipoArquivoSistema);
            arquivo.percorrerDiretorioArquivos(Directory.GetCurrentDirectory() + @"\scripts\", tipoScript);
            arquivo.percorrerDiretorioArquivos(Directory.GetCurrentDirectory() + @"\documentacao\", tipoDocumento);

            isAcessivel = true;
            this.Hide();
            ModalEmail modalEmail = new ModalEmail(sideBar, telaLiberador);
            modalEmail.modalAnexo = this;
            sideBar.openChildForm(modalEmail);
            sideBar.btnEmail.BackColor = Color.DarkGray;
            sideBar.btnAnexos.BackColor = Color.Transparent;
            sideBar.btnAnexos.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewScripts.Items.Count; i++)
            {
               MessageBox.Show(listViewScripts.Items[i].ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in listViewArquivos.Items)
            {
                if (checkBox1.Checked == true)
                {
                    listItem.Checked = true;
                }
                else
                {
                    listItem.Checked = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in listViewScripts.Items)
            {
                if (checkBox2.Checked == true)
                {
                    listItem.Checked = true;
                }
                else
                {
                    listItem.Checked = false;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in listViewDocumentos.Items)
            {
                if (checkBox3.Checked == true)
                {
                    listItem.Checked = true;
                }
                else
                {
                    listItem.Checked = false;
                }
            }
        }
    }
}