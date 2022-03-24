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
        private TelaLiberador telaLiberador;
        private ModalAnexos modalAnexo;
        private SideBarLayout sideBar;
        public ModalEmail(SideBarLayout side, TelaLiberador tela, ModalAnexos modal)
        {
            InitializeComponent();
            telaLiberador = tela;
            modalAnexo = modal;
            sideBar = side;
        }
        public ModalEmail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email(telaLiberador, modalAnexo);
            email.GetApplicationObject();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalEmail_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
