using LiberadorSUAT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiberadorSUAT.Screens;
using System.Windows.Forms;


namespace LiberadorSUAT.Screens
{
    public partial class TelaAlteracoes : Form
    {
        public List<Alteracao> listaAlteracoes;
        private TelaLiberador telaLiberador;

        public TelaAlteracoes(TelaLiberador tela)
        {
            InitializeComponent();
            telaLiberador = tela;
           // listaAlteracoes = new List<Alteracao>();
        }

        public TelaAlteracoes(TelaLiberador tela, string helpesk, string responsavel, string descricao, string alteracao)
        {
            InitializeComponent();
            telaLiberador = tela;
            txbHelpdesk.Text = helpesk;
            txbResponsavel.Text = responsavel;
            txbDescricao.Text = descricao;
            txbAlteracao.Text = alteracao;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            listaAlteracoes = new List<Alteracao>();

            string helpdesk = txbHelpdesk.Text;
            string responsavel = txbResponsavel.Text;
            string descricao = txbDescricao.Text;
            string alteracaoRealizada = txbAlteracao.Text;
            listaAlteracoes.Add(new Alteracao(helpdesk, responsavel, descricao, alteracaoRealizada));

            string[] item = new string[4];

            foreach (Alteracao alteracao in listaAlteracoes)
            {
                item[0] = alteracao.HelpDesk;
                item[1] = alteracao.Responsavel;
                item[2] = alteracao.Descricao;
                item[3] = alteracao.AlteracaoRealizada;
            }

            telaLiberador.listViewAlteracoes.Items.Add(new ListViewItem(item));

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewTeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbHelpdesk_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
