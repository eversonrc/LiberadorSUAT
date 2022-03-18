using LiberadorSUAT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Screens.Modals
{
    public partial class ModalAnexos : Form
    {
        private TelaLiberador telaLiberador;
        public ModalAnexos(TelaLiberador tela)
        {
            InitializeComponent();
            ConfigurarToolTip();
            telaLiberador = tela;
            btnAnexo.BackColor = Color.LawnGreen;
        }
        private void ConfigurarToolTip()
        {
            toolTipModalAnexo.AutoPopDelay = 4000;
            toolTipModalAnexo.InitialDelay = 100;
            toolTipModalAnexo.ReshowDelay = 200;

            toolTipModalAnexo.ToolTipTitle = "Dica";
            toolTipModalAnexo.IsBalloon = true;
            toolTipModalAnexo.ToolTipIcon = ToolTipIcon.Info;

            toolTipModalAnexo.SetToolTip(btnAjudaArquivos, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
            toolTipModalAnexo.SetToolTip(btnAjudaScripts, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
            toolTipModalAnexo.SetToolTip(btnAjudaDocs, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
        }

        // ANEXAR Arquivos de compilação
        //
        private void btnAdicionarArquivos_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] path = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath);
                string direc = String.Join("", path);
                DirectoryInfo dInfo = new DirectoryInfo(direc);

                string fullName = dInfo.FullName;

                listBoxArquivos.Items.Add(fullName);

                foreach (FileInfo file in dInfo.GetFiles())
                {
                    listBoxArquivos.Items.Add(file.FullName);
                }
            }
        }
        
        private void btnExcluirArquivos_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.ExcluirArquivos(listBoxArquivos);
        }

        // ANEXAR Documentação
        //
        private void btnAdcionarDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.AdicionarArquivos(listBoxAttachments, 0);
        }
        private void btnExcluirDocumentacao_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.ExcluirArquivos(listBoxAttachments);
        }

        
        // ANEXAR Scripts de Banco de Dados
        //
        private void btnExcluirScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.ExcluirArquivos(listBoxScripts);
        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {
            Arquivo arquivo = new Arquivo();
            arquivo.AdicionarArquivos(listBoxScripts, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //telaLiberador.btnLiberacao.BackColor = Color.Transparent;
            this.Close();
        }

        private void btnTelaEmail_Click(object sender, EventArgs e)
        {
            //btnAnexo.BackColor = Color.LawnGreen;

            ModalEmail modalEmail = new ModalEmail(this);
            modalEmail.ShowDialog();
        }

        private void ModalAnexos_Load(object sender, EventArgs e)
        {

        }

        private void btnLiberacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
