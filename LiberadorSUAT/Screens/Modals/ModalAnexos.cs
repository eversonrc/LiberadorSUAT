﻿using LiberadorSUAT.Models;
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
            gerarGrade();
            telaLiberador = tela;
            btnAnexo.BackColor = Color.LawnGreen;
        }


        private bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return false;
        }

        private void ConfigurarToolTip()
        {
            toolTipModalAnexo.AutoPopDelay = 4000;
            toolTipModalAnexo.InitialDelay = 100;
            toolTipModalAnexo.ReshowDelay = 200;
            toolTipModalAnexo.ToolTipTitle = "Dica";
            toolTipModalAnexo.IsBalloon = true;
            toolTipModalAnexo.ToolTipIcon = ToolTipIcon.Info;

            toolTipModalAnexo.SetToolTip(btnAjudaArquivos, "Selecione o diretório de arquivos desejado.");
            toolTipModalAnexo.SetToolTip(btnAjudaScripts, "Selecione arquivos de banco de dados com as extensôes .sql");
            toolTipModalAnexo.SetToolTip(btnAjudaDocs, "Insira as alterações realizadas no sistema de acordo com o helpdesk informado.");
        }


        private void gerarGrade()
        {
            listViewArquivos.Columns.Add("", -2).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.Columns.Add("Arquivo", -2).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.Columns.Add("Caminho do arquivo", 500).TextAlign = HorizontalAlignment.Center;
            listViewArquivos.View = View.Details;

            listViewArquivos.FullRowSelect = true;
            listViewArquivos.GridLines = true;
            listViewArquivos.CheckBoxes = true;
        }

        // ANEXAR Arquivos de compilação
        //
        private void btnAdicionarArquivos_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo diretorioInicial = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                DirectoryInfo[] directories = diretorioInicial.GetDirectories("*", SearchOption.AllDirectories);
                FileInfo[] files = diretorioInicial.GetFiles("*.*", SearchOption.AllDirectories);
                ListViewItem listView = new ListViewItem();

                foreach (DirectoryInfo dir in directories)
                {
                    foreach (FileInfo file in files)
                    {
                        if (!this.IsFileLocked(file))
                        {
                            string nome = file.Name;
                            string caminho = file.FullName;

                            listView.SubItems.Add(nome);
                            listView.SubItems.Add(caminho);
                            listViewArquivos.Items.Add(listView);
                        }
                    }
                }

            }
        }

        private void btnExcluirArquivos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewArquivos.Items)
            {
                if (item.Checked)
                {
                    listViewArquivos.Items.RemoveAt(item.Index);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi selecionada.");
                }
            }
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
            arquivo.AdicionarArquivos(listBoxScripts, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTelaEmail_Click(object sender, EventArgs e)
        {
            ModalEmail modalEmail = new ModalEmail(telaLiberador, this);
            modalEmail.ShowDialog();
        }



        private void ModalAnexos_Load(object sender, EventArgs e)
        {

        }


        private void btnLiberacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void listViewArquivos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}