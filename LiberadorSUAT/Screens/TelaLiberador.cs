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

namespace LiberadorSUAT
{
    public partial class TelaLiberador : System.Windows.Forms.Form
    {
        private SideBarLayout sideBar;
        public String Sistema { get; set; }
        public String TipoLiberacao { get; set; }
        public String[] DadosConfiguracao { get; set; }

       // public Microsoft.SharePoint.Client.FileInformation fileInfo;
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

            switch (Sistema)
            {
                case "Evasores":
                    txbSigla.Text = "EVA";
                    txbVersao.Text = DadosConfiguracao[1];
                    txbRelease.Text = DadosConfiguracao[2];
                     break;

                case "SUATMobilidade":
                    txbSigla.Text = "SUAT";
                    txbVersao.Text = DadosConfiguracao[4];
                    txbRelease.Text = DadosConfiguracao[5];
                    break;

                case "VLTRio":
                    txbSigla.Text = "VLT";
                    txbVersao.Text = DadosConfiguracao[7];
                    txbRelease.Text = DadosConfiguracao[8];
                    break;

                case "Automatizador":
                    txbSigla.Text = "AUTO";
                    txbVersao.Text = DadosConfiguracao[10];
                    txbRelease.Text = DadosConfiguracao[11];
                    break;

                case "Barcas":
                    txbSigla.Text = "BRC";
                    txbVersao.Text = DadosConfiguracao[13];
                    txbRelease.Text = DadosConfiguracao[14];
                    break;

                default:
                    break;
            }
        }

        private void TelaLiberador_Load(object sender, EventArgs e)
        {
            DownloadArquivo();

            using (var fs = new FileStream("arquivoConfiguracao.txt", FileMode.Open))
            {
                using (var leitor = new StreamReader(fs))
                {
                    int i = 0;
                    DadosConfiguracao = new string[30];

                    while (!leitor.EndOfStream)
                    {
                        string dado = leitor.ReadLine();
                        DadosConfiguracao[i] = dado;
                        i++;
                    }
                }
            }

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
            switch (Sistema)
            {
                case "Evasores":
                    if (txbVersao.Text != DadosConfiguracao[1])
                    {
                        txbRelease.Text = "0";
                    }
                    break;

                case "SUATMobilidade":
                    if (txbVersao.Text != DadosConfiguracao[4])
                    {
                        txbRelease.Text = "0";
                    }
                    break;

                case "VLTRio":
                    if (txbVersao.Text != DadosConfiguracao[7])
                    {
                        txbRelease.Text = "0";
                    }
                    break;

                case "Automatizador":
                    if(txbVersao.Text != DadosConfiguracao[10])
                    {
                        txbRelease.Text = "0";
                    }
                    break;

                case "Barcas":
                    if (txbVersao.Text != DadosConfiguracao[13])
                    {
                        txbRelease.Text = "0";
                    }
                    break;

                default:
                    break;

            }
        }

        public void DownloadArquivo()
        {
            string sharePointSite = "https://adntec.sharepoint.com/sites/Operacoes/ccr";
            using (ClientContext ctx = new ClientContext(sharePointSite))
            {
                string account = "iolanda.pereira@adn.com.br";
                string password = "Aselecao@2021";
                var secretPassword = new SecureString();

                foreach (char c in password)
                {
                    secretPassword.AppendChar(c);
                }
                ctx.Credentials = new SharePointOnlineCredentials(account, secretPassword);
                ctx.Load(ctx.Web);
                ctx.ExecuteQuery();

                string libraryTitle = "Documentos";
                Microsoft.SharePoint.Client.List list = ctx.Web.Lists.GetByTitle(libraryTitle);

                string url = @"/sites/Operacoes/ccr/Documentos Compartilhados/pastaTesteLiberador/arquivoConfiguracao.txt";
                ctx.Load(list);
                ctx.ExecuteQuery();

                using (var fileInfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(ctx, url))
                {
                    var fileName = Path.Combine(@"C:\Workspace\CCR\DesafioTecnico\LiberadorSUAT\bin\Debug\", Path.GetFileName(url));
                    using (var fileStream = System.IO.File.Create(fileName))
                    {
                        fileInfo.Stream.CopyTo(fileStream);
                    }
                }
            };
        }

    }
}
