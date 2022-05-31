

namespace LiberadorSUAT.Screens
{
    partial class SideBarLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBarLayout));
            this.panelSideBarMenu = new System.Windows.Forms.Panel();
            this.btnEmail = new FontAwesome.Sharp.IconButton();
            this.btnAnexos = new FontAwesome.Sharp.IconButton();
            this.btnInfos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideBarMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBarMenu
            // 
            this.panelSideBarMenu.AutoScroll = true;
            this.panelSideBarMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelSideBarMenu.Controls.Add(this.btnEmail);
            this.panelSideBarMenu.Controls.Add(this.btnAnexos);
            this.panelSideBarMenu.Controls.Add(this.btnInfos);
            this.panelSideBarMenu.Controls.Add(this.panel1);
            this.panelSideBarMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelSideBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBarMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideBarMenu.Name = "panelSideBarMenu";
            this.panelSideBarMenu.Size = new System.Drawing.Size(213, 561);
            this.panelSideBarMenu.TabIndex = 48;
            // 
            // btnEmail
            // 
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.btnEmail.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.btnEmail.IconColor = System.Drawing.Color.White;
            this.btnEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmail.IconSize = 30;
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.Location = new System.Drawing.Point(0, 166);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmail.Size = new System.Drawing.Size(213, 42);
            this.btnEmail.TabIndex = 52;
            this.btnEmail.Text = "Envio";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click_1);
            // 
            // btnAnexos
            // 
            this.btnAnexos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnexos.FlatAppearance.BorderSize = 0;
            this.btnAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexos.ForeColor = System.Drawing.Color.White;
            this.btnAnexos.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnAnexos.IconColor = System.Drawing.Color.White;
            this.btnAnexos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnexos.IconSize = 30;
            this.btnAnexos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnexos.Location = new System.Drawing.Point(0, 124);
            this.btnAnexos.Name = "btnAnexos";
            this.btnAnexos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAnexos.Size = new System.Drawing.Size(213, 42);
            this.btnAnexos.TabIndex = 51;
            this.btnAnexos.Text = "Anexos";
            this.btnAnexos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnexos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnexos.UseVisualStyleBackColor = true;
            this.btnAnexos.Click += new System.EventHandler(this.btnAnexos_Click_1);
            // 
            // btnInfos
            // 
            this.btnInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfos.FlatAppearance.BorderSize = 0;
            this.btnInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfos.ForeColor = System.Drawing.Color.White;
            this.btnInfos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnInfos.IconColor = System.Drawing.Color.White;
            this.btnInfos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfos.IconSize = 30;
            this.btnInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfos.Location = new System.Drawing.Point(0, 82);
            this.btnInfos.Name = "btnInfos";
            this.btnInfos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfos.Size = new System.Drawing.Size(213, 42);
            this.btnInfos.TabIndex = 50;
            this.btnInfos.Text = "Informações iniciais";
            this.btnInfos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfos.UseVisualStyleBackColor = true;
            this.btnInfos.Click += new System.EventHandler(this.btnInfos_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 42);
            this.panel1.TabIndex = 49;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(213, 42);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.43388F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 82);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(213, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 18);
            this.panel2.TabIndex = 49;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(213, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(964, 543);
            this.panelChildForm.TabIndex = 50;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // SideBarLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1177, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSideBarMenu);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "SideBarLayout";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberador de versão - SUAT";
            this.panelSideBarMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBarMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnExit;
        public FontAwesome.Sharp.IconButton btnEmail;
        public FontAwesome.Sharp.IconButton btnAnexos;
        public FontAwesome.Sharp.IconButton btnInfos;
    }
}