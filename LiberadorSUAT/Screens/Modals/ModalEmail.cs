using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT.Screens.Modals
{
    public partial class ModalEmail : Form
    {
        public static bool isAcessivel { get; set; }
        public SideBarLayout sideBar { get; set; }
        public ModalAnexos modalAnexo { get; set; }
        public TelaLiberador telaLiberador { get; set; }

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
