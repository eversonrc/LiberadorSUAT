
using LiberadorSUAT.Screens;

namespace LiberadorSUAT
{
    partial class TelaLiberador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLiberador));
            this.label2 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listTipoLiberacao = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbVersao = new System.Windows.Forms.TextBox();
            this.txbRelease = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewAlteracoes = new System.Windows.Forms.ListView();
            this.btnNovoAlteracao = new System.Windows.Forms.Button();
            this.btnAlterarAlteracao = new System.Windows.Forms.Button();
            this.btnExcluirAlteracao = new System.Windows.Forms.Button();
            this.btnRegras = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxSistemas = new System.Windows.Forms.CheckedListBox();
            this.txbSigla = new System.Windows.Forms.TextBox();
            this.toolTipTelaLiberador = new System.Windows.Forms.ToolTip(this.components);
            this.btnAjudaAlteracoes = new System.Windows.Forms.Button();
            this.btnModalAnexos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLiberacao = new System.Windows.Forms.Button();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnEnvioEmail = new System.Windows.Forms.Button();
            this.btnLiberacaoVersao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título da Liberação";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(21, 138);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(458, 20);
            this.txbTitulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo da Liberação";
            // 
            // listTipoLiberacao
            // 
            this.listTipoLiberacao.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTipoLiberacao.FormattingEnabled = true;
            this.listTipoLiberacao.ItemHeight = 16;
            this.listTipoLiberacao.Items.AddRange(new object[] {
            "Melhoria",
            "Sustentação",
            "Apoio"});
            this.listTipoLiberacao.Location = new System.Drawing.Point(377, 220);
            this.listTipoLiberacao.Name = "listTipoLiberacao";
            this.listTipoLiberacao.Size = new System.Drawing.Size(141, 20);
            this.listTipoLiberacao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(756, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Versão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release";
            // 
            // txbVersao
            // 
            this.txbVersao.Location = new System.Drawing.Point(21, 220);
            this.txbVersao.Name = "txbVersao";
            this.txbVersao.Size = new System.Drawing.Size(142, 20);
            this.txbVersao.TabIndex = 12;
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(217, 220);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.Size = new System.Drawing.Size(113, 20);
            this.txbRelease.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alterações Realizadas no Projeto";
            // 
            // listViewAlteracoes
            // 
            this.listViewAlteracoes.HideSelection = false;
            this.listViewAlteracoes.Location = new System.Drawing.Point(21, 310);
            this.listViewAlteracoes.Name = "listViewAlteracoes";
            this.listViewAlteracoes.Size = new System.Drawing.Size(818, 90);
            this.listViewAlteracoes.TabIndex = 22;
            this.listViewAlteracoes.UseCompatibleStateImageBehavior = false;
            this.listViewAlteracoes.View = System.Windows.Forms.View.Details;
            // 
            // btnNovoAlteracao
            // 
            this.btnNovoAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovoAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAlteracao.Location = new System.Drawing.Point(845, 310);
            this.btnNovoAlteracao.Name = "btnNovoAlteracao";
            this.btnNovoAlteracao.Size = new System.Drawing.Size(96, 26);
            this.btnNovoAlteracao.TabIndex = 23;
            this.btnNovoAlteracao.Text = "Novo";
            this.btnNovoAlteracao.UseVisualStyleBackColor = false;
            this.btnNovoAlteracao.Click += new System.EventHandler(this.btnNovoAlteracao_Click);
            // 
            // btnAlterarAlteracao
            // 
            this.btnAlterarAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAlteracao.Location = new System.Drawing.Point(843, 342);
            this.btnAlterarAlteracao.Name = "btnAlterarAlteracao";
            this.btnAlterarAlteracao.Size = new System.Drawing.Size(96, 26);
            this.btnAlterarAlteracao.TabIndex = 24;
            this.btnAlterarAlteracao.Text = "Alterar";
            this.btnAlterarAlteracao.UseVisualStyleBackColor = true;
            this.btnAlterarAlteracao.Click += new System.EventHandler(this.btnAlterarAlteracao_Click);
            // 
            // btnExcluirAlteracao
            // 
            this.btnExcluirAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluirAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAlteracao.Location = new System.Drawing.Point(843, 374);
            this.btnExcluirAlteracao.Name = "btnExcluirAlteracao";
            this.btnExcluirAlteracao.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirAlteracao.TabIndex = 25;
            this.btnExcluirAlteracao.Text = "Excluir";
            this.btnExcluirAlteracao.UseVisualStyleBackColor = false;
            this.btnExcluirAlteracao.Click += new System.EventHandler(this.btnExcluirAlteracao_Click);
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.Transparent;
            this.btnRegras.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegras.ForeColor = System.Drawing.Color.Black;
            this.btnRegras.Location = new System.Drawing.Point(759, 118);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(131, 40);
            this.btnRegras.TabIndex = 38;
            this.btnRegras.Text = "Regras de Liberação";
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Sistema";
            // 
            // listBoxSistemas
            // 
            this.listBoxSistemas.FormattingEnabled = true;
            this.listBoxSistemas.Items.AddRange(new object[] {
            "Evasores",
            "SUATMobilidade",
            "VLTRio",
            "Automatizador",
            "Barcas"});
            this.listBoxSistemas.Location = new System.Drawing.Point(569, 161);
            this.listBoxSistemas.Name = "listBoxSistemas";
            this.listBoxSistemas.Size = new System.Drawing.Size(131, 79);
            this.listBoxSistemas.TabIndex = 41;
            this.listBoxSistemas.SelectedIndexChanged += new System.EventHandler(this.listBoxSistemas_SelectedIndexChanged);
            // 
            // txbSigla
            // 
            this.txbSigla.Location = new System.Drawing.Point(759, 220);
            this.txbSigla.Name = "txbSigla";
            this.txbSigla.Size = new System.Drawing.Size(131, 20);
            this.txbSigla.TabIndex = 42;
            // 
            // btnAjudaAlteracoes
            // 
            this.btnAjudaAlteracoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAjudaAlteracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAjudaAlteracoes.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAjudaAlteracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAjudaAlteracoes.Image")));
            this.btnAjudaAlteracoes.Location = new System.Drawing.Point(279, 281);
            this.btnAjudaAlteracoes.Name = "btnAjudaAlteracoes";
            this.btnAjudaAlteracoes.Size = new System.Drawing.Size(24, 26);
            this.btnAjudaAlteracoes.TabIndex = 43;
            this.btnAjudaAlteracoes.UseVisualStyleBackColor = false;
            this.btnAjudaAlteracoes.Click += new System.EventHandler(this.btnAjudaAlteracoes_Click);
            // 
            // btnModalAnexos
            // 
            this.btnModalAnexos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModalAnexos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModalAnexos.Location = new System.Drawing.Point(815, 427);
            this.btnModalAnexos.Name = "btnModalAnexos";
            this.btnModalAnexos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModalAnexos.Size = new System.Drawing.Size(124, 43);
            this.btnModalAnexos.TabIndex = 44;
            this.btnModalAnexos.Text = "Adicionar anexos";
            this.btnModalAnexos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModalAnexos.UseVisualStyleBackColor = true;
            this.btnModalAnexos.Click += new System.EventHandler(this.btnModalAnexos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLiberacaoVersao);
            this.groupBox1.Controls.Add(this.btnEnvioEmail);
            this.groupBox1.Controls.Add(this.btnAnexo);
            this.groupBox1.Controls.Add(this.btnLiberacao);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 66);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnLiberacao
            // 
            this.btnLiberacao.BackColor = System.Drawing.Color.Transparent;
            this.btnLiberacao.Location = new System.Drawing.Point(40, 19);
            this.btnLiberacao.Name = "btnLiberacao";
            this.btnLiberacao.Size = new System.Drawing.Size(88, 28);
            this.btnLiberacao.TabIndex = 0;
            this.btnLiberacao.Text = "Liberação";
            this.btnLiberacao.UseVisualStyleBackColor = false;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(220, 19);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(139, 28);
            this.btnAnexo.TabIndex = 1;
            this.btnAnexo.Text = "Anexo de Arquivos";
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // btnEnvioEmail
            // 
            this.btnEnvioEmail.Location = new System.Drawing.Point(449, 19);
            this.btnEnvioEmail.Name = "btnEnvioEmail";
            this.btnEnvioEmail.Size = new System.Drawing.Size(139, 28);
            this.btnEnvioEmail.TabIndex = 2;
            this.btnEnvioEmail.Text = "Envio de E-mail";
            this.btnEnvioEmail.UseVisualStyleBackColor = true;
            // 
            // btnLiberacaoVersao
            // 
            this.btnLiberacaoVersao.Location = new System.Drawing.Point(676, 19);
            this.btnLiberacaoVersao.Name = "btnLiberacaoVersao";
            this.btnLiberacaoVersao.Size = new System.Drawing.Size(161, 28);
            this.btnLiberacaoVersao.TabIndex = 3;
            this.btnLiberacaoVersao.Text = "Liberação de Versão";
            this.btnLiberacaoVersao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(147, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(380, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(605, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 48;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TelaLiberador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModalAnexos);
            this.Controls.Add(this.btnAjudaAlteracoes);
            this.Controls.Add(this.txbSigla);
            this.Controls.Add(this.listBoxSistemas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegras);
            this.Controls.Add(this.btnExcluirAlteracao);
            this.Controls.Add(this.btnAlterarAlteracao);
            this.Controls.Add(this.btnNovoAlteracao);
            this.Controls.Add(this.listViewAlteracoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbRelease);
            this.Controls.Add(this.txbVersao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTipoLiberacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TelaLiberador";
            this.Text = "Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listTipoLiberacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbVersao;
        private System.Windows.Forms.TextBox txbRelease;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovoAlteracao;
        private System.Windows.Forms.Button btnAlterarAlteracao;
        private System.Windows.Forms.Button btnExcluirAlteracao;
        public System.Windows.Forms.ListView listViewAlteracoes;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox listBoxSistemas;
        private System.Windows.Forms.TextBox txbSigla;
        private System.Windows.Forms.ToolTip toolTipTelaLiberador;
        private System.Windows.Forms.Button btnAjudaAlteracoes;
        private System.Windows.Forms.Button btnModalAnexos;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnLiberacaoVersao;
        public System.Windows.Forms.Button btnEnvioEmail;
        public System.Windows.Forms.Button btnAnexo;
        public System.Windows.Forms.Button btnLiberacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

