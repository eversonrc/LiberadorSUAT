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
        public ModalEmail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.GetApplicationObject();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
