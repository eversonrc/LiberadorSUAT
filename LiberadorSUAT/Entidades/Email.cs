using Microsoft.Office.Interop.Outlook;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using LiberadorSUAT.Models;
using LiberadorSUAT.Screens.Modals;
using LiberadorSUAT.Screens;
using LiberadorSUAT.Models.Auxiliares;
using System.Collections.Generic;

namespace LiberadorSUAT
{
    public class Email
    {
        public SideBarLayout sideBar { get; set; }
        public TelaLiberador telaLiberador { get; set; }
        public ModalAnexos modalAnexo { get; set; }

        public ConexaoMongo conexaoMongo { get; set; }

        public List<Sistema> listaSistema { get; set; }

        public List<ConfiguracaoFTP> configuracaoFTP { get; set; }

        public Email(SideBarLayout side, TelaLiberador tela, ModalAnexos modal)
        {
            sideBar = side;
            telaLiberador = tela;
            modalAnexo = modal;
            conexaoMongo = new ConexaoMongo();
            listaSistema = conexaoMongo.getSistemas();
            configuracaoFTP = conexaoMongo.getConfigFTP();
        }

        private string carregarHTML()
        {
            string body = string.Empty;
            string caminho = @"C:\Workspace\CCR\DesafioTecnico\LiberadorSUAT\EmailTemplate.txt";

            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        while (!reader.EndOfStream)
                        {
                             body = reader.ReadToEnd();
                        }
                    }
                }

                body = body.Replace("{nomeSistema}", telaLiberador.Sistema);
                body = body.Replace("{numVersao}", telaLiberador.txbVersao.Text);
                body = body.Replace("{numRelease}", telaLiberador.txbRelease.Text);
                body = body.Replace("{tpLiberacao}", telaLiberador.TipoLiberacao);
                body = body.Replace("{lclArquivoFtp}", configuracaoFTP[0].Caminho);

                string alteracoes = "";
                for (int i=0; i < telaLiberador.listViewAlteracoes.Items.Count; i++)
                {
                    string teste= "<tr>";
                    teste += "<td style = \"font-size: 12px;\" >{helpdesk}</td > ";
                    teste += "<td style = \"font-size: 12px;\" >{responsavel}</td >";
                    teste += "<td style = \"font-size: 12px;\" >{descChamado}</td >";
                    teste += "<td style = \"font-size: 12px;\" >{altChamado}</td>";
                    teste += "</tr>";

                    teste = teste.Replace("{helpdesk}", telaLiberador.listViewAlteracoes.Items[i].SubItems[0].Text);
                    teste = teste.Replace("{responsavel}", telaLiberador.listViewAlteracoes.Items[i].SubItems[1].Text);
                    teste = teste.Replace("{descChamado}", telaLiberador.listViewAlteracoes.Items[i].SubItems[2].Text);
                    teste = teste.Replace("{altChamado}", telaLiberador.listViewAlteracoes.Items[i].SubItems[3].Text);
                    alteracoes += teste;
                }
                body = body.Replace("%gridAlteracoes%", alteracoes);

                string arquivos = "";
                for (int i = 0; i < modalAnexo.listViewArquivos.Items.Count; i++)
                {
                    string teste = "<tr>";
                    teste += "<td style = \"font-size: 12px;\">{nomeArquivo}</td>";
                    teste += "</tr>";

                    teste = teste.Replace("{nomeArquivo}", modalAnexo.listViewArquivos.Items[i].SubItems[1].Text);
                    arquivos += teste;
                }
                body = body.Replace("%gridArquivos%", arquivos);

                string scripts = "";
                for (int i = 0; i < modalAnexo.listViewScripts.Items.Count; i++)
                {
                    string teste = "<tr>";
                    teste += "<td style = \"font-size: 12px;\">{nomeScript}</td>";
                    teste += "</tr>";

                    teste = teste.Replace("{nomeScript}", modalAnexo.listViewScripts.Items[i].SubItems[1].Text);
                    scripts += teste;
                }
                body = body.Replace("%gridScripts%", scripts);

