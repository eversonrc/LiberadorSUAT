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
        private ModalAnexos modalAnexo;
        public ModalEmail(ModalAnexos modal)
        {
            InitializeComponent();
            modalAnexo = modal;
            btnLiberacao.BackColor = Color.Cyan;
            btnAnexo.BackColor = Color.Cyan;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            btnEnvioEmail.BackColor = Color.Cyan;

            Email email = new Email();
            email.GetApplicationObject();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            modalAnexo.btnAnexo.BackColor = Color.Transparent;
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
