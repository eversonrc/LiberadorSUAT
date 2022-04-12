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
        public List<Alteracao> listaAlteracoes = new List<Alteracao>();
        private TelaLiberador telaLiberador;
        private int indice = -1;
        private bool _novaAlteracao { get; set; }
        public TelaAlteracoes(TelaLiberador tela, bool novaAlteracao)
        {
            InitializeComponent();
            telaLiberador = tela;
            _novaAlteracao = novaAlteracao;
        }

        public TelaAlteracoes(TelaLiberador tela, string helpesk, string responsavel, string descricao, string alteracao, int index, bool novaAlteracao)
        {
            InitializeComponent();
            telaLiberador = tela;
            txbHelpdesk.Text = helpesk;
            txbResponsavel.Text = responsavel;
            txbDescricao.Text = descricao;
            indice = index;
            _novaAlteracao = novaAlteracao;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try {
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

                if (
                    //txbHelpdesk.Text != "" &&
                    txbResponsavel.Text != "" &&
                    txbDescricao.Text != "" //&&
                    //txbAlteracao.Text != ""
                )
                {
                    telaLiberador.listViewAlteracoes.Items.Add(new ListViewItem(item));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existem campos não preenchidos. Verifique-os");
                }
            }
            catch (Exception)
            {

            }
            
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                telaLiberador.listViewAlteracoes.Items[indice].SubItems[0].Text = txbHelpdesk.Text;
                telaLiberador.listViewAlteracoes.Items[indice].SubItems[1].Text = txbResponsavel.Text;
                telaLiberador.listViewAlteracoes.Items[indice].SubItems[2].Text = txbDescricao.Text;
                telaLiberador.listViewAlteracoes.Items[indice].SubItems[3].Text = txbAlteracao.Text;

                if (
                    txbHelpdesk.Text != "" &&
                    txbResponsavel.Text != "" &&
                    txbDescricao.Text != "" &&
                    txbAlteracao.Text != ""
                )
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existem campos não preenchidos. Verifique-os");
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void TelaAlteracoes_Load(object sender, EventArgs e)
        {
            if (_novaAlteracao == true)
            {
                btnAlterar.Enabled = false;
            }
            else if (_novaAlteracao == false)
            {
                btnCadastrar.Enabled = false;
            }
        }
    }
}
