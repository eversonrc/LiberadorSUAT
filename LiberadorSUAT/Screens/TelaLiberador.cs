using LiberadorSUAT.Models;
using LiberadorSUAT.Screens;
using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT
{
    public partial class TelaLiberador : Form
    {
        public TelaLiberador()
        {
            InitializeComponent();
            ConfigurarToolTip();
            gerarGrade();
            btnLiberacao.BackColor = Color.LawnGreen;
        }
        private void gerarGrade()
        {
            listViewAlteracoes.Columns.Add("Helpdesk", 100).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Responsável", 150).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Descrição", 260).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Alteração", 260).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.View = View.Details;

            listViewAlteracoes.FullRowSelect = true;
            listViewAlteracoes.GridLines = true;
            listViewAlteracoes.CheckBoxes = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnExcluirAlteracao_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewAlteracoes.Items)
            {
                if (item.Checked)
                {
                    listViewAlteracoes.Items.RemoveAt(item.Index);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
        }
        private void btnNovoAlteracao_Click(object sender, EventArgs e)
        {
            TelaAlteracoes telaAlteracao = new TelaAlteracoes(this);
            telaAlteracao.ShowDialog();
        }
        private void btnAlterarAlteracao_Click(object sender, EventArgs e)
        { 
            foreach (ListViewItem item in listViewAlteracoes.Items)
            {
                if (item.Checked)
                {
                    int indice = listViewAlteracoes.Items.IndexOf(item);
                    string helpdesk = item.SubItems[0].Text;
                    string responsavel = item.SubItems[1].Text;
                    string descricao = item.SubItems[2].Text;
                    string alteracao = item.SubItems[3].Text;
                    TelaAlteracoes telaAlteracao = new TelaAlteracoes(this, helpdesk, responsavel, descricao, alteracao, indice);
                    telaAlteracao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.GetApplicationObject();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLiberarVersao_Click(object sender, EventArgs e)
        {

        }
        private void ConfigurarToolTip()
        {
            toolTipTelaLiberador.AutoPopDelay = 4000;
            toolTipTelaLiberador.InitialDelay = 100;
            toolTipTelaLiberador.ReshowDelay = 200;

            toolTipTelaLiberador.ToolTipTitle = "Dica";
            toolTipTelaLiberador.IsBalloon = true;
            toolTipTelaLiberador.ToolTipIcon = ToolTipIcon.Info;

            toolTipTelaLiberador.SetToolTip(btnAjudaAlteracoes, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
            //toolTipTelaLiberador.SetToolTip(btnModalAnexos, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
        }

        private void btnAjudaAlteracoes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModalAnexos_Click(object sender, EventArgs e)
        {
            //btnLiberacao.BackColor = Color.LawnGreen;

            ModalAnexos anexo = new ModalAnexos(this);
            anexo.ShowDialog();
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            RegrasLiberacao regras = new RegrasLiberacao();
            regras.ShowDialog();
        }
        private void listBoxSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = listBoxSistemas.SelectedItem.ToString();

            switch (item)
            {
                case "Evasores":
                    txbSigla.Text = "EVA";
                    break;

                case "SUATMobilidade":
                    txbSigla.Text = "SUAT";
                    break;

                case "VLTRio":
                    txbSigla.Text = "VLT";
                    break;

                case "Automatizador":
                    txbSigla.Text = "AUTO";
                    break;

                case "Barcas":
                    txbSigla.Text = "BRC";
                    break;

                default:
                    MessageBox.Show("Selecione um sistema.");
                    break;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
