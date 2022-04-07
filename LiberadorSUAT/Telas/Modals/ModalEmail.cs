using LiberadorSUAT.Models.Auxiliares;
using Microsoft.SharePoint.Client;
using MongoDB.Bson;
using MongoDB.Driver;
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

        public ConexaoMongo conexaoMongo { get; set; }

        public ModalEmail(SideBarLayout side, TelaLiberador tela)
        {
            InitializeComponent();
            sideBar = side;
            telaLiberador = tela;
            isAcessivel = false;
            conexaoMongo = new ConexaoMongo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            
            switch (telaLiberador.Sistema)
            {
                case "Evasores":
                   var updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;

                case "SUATMobilidade":
                    updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;

                case "VLTRio":
                    updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;

                case "Automatizador":
                    updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;

                case "Barcas":
                    updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;

                default:
                    updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
                    conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
                    break;
            }


            Email email = new Email(sideBar, telaLiberador, modalAnexo);
            isAcessivel = true;
            email.GetApplicationObject();
  
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
