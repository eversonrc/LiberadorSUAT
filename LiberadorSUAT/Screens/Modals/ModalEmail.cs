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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Screens.Modals
{
    public partial class ModalEmail : System.Windows.Forms.Form
    {
        public static bool isAcessivel { get; set; }
        public SideBarLayout sideBar { get; set; }
        public ModalAnexos modalAnexo { get; set; }
        public TelaLiberador telaLiberador { get; set; }
        public String[] LinhasArquivo { get; set; }

        public ModalEmail(SideBarLayout side, TelaLiberador tela)
        {
            InitializeComponent();
            sideBar = side;
            telaLiberador = tela;
            isAcessivel = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            EscreverArquivoConfiguracao();

            UploadArquivo();

            Email email = new Email(sideBar, telaLiberador, modalAnexo);
            isAcessivel = true;
            email.GetApplicationObject();
  
        }

        private void EscreverArquivoConfiguracao()
        {
            string caminho = @"arquivoConfiguracao.txt";
            LinhasArquivo = new string[30];
            LinhasArquivo = telaLiberador.DadosConfiguracao;

            using (var fs = new FileStream(caminho, FileMode.Open))
            {
                using (var escritor = new StreamWriter(fs))
                {
                    switch (telaLiberador.Sistema)
                    {
                        case "Evasores":
                            LinhasArquivo[1] = telaLiberador.txbVersao.Text;
                            LinhasArquivo[2] = telaLiberador.txbRelease.Text;
                            break;

                        case "SUATMobilidade":

                            LinhasArquivo[4] = telaLiberador.txbVersao.Text;
                            LinhasArquivo[5] = telaLiberador.txbRelease.Text;
                            break;

                        case "VLTRio":
                            LinhasArquivo[7] = telaLiberador.txbVersao.Text;
                            LinhasArquivo[8] = telaLiberador.txbRelease.Text;
                            break;

                        case "Automatizador":
                            LinhasArquivo[10] = telaLiberador.txbVersao.Text;
                            LinhasArquivo[11] = telaLiberador.txbRelease.Text;
                            break;

                        case "Barcas":
                            LinhasArquivo[13] = telaLiberador.txbVersao.Text;
                            LinhasArquivo[14] = telaLiberador.txbRelease.Text;
                            break;

                        default:
                            break;
                    }

                    for (int i=0; i < LinhasArquivo.Length; i++)
                    {
                        escritor.WriteLine(LinhasArquivo[i]);
                    }
                }
            }

        }

        private void UploadArquivo()
        {
            String FilePath = @"arquivoConfiguracao.txt";
            string Library = "Documentos";
            string SiteUrl = @"https://adntec.sharepoint.com/sites/Operacoes/ccr/";
            string FileName = FilePath.Substring(FilePath.LastIndexOf("\\") + 1);

            using (ClientContext ctx = new ClientContext(SiteUrl))
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

                FileCreationInformation newFile = new FileCreationInformation();
                newFile.Content = System.IO.File.ReadAllBytes(FilePath);
                newFile.Url = System.IO.Path.GetFileName(FilePath);

                string libraryTitle = "Documentos";
                List oList = ctx.Web.Lists.GetByTitle(libraryTitle);
                //Add Folder 
                var folders = oList.RootFolder.Folders;
                ctx.Load(folders);
                ctx.ExecuteQuery();
                var folder = folders.Where(r => r.Name == "TopFolder");
                var folder1 = folder.FirstOrDefault();
                Microsoft.SharePoint.Client.File uploadFile = oList.RootFolder.Files.Add(newFile);
                //Microsoft.SharePoint.Client.File uploadFile = folder1.Files.Add(newFile);
                ctx.Load(uploadFile);
                ctx.ExecuteQuery();
                ListItem item = uploadFile.ListItemAllFields;
                string docTitle = string.Empty;
                item["Title"] = docTitle;
                item.Update();
                ctx.ExecuteQuery();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            modalAnexo.Show();
            sideBar.btnAnexos.BackColor = Color.DarkGray;
            sideBar.btnEmail.BackColor = Color.Transparent;
            sideBar.btnInfos.Enabled = false;
            sideBar.btnEnvio.Enabled = false;
            sideBar.btnEmail.Enabled = false;
        }

        private void ModalEmail_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
