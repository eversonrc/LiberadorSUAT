using LiberadorSUAT.Models;
using LiberadorSUAT.Screens;
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

namespace LiberadorSUAT
{
    public partial class TelaLiberador : Form
    {

        public TelaLiberador()
        {
            InitializeComponent();
            //regras.ShowDialog();
            gerarGrade();
        }

        private void gerarGrade()
        {
            listViewAlteracoes.Columns.Add("Helpdesk", 100).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Responsável", 150).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Descrição", 250).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Alteração", 250).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.View = View.Details;

            listViewAlteracoes.FullRowSelect = true;
            listViewAlteracoes.GridLines = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Liberar(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listViewAlteracoes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluirAlteracao_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listBoxAttachments.Items)
            {
                if (item.Selected)
                {
                    listBoxAttachments.Items.RemoveAt(item.Index);
                }
            }
        }

        private void regras_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {
            listBoxScripts.IntegralHeight = true;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
             "|Office Files|*.doc;*.xls;*.ppt" +
             "|All Files|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        listBoxScripts.Items.Add(file);
                    }
                }
            }

            // Display a horizontal scroll bar.
            listBoxScripts.HorizontalScrollbar = true;

            //// Create a Graphics object to use when determining the size of the largest item in the ListBox.
            //Graphics g = listBoxAttachments.CreateGraphics();

            //// Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
            //int hzSize = (int)g.MeasureString(listBoxAttachments.Items[listBoxAttachments.Items.Count - 1].ToString(), listBoxAttachments.Font).Width;
            //// Set the HorizontalExtent property.
            //listBoxAttachments.HorizontalExtent = hzSize;
        }

        private void btnNovoAlteracao_Click(object sender, EventArgs e)
        {
            TelaAlteracoes telaAlteracao = new TelaAlteracoes(this);
            telaAlteracao.ShowDialog();
        }

        private void regras_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.GetApplicationObject();
        }

        private void btnAlterarAlteracao_Click(object sender, EventArgs e)
        {
            //passar nos parâmetros abaixo o valor selecionado do listview
            string helpdesk = listViewAlteracoes.SelectedItems[0].ToString();
            /*string responsavel = listViewAlteracoes.SelectedItems[1].ToString(); 
            string descricao = listViewAlteracoes.SelectedItems[2].ToString();
            string alteracao = listViewAlteracoes.SelectedItems[3].ToString();*/
            TelaAlteracoes tela = new TelaAlteracoes(this, helpdesk, "Iolanda", "Teste", "X");
            tela.ShowDialog();
        }

        private void btnAdcionarDocumentacao_Click(object sender, EventArgs e)
        {
            listBoxAttachments.IntegralHeight = true;

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
             "|Office Files|*.doc;*.xls;*.ppt" +
             "|All Files|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        listBoxAttachments.Items.Add(file);

                        //NotSupportedException
                        //path está em um formato inválido.
                    }
                }
            }

        // Display a horizontal scroll bar.
        listBoxAttachments.HorizontalScrollbar = true;

            //// Create a Graphics object to use when determining the size of the largest item in the ListBox.
            //Graphics g = listBoxAttachments.CreateGraphics();

            //// Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
            //int hzSize = (int)g.MeasureString(listBoxAttachments.Items[listBoxAttachments.Items.Count - 1].ToString(), listBoxAttachments.Font).Width;
            //// Set the HorizontalExtent property.
            //listBoxAttachments.HorizontalExtent = hzSize;
        }

        private void btnExcluirDocumentacao_Click(object sender, EventArgs e)
        {
            for(int i = listBoxAttachments.SelectedIndices.Count -1; i >= 0; i--)
            {
                if(listBoxAttachments.SelectedIndex != -1)
                {
                    listBoxAttachments.Items.RemoveAt(listBoxAttachments.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Selecione os arquivos que deseja excluir");
                }
            }
        }

        private void btnExcluirScript_Click(object sender, EventArgs e)
        {
            for (int i = listBoxScripts.SelectedIndices.Count - 1; i >= 0; i--)
            {
                if (listBoxScripts.SelectedIndex != -1)
                {
                    listBoxScripts.Items.RemoveAt(listBoxScripts.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Selecione os arquivos que deseja excluir");
                }
            }
        }
    }
}
