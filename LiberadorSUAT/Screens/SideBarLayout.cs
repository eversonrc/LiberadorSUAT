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

        public SideBarLayout()
        {
            InitializeComponent();
            openChildForm(new TelaLiberador());
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void btnInfos_Click(object sender, EventArgs e)
        {
            openChildForm(new TelaLiberador());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnexos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ModalAnexos());
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ModalEmail());
        }

        private void btnInfos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new TelaLiberador());
        }
    }
}
