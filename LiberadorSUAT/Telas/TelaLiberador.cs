using LiberadorSUAT.Models;
using LiberadorSUAT.Screens;
using LiberadorSUAT.Screens.Modals;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Collections.Generic;
using MongoDB.Driver;
using LiberadorSUAT.Models.Auxiliares;
using System.Collections.ObjectModel;

namespace LiberadorSUAT
{
    public partial class TelaLiberador : System.Windows.Forms.Form
    {
        private SideBarLayout sideBar;
        public String Sistema { get; set; }
        public String TipoLiberacao { get; set; }
        public String[] DadosConfiguracao { get; set; }

        public ConexaoMongo conexaoMongo;
        

        public TelaLiberador(SideBarLayout side)
        {
            InitializeComponent();
            ConfigurarToolTip();
            gerarGrade();
            sideBar = side;
            conexaoMongo = new ConexaoMongo();
        }

        public TelaLiberador()
        {
        }

        private void gerarGrade()
        {
            listViewAlteracoes.Columns.Add("Helpdesk", 100).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Responsável", 150).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Descrição", 260).TextAlign = HorizontalAlignment.Center;
            listViewAlteracoes.Columns.Add("Alteração", 260).TextAlign = HorizontalAlignment.Center;

            listViewAlteracoes.View = System.Windows.Forms.View.Details;

            listViewAlteracoes.FullRowSelect = true;
            listViewAlteracoes.GridLines = true;
            listViewAlteracoes.CheckBoxes = true;
        }

         private bool validadorCampos()
        {
            if (
                txbTitulo.Text != "" &&
                txbVersao.Text != "" &&
                txbRelease.Text != "" &&
                txbSigla.Text != "" &&
                listViewAlteracoes.Items.Count > 0
            )
            {
                return true;
            }

            return false;
        }

        private void btnExcluirAlteracao_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewAlteracoes.Items)
            {
                if (item.Checked)
                {
                    listViewAlteracoes.Items.RemoveAt(item.Index);
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
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnModalAnexos_Click(object sender, EventArgs e)
        {

            if (validadorCampos() == true)
            {
                this.Hide();
                ModalAnexos modalAnexo = new ModalAnexos(sideBar);
                modalAnexo.telaLiberador = this;
                sideBar.openChildForm(modalAnexo);
                sideBar.btnAnexos.BackColor = Color.DarkGray;
                sideBar.btnInfos.BackColor = Color.Transparent;
                sideBar.btnInfos.Enabled = false;
                sideBar.btnEnvio.Enabled = false;
                sideBar.btnEmail.Enabled = false;
            }
            else
            {
                MessageBox.Show("Todos os campo devem ser preenchidos antes de avançar para a próxima etapa. Por favor verifique os dados novamente.");
            }
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            RegrasLiberacao regras = new RegrasLiberacao();
            regras.ShowDialog();
        }
        private void listBoxSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxSistemas.Items.Count; i++)
            {
                if (listBoxSistemas.GetSelected(i))
                {
                    Sistema = listBoxSistemas.Items[i].ToString();
                }
            }

            List<Sistema> listaSistema = conexaoMongo.getSistemas();

            switch (Sistema)
            {
                case "Evasores":
                    foreach(var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Evasores")
                        {
                            int indice = listaSistema.IndexOf(sistema);
                            txbSigla.Text = listaSistema[indice].Sigla;
                            txbVersao.Text = listaSistema[indice].Versao.ToString();
                            txbRelease.Text = listaSistema[indice].Release.ToString();
                        }
                    }
                    break;

                case "SUATMobilidade":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "SUATMobilidade")
                        {
                            int indice = listaSistema.IndexOf(sistema);
                            txbSigla.Text = listaSistema[indice].Sigla;
                            txbVersao.Text = listaSistema[indice].Versao.ToString();
                            txbRelease.Text = listaSistema[indice].Release.ToString();
                        }
                    }
                    break;

                case "VLTRio":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "VLTRio")
                        {
                            int indice = listaSistema.IndexOf(sistema);
                            txbSigla.Text = listaSistema[indice].Sigla;
                            txbVersao.Text = listaSistema[indice].Versao.ToString();
                            txbRelease.Text = listaSistema[indice].Release.ToString();
                        }
                    }
                    break;

                case "Automatizador":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Automatizador")
                        {
                            int indice = listaSistema.IndexOf(sistema);
                            txbSigla.Text = listaSistema[indice].Sigla;
                            txbVersao.Text = listaSistema[indice].Versao.ToString();
                            txbRelease.Text = listaSistema[indice].Release.ToString();
                        }
                    }
                    break;

                case "Barcas":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Barcas")
                        {
                            int indice = listaSistema.IndexOf(sistema);
                            txbSigla.Text = listaSistema[indice].Sigla;
                            txbVersao.Text = listaSistema[indice].Versao.ToString();
                            txbRelease.Text = listaSistema[indice].Release.ToString();
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void TelaLiberador_Load(object sender, EventArgs e)
        {
  
            txbSigla.Enabled = false;

            sideBar.btnInfos.BackColor = Color.DarkGray;
            sideBar.btnAnexos.Enabled = false;
            sideBar.btnEmail.Enabled = false;
            sideBar.btnEnvio.Enabled = false;
        }

        private void listBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxTipos.Items.Count; i++)
            {
                if (listBoxTipos.GetSelected(i))
                {
                    TipoLiberacao = listBoxTipos.Items[i].ToString();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbRelease_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbVersao_TextChanged(object sender, EventArgs e)
        {

            List<Sistema> listaSistema = conexaoMongo.getSistemas();

            switch (Sistema)
            {
                case "Evasores":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Evasores")
                        {
                            int indice = listaSistema.IndexOf(sistema);

                            if (txbVersao.Text != listaSistema[indice].Versao)
                            {
                                txbRelease.Text = "0";
                            }
                        } 
                    }
                    break;

                case "SUATMobilidade":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "SUATMobilidade")
                        {
                            int indice = listaSistema.IndexOf(sistema);

                            if (txbVersao.Text != listaSistema[indice].Versao)
                            {
                                txbRelease.Text = "0";
                            }
                        }
                    }
                    break;

                case "VLTRio":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "VLTRio")
                        {
                            int indice = listaSistema.IndexOf(sistema);

                            if (txbVersao.Text != listaSistema[indice].Versao)
                            {
                                txbRelease.Text = "0";
                            }
                        }
                    }
                    break;

                case "Automatizador":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Automatizador")
                        {
                            int indice = listaSistema.IndexOf(sistema);

                            if (txbVersao.Text != listaSistema[indice].Versao)
                            {
                                txbRelease.Text = "0";
                            }
                        }
                    }
                    break;

                case "Barcas":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Barcas")
                        {
                            int indice = listaSistema.IndexOf(sistema);

                            if (txbVersao.Text != listaSistema[indice].Versao)
                            {
                                txbRelease.Text = "0";
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listViewAlteracoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjudaAlteracoes_Click(object sender, EventArgs e)
        {

        }
    }
}
