using LiberadorSUAT.Models;
using LiberadorSUAT.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            regras.ShowDialog();
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
            listViewAlteracoes.CheckBoxes = true;
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
            foreach (ListViewItem item in listViewAlteracoes.Items)
            {
                //if (item.Selected) esse código só exclui o item que tá selecionado
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

        private void regras_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {

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

            foreach (ListViewItem item in listViewAlteracoes.Items)
            {
                if (item.Checked)
                {
                    string helpdesk = item.SubItems[0].Text;
                    string responsavel = item.SubItems[1].Text;
                    string descricao = item.SubItems[2].Text;
                    string alteracao = item.SubItems[3].Text;
                    TelaAlteracoes telaAlteracao = new TelaAlteracoes(this, helpdesk, responsavel, descricao, alteracao);
                    telaAlteracao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
        }

        private void btnAdcionarDocumentacao_Click(object sender, EventArgs e)
        {

        }
    }
}
