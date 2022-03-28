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

            /*if (validadorCampos() == true)
            {
                this.Hide();
                ModalAnexos modalAnexo = new ModalAnexos(this);
                modalAnexo.telaLiberador = new TelaLiberador();
                openChildForm(modalAnexo);
            }
            else
            {
                MessageBox.Show("Todos os campo devem ser preenchidos antes de avançar para a próxima etapa. Por favor verifique os dados novamente.");
            }*/
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            /*if (ModalEmail.isAcessivel)
            {
                openChildForm(new ModalEmail(side, tela, anexos));
            }
            else
            {
                MessageBox.Show("Preencha as informações iniciais e adicione os anexos para acessar a tela de E-mail pré-liberação");
            }*/
            
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
