using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LiberadorSUAT.Screens
{
    public partial class SideBarLayout : Form
    {
        public TelaLiberador telaLiberador { get; set; }
        public ModalAnexos modalAnexos { get; set; }
        public ModalEmail modalEmail { get; set; }

        public SideBarLayout()
        {
            InitializeComponent();
            openChildForm(new TelaLiberador(this));

        }

        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnexos_Click_1(object sender, EventArgs e)
         {
            ModalAnexos modalAnexo = new ModalAnexos(this);
            modalAnexo.telaLiberador = this.telaLiberador;
            openChildForm(modalAnexo);
           
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
        }

        private void btnInfos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TelaLiberador(this));
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
