using LiberadorSUAT.Screens.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new TelaLiberador());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new ModalAnexos());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ModalEmail());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSideBarMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
