﻿using LiberadorSUAT.Models;
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
        public string sistema = "";
        public string tipoLiberacao = "";
        public string versao = "";
        public string release = "";
        public string titulo = "";
        public ListView teste = new ListView();
        private SideBarLayout sideBar;
        public TelaLiberador(SideBarLayout side)
        {
            InitializeComponent();
            ConfigurarToolTip();
            gerarGrade();
            sideBar = side;
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
            listViewAlteracoes.View = View.Details;

            listViewAlteracoes.FullRowSelect = true;
            listViewAlteracoes.GridLines = true;
            listViewAlteracoes.CheckBoxes = true;
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
       
        public ListView getListViewAlteracoes()
        {
            return listViewAlteracoes;
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
        }

        private void btnAjudaAlteracoes_Click(object sender, EventArgs e)
        {

        }

        private void btnModalAnexos_Click(object sender, EventArgs e)
        {
            sideBar.openChildForm(sideBar.modalAnexos);
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
                    sistema = listBoxSistemas.Items[i].ToString();
                }
            }

            switch (sistema)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txbSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listViewAlteracoes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txbRelease_TextChanged(object sender, EventArgs e)
        {
            release = txbRelease.Text;
        }

        private void txbVersao_TextChanged(object sender, EventArgs e)
        {
            versao = txbVersao.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listTipoLiberacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listTipoLiberacao.Items.Count; i++)
            {
                if (listTipoLiberacao.GetSelected(i))
                {
                    tipoLiberacao = listTipoLiberacao.Items[i].ToString();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbTitulo_TextChanged(object sender, EventArgs e)
        {
            titulo = txbTitulo.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TelaLiberador_Load(object sender, EventArgs e)
        {

        }
    }
}