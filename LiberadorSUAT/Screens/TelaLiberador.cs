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

        }

        private void regras_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarScript_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoAlteracao_Click(object sender, EventArgs e)
        {
            TelaAlteracoes telaAlteracao = new TelaAlteracoes();
            telaAlteracao.ShowDialog();
        }

        private void regras_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
