
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBoxTipos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título da Liberação";
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(46, 74);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(458, 20);
            this.txbTitulo.TabIndex = 4;
            this.txbTitulo.TextChanged += new System.EventHandler(this.txbTitulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo da Liberação";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sigla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Versão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release";
            // 
            // txbVersao
            // 
            this.txbVersao.Location = new System.Drawing.Point(46, 156);
            this.txbVersao.Name = "txbVersao";
            this.txbVersao.Size = new System.Drawing.Size(142, 20);
            this.txbVersao.TabIndex = 12;
            this.txbVersao.TextChanged += new System.EventHandler(this.txbVersao_TextChanged);
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(242, 156);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.Size = new System.Drawing.Size(113, 20);
            this.txbRelease.TabIndex = 13;
            this.txbRelease.TextChanged += new System.EventHandler(this.txbRelease_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alterações Realizadas no Projeto";
            // 
            // listViewAlteracoes
            // 
            this.listViewAlteracoes.HideSelection = false;
            this.listViewAlteracoes.Location = new System.Drawing.Point(46, 246);
            this.listViewAlteracoes.Name = "listViewAlteracoes";
            this.listViewAlteracoes.Size = new System.Drawing.Size(747, 138);
            this.listViewAlteracoes.TabIndex = 22;
            this.listViewAlteracoes.UseCompatibleStateImageBehavior = false;
            this.listViewAlteracoes.View = System.Windows.Forms.View.Details;
            // 
            // btnNovoAlteracao
            // 
            this.btnNovoAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovoAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAlteracao.Location = new System.Drawing.Point(819, 246);
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
            this.btnAlterarAlteracao.Location = new System.Drawing.Point(819, 278);
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
            this.btnExcluirAlteracao.Location = new System.Drawing.Point(819, 310);
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
            this.btnRegras.Location = new System.Drawing.Point(784, 54);
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
            this.label7.Location = new System.Drawing.Point(591, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Sistema";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // listBoxSistemas
            // 
            this.listBoxSistemas.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSistemas.CheckOnClick = true;
            this.listBoxSistemas.FormattingEnabled = true;
            this.listBoxSistemas.Items.AddRange(new object[] {
            "Evasores",
            "SUATMobilidade",
            "VLTRio",
            "Automatizador",
            "Barcas"});
            this.listBoxSistemas.Location = new System.Drawing.Point(594, 100);
            this.listBoxSistemas.Name = "listBoxSistemas";
            this.listBoxSistemas.Size = new System.Drawing.Size(131, 79);
            this.listBoxSistemas.TabIndex = 41;
            this.listBoxSistemas.SelectedIndexChanged += new System.EventHandler(this.listBoxSistemas_SelectedIndexChanged);
            // 
            // txbSigla
            // 
            this.txbSigla.Location = new System.Drawing.Point(784, 156);
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
            this.btnAjudaAlteracoes.Location = new System.Drawing.Point(304, 217);
            this.btnAjudaAlteracoes.Name = "btnAjudaAlteracoes";
            this.btnAjudaAlteracoes.Size = new System.Drawing.Size(27, 26);
            this.btnAjudaAlteracoes.TabIndex = 43;
            this.btnAjudaAlteracoes.UseVisualStyleBackColor = false;
            // 
            // btnModalAnexos
            // 
            this.btnModalAnexos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModalAnexos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModalAnexos.Location = new System.Drawing.Point(746, 441);
            this.btnModalAnexos.Name = "btnModalAnexos";
            this.btnModalAnexos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModalAnexos.Size = new System.Drawing.Size(169, 43);
            this.btnModalAnexos.TabIndex = 44;
            this.btnModalAnexos.Text = "Adicionar anexos";
            this.btnModalAnexos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModalAnexos.UseVisualStyleBackColor = true;
            this.btnModalAnexos.Click += new System.EventHandler(this.btnModalAnexos_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBoxTipos
            // 
            this.listBoxTipos.CheckOnClick = true;
            this.listBoxTipos.FormattingEnabled = true;
            this.listBoxTipos.Items.AddRange(new object[] {
            "Melhoria",
            "Sustentação",
            "Apoio"});
            this.listBoxTipos.Location = new System.Drawing.Point(406, 130);
            this.listBoxTipos.Name = "listBoxTipos";
            this.listBoxTipos.Size = new System.Drawing.Size(141, 49);
            this.listBoxTipos.TabIndex = 45;
            this.listBoxTipos.SelectedIndexChanged += new System.EventHandler(this.listBoxTipos_SelectedIndexChanged);
            // 
            // TelaLiberador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 525);
            this.Controls.Add(this.listBoxTipos);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLiberador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberador de versão - SUAT";
            this.Load += new System.EventHandler(this.TelaLiberador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovoAlteracao;
        private System.Windows.Forms.Button btnAlterarAlteracao;
        private System.Windows.Forms.Button btnExcluirAlteracao;
        public System.Windows.Forms.ListView listViewAlteracoes;
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTipTelaLiberador;
        private System.Windows.Forms.Button btnAjudaAlteracoes;
        private System.Windows.Forms.Button btnModalAnexos;
        public System.Windows.Forms.TextBox txbTitulo;
        public System.Windows.Forms.TextBox txbVersao;
        public System.Windows.Forms.TextBox txbRelease;
        public System.Windows.Forms.CheckedListBox listBoxSistemas;
        public System.Windows.Forms.TextBox txbSigla;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.CheckedListBox listBoxTipos;
    }
}
