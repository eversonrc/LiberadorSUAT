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

        public TelaAlteracoes()
        {
            InitializeComponent();
            listaAlteracoes = new List<Alteracao>();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             string helpdesk = txbHelpdesk.Text;
             string responsavel = txbResponsavel.Text;
             string descricao = txbDescricao.Text;
             string alteracao = txbAlteracao.Text;

             Alteracao alteracaoRealizada = new Alteracao(helpdesk, responsavel, descricao, alteracao);
             listaAlteracoes.Add(alteracaoRealizada);
          
            foreach (var item in listaAlteracoes)
            {
                //listViewTeste.Items.Add(item.ToString());
                list
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewTeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