                string documentacoes = "";
                for (int i = 0; i < modalAnexo.listViewDocumentos.Items.Count; i++)
                {
                    string teste = "<tr>";
                    teste += "<td style = \"font-size: 12px;\" >{nomeDoc}</td > ";
                    teste += "</tr>";

                    teste = teste.Replace("{nomeDoc}", modalAnexo.listViewDocumentos.Items[i].SubItems[1].Text);
                    documentacoes += teste;
                }
                body = body.Replace("%gridDocumentacoes%", documentacoes);
            }
            catch
            {
                MessageBox.Show("Erro ao carregar HTML");
            }
            return body;
        }

       public void montaEmail(Outlook.Application application)
        {
            Outlook.MailItem message = (Outlook.MailItem)application.CreateItem(Outlook.OlItemType.olMailItem);
            int indice = -1;

            switch (telaLiberador.Sistema)
            {
                case "Evasores":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Evasores")
                        {
                            indice = listaSistema.IndexOf(sistema);

                            EnderecoEmail[] enderecosEmail = listaSistema[indice].grupoEmail.destinatarios;

                            string[] destinatarios = new string[enderecosEmail.Length];

                            for (int i = 0; i < enderecosEmail.Length; i++)
                            {
                                destinatarios[i] = (enderecosEmail[i].enderecoEmail);
                            }

                            foreach (var destinatario in destinatarios)
                            {
                                message.To += destinatario;
                            }
                        }    
                    }

                    break;

                case "SUATMobilidade":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "SUATMobilidade")
                        {
                            indice = listaSistema.IndexOf(sistema);

                            EnderecoEmail[] enderecosEmail = listaSistema[indice].grupoEmail.destinatarios;

                            string[] destinatarios = new string[enderecosEmail.Length];

                            for (int i = 0; i < enderecosEmail.Length; i++)
                            {
                                destinatarios[i] = (enderecosEmail[i].enderecoEmail);
                            }

                            foreach (var destinatario in destinatarios)
                            {
                                message.To += destinatario;
                            }
                        }
                    }

                    break;


                case "VLTRio":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "VLTRio")
                        {
                            indice = listaSistema.IndexOf(sistema);

                            EnderecoEmail[] enderecosEmail = listaSistema[indice].grupoEmail.destinatarios;

                            string[] destinatarios = new string[enderecosEmail.Length];

                            for (int i = 0; i < enderecosEmail.Length; i++)
                            {
                                destinatarios[i] = (enderecosEmail[i].enderecoEmail);
                            }

                            foreach (var destinatario in destinatarios)
                            {
                                message.To += destinatario;
                            }
                        }
                    }

                    break;

                case "Automatizador":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Automatizador")
                        {
                            indice = listaSistema.IndexOf(sistema);

                            EnderecoEmail[] enderecosEmail = listaSistema[indice].grupoEmail.destinatarios;

                            string[] destinatarios = new string[enderecosEmail.Length];

                            for (int i = 0; i < enderecosEmail.Length; i++)
                            {
                                destinatarios[i] = (enderecosEmail[i].enderecoEmail);
                            }

                            foreach (var destinatario in destinatarios)
                            {
                                message.To += destinatario;
                            }
                        }
                    }

                    break;

                case "Barcas":
                    foreach (var sistema in listaSistema)
                    {
                        if (sistema.Nome == "Barcas")
                        {
                            indice = listaSistema.IndexOf(sistema);

                            EnderecoEmail[] enderecosEmail = listaSistema[indice].grupoEmail.destinatarios;

                            string[] destinatarios = new string[enderecosEmail.Length];

                            for (int i = 0; i < enderecosEmail.Length; i++)
                            {
                                destinatarios[i] = (enderecosEmail[i].enderecoEmail);
                            }

                            foreach (var destinatario in destinatarios)
                            {
                                message.To += destinatario;
                            }
                        }
                    }

                    break;

                default:
                    break;
            }


            message.CC = "";
            message.Subject = "Liberador SUAT";
            message.HTMLBody = carregarHTML();
            message.Importance = Outlook.OlImportance.olImportanceHigh;
            message.Display(false);
        }

        public Outlook.Application GetApplicationObject()
        {

            Outlook.Application application = null;

            if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
            {
                application = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                montaEmail(application);
            }
            else
            {
                application = new Outlook.Application();
                montaEmail(application);
                Outlook.NameSpace nameSpace = application.GetNamespace("MAPI");
                nameSpace.Logon("", "", Missing.Value, Missing.Value);
                nameSpace = null;
            }

            return application;
        }
    }
}