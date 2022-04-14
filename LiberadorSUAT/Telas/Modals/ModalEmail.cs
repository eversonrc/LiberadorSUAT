using LiberadorSUAT.Entidades.Auxiliares;
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
        public SideBarLayout sideBar { get; set; }
        public ModalAnexos modalAnexo { get; set; }
        public TelaLiberador telaLiberador { get; set; }
        public ConexaoMongo conexaoMongo { get; set; }

        public UpdateDefinition<Sistema> updateBanco { get; set; }

        public Alfabeto alfabeto { get; set; }

        public ModalEmail(SideBarLayout side, TelaLiberador tela)
        {
            InitializeComponent();
            sideBar = side;
            telaLiberador = tela;
            conexaoMongo = new ConexaoMongo();
            alfabeto = new Alfabeto();
        }
 
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (telaLiberador.versaoEReleaseAlterados == true)
            {
                switch (telaLiberador.Sistema)
                {
                    case "Evasores":
                        AtualizarVersaoERelease();
                        break;

                    case "SUATMobilidade":
                        AtualizarVersaoERelease();
                        break;

                    case "VLTRio":
                        AtualizarVersaoERelease();
                        break;

                    case "Automatizador Rodovias":
                        AtualizarVersaoERelease();
                        break;

                    case "Automatizador Mobilidade":
                        AtualizarVersaoERelease();
                        break;

                    case "Barcas":
                        AtualizarVersaoERelease();
                        break;

                    default:
                        AtualizarVersaoERelease();
                        break;
                }
            }

            else
            {
                switch (telaLiberador.Sistema)
                {
                    case "Evasores":
                        AtualizarRelease();
                        break;

                    case "SUATMobilidade":
                        AtualizarRelease();
                        break;

                    case "VLTRio":
                        AtualizarRelease();
                        break;

                    case "Automatizador Rodovias":
                        AtualizarRelease();
                        break;

                    case "Automatizador Mobilidade":
                        AtualizarRelease();
                        break;

                    case "Barcas":
                        AtualizarRelease();
                        break;

                    default:
                        AtualizarRelease();
                        break;
                }
            }

            Email email = new Email(sideBar, telaLiberador, modalAnexo);
            email.GetApplicationObject();
        }

        private void AtualizarRelease()
        {
            updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", alfabeto.proximaLetraAlfabeto(telaLiberador.txbRelease.Text));
            conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
        }

        private void AtualizarVersaoERelease()
        {
            updateBanco = Builders<Sistema>.Update.Set("versao", telaLiberador.txbVersao.Text).Set("release", telaLiberador.txbRelease.Text);
            conexaoMongo.colecaoSistema.UpdateOne(s => s.Nome == (telaLiberador.Sistema), updateBanco);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            modalAnexo.Show();
            sideBar.btnAnexos.BackColor = Color.DarkGray;
            sideBar.btnEmail.BackColor = Color.Transparent;
            sideBar.btnInfos.Enabled = false;
            sideBar.btnEmail.Enabled = false;
        }
    }
}
