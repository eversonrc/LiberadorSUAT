namespace LiberadorSUAT.Screens.Modals
{
    partial class ModalEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLiberacaoVersao = new System.Windows.Forms.Button();
            this.btnEnvioEmail = new System.Windows.Forms.Button();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnLiberacao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(608, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leia as regras de liberação abaixo antes de enviar o e-mail.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarEmail.Image")));
            this.btnEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarEmail.Location = new System.Drawing.Point(508, 310);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(168, 35);
            this.btnEnviarEmail.TabIndex = 2;
            this.btnEnviarEmail.Text = "Enviar E-mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(35, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 35);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLiberacaoVersao);
            this.groupBox1.Controls.Add(this.btnEnvioEmail);
            this.groupBox1.Controls.Add(this.btnAnexo);
            this.groupBox1.Controls.Add(this.btnLiberacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 66);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnLiberacaoVersao
            // 
            this.btnLiberacaoVersao.Location = new System.Drawing.Point(503, 19);
            this.btnLiberacaoVersao.Name = "btnLiberacaoVersao";
            this.btnLiberacaoVersao.Size = new System.Drawing.Size(161, 28);
            this.btnLiberacaoVersao.TabIndex = 3;
            this.btnLiberacaoVersao.Text = "Liberação de Versão";
            this.btnLiberacaoVersao.UseVisualStyleBackColor = true;
            // 
            // btnEnvioEmail
            // 
            this.btnEnvioEmail.Location = new System.Drawing.Point(329, 19);
            this.btnEnvioEmail.Name = "btnEnvioEmail";
            this.btnEnvioEmail.Size = new System.Drawing.Size(139, 28);
            this.btnEnvioEmail.TabIndex = 2;
            this.btnEnvioEmail.Text = "Envio de E-mail";
            this.btnEnvioEmail.UseVisualStyleBackColor = true;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(154, 19);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(139, 28);
            this.btnAnexo.TabIndex = 1;
            this.btnAnexo.Text = "Anexo de Arquivos";
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // btnLiberacao
            // 
            this.btnLiberacao.BackColor = System.Drawing.Color.Transparent;
            this.btnLiberacao.Location = new System.Drawing.Point(23, 19);
            this.btnLiberacao.Name = "btnLiberacao";
            this.btnLiberacao.Size = new System.Drawing.Size(88, 28);
            this.btnLiberacao.TabIndex = 0;
            this.btnLiberacao.Text = "Liberação";
            this.btnLiberacao.UseVisualStyleBackColor = false;
            // 
            // ModalEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModalEmail";
            this.Text = "ModalEmail";
            this.Load += new System.EventHandler(this.ModalEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnLiberacaoVersao;
        public System.Windows.Forms.Button btnEnvioEmail;
        public System.Windows.Forms.Button btnAnexo;
        public System.Windows.Forms.Button btnLiberacao;
    }
}