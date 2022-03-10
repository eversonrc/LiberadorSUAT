
namespace LiberadorSUAT
{
    partial class TelaLiberadorSUAT
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLiberarVersao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Regras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTipo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listSigla = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVersao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbRelease = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGerarEmail = new System.Windows.Forms.Button();
            this.listViewScripts = new System.Windows.Forms.ListView();
            this.btnNovoScript = new System.Windows.Forms.Button();
            this.btnAlterarScript = new System.Windows.Forms.Button();
            this.btnExcluirScript = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewAlteracoes = new System.Windows.Forms.ListView();
            this.btnNovoAlteracoes = new System.Windows.Forms.Button();
            this.btnAlterarAlteracoes = new System.Windows.Forms.Button();
            this.btnExcluirAlteracoes = new System.Windows.Forms.Button();
            this.listViewDocumentacoes = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNovoDocumentacoes = new System.Windows.Forms.Button();
            this.btnAlterarDocumentacoes = new System.Windows.Forms.Button();
            this.btnExcluirDocumentacoes = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.Regras);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 92);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnLiberarVersao
            // 
            this.btnLiberarVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLiberarVersao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarVersao.Location = new System.Drawing.Point(742, 524);
            this.btnLiberarVersao.Name = "btnLiberarVersao";
            this.btnLiberarVersao.Size = new System.Drawing.Size(166, 28);
            this.btnLiberarVersao.TabIndex = 1;
            this.btnLiberarVersao.Text = "Enviar Liberação";
            this.btnLiberarVersao.UseVisualStyleBackColor = false;
            this.btnLiberarVersao.Click += new System.EventHandler(this.btn_Liberar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(626, 524);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Regras
            // 
            this.Regras.AutoSize = true;
            this.Regras.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regras.ForeColor = System.Drawing.Color.LightCoral;
            this.Regras.Location = new System.Drawing.Point(3, 0);
            this.Regras.Name = "Regras";
            this.Regras.Size = new System.Drawing.Size(186, 15);
            this.Regras.TabIndex = 0;
            this.Regras.Text = "Regras de Liberação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Título da Liberação";
            // 
            // txbTitulo
            // 
            this.txbTitulo.ForeColor = System.Drawing.Color.Black;
            this.txbTitulo.Location = new System.Drawing.Point(15, 151);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(484, 20);
            this.txbTitulo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo da Liberação";
            // 
            // listTipo
            // 
            this.listTipo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTipo.FormattingEnabled = true;
            this.listTipo.ItemHeight = 16;
            this.listTipo.Items.AddRange(new object[] {
            "Melhoria",
            "Sustentação",
            "Apoio"});
            this.listTipo.Location = new System.Drawing.Point(561, 151);
            this.listTipo.Name = "listTipo";
            this.listTipo.Size = new System.Drawing.Size(141, 20);
            this.listTipo.TabIndex = 6;
            this.listTipo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sigla";
            // 
            // listSigla
            // 
            this.listSigla.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSigla.FormattingEnabled = true;
            this.listSigla.ItemHeight = 16;
            this.listSigla.Items.AddRange(new object[] {
            "X",
            "Y",
            "W",
            "Z"});
            this.listSigla.Location = new System.Drawing.Point(762, 151);
            this.listSigla.Name = "listSigla";
            this.listSigla.Size = new System.Drawing.Size(123, 20);
            this.listSigla.TabIndex = 8;
            this.listSigla.SelectedIndexChanged += new System.EventHandler(this.listSigla_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Versão";
            // 
            // txbVersao
            // 
            this.txbVersao.Location = new System.Drawing.Point(12, 205);
            this.txbVersao.Name = "txbVersao";
            this.txbVersao.Size = new System.Drawing.Size(124, 20);
            this.txbVersao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Release";
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(180, 205);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.Size = new System.Drawing.Size(124, 20);
            this.txbRelease.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Horas Franquia";
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(362, 205);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(124, 20);
            this.txbHoras.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Scripts de Banco de Dados";
            // 
            // btnGerarEmail
            // 
            this.btnGerarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerarEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEmail.Location = new System.Drawing.Point(12, 524);
            this.btnGerarEmail.Name = "btnGerarEmail";
            this.btnGerarEmail.Size = new System.Drawing.Size(131, 28);
            this.btnGerarEmail.TabIndex = 16;
            this.btnGerarEmail.Text = "Gerar E-mail";
            this.btnGerarEmail.UseVisualStyleBackColor = false;
            // 
            // listViewScripts
            // 
            this.listViewScripts.HideSelection = false;
            this.listViewScripts.Location = new System.Drawing.Point(12, 274);
            this.listViewScripts.Name = "listViewScripts";
            this.listViewScripts.Size = new System.Drawing.Size(292, 96);
            this.listViewScripts.TabIndex = 17;
            this.listViewScripts.UseCompatibleStateImageBehavior = false;
            // 
            // btnNovoScript
            // 
            this.btnNovoScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoScript.Location = new System.Drawing.Point(310, 274);
            this.btnNovoScript.Name = "btnNovoScript";
            this.btnNovoScript.Size = new System.Drawing.Size(91, 28);
            this.btnNovoScript.TabIndex = 18;
            this.btnNovoScript.Text = "Novo";
            this.btnNovoScript.UseVisualStyleBackColor = false;
            // 
            // btnAlterarScript
            // 
            this.btnAlterarScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarScript.Location = new System.Drawing.Point(310, 308);
            this.btnAlterarScript.Name = "btnAlterarScript";
            this.btnAlterarScript.Size = new System.Drawing.Size(91, 28);
            this.btnAlterarScript.TabIndex = 19;
            this.btnAlterarScript.Text = "Alterar";
            this.btnAlterarScript.UseVisualStyleBackColor = true;
            // 
            // btnExcluirScript
            // 
            this.btnExcluirScript.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluirScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirScript.Location = new System.Drawing.Point(310, 342);
            this.btnExcluirScript.Name = "btnExcluirScript";
            this.btnExcluirScript.Size = new System.Drawing.Size(91, 28);
            this.btnExcluirScript.TabIndex = 20;
            this.btnExcluirScript.Text = "Excluir";
            this.btnExcluirScript.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alterações realizadas no projeto";
            // 
            // listViewAlteracoes
            // 
            this.listViewAlteracoes.HideSelection = false;
            this.listViewAlteracoes.Location = new System.Drawing.Point(496, 276);
            this.listViewAlteracoes.Name = "listViewAlteracoes";
            this.listViewAlteracoes.Size = new System.Drawing.Size(292, 96);
            this.listViewAlteracoes.TabIndex = 22;
            this.listViewAlteracoes.UseCompatibleStateImageBehavior = false;
            // 
            // btnNovoAlteracoes
            // 
            this.btnNovoAlteracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAlteracoes.Location = new System.Drawing.Point(794, 274);
            this.btnNovoAlteracoes.Name = "btnNovoAlteracoes";
            this.btnNovoAlteracoes.Size = new System.Drawing.Size(91, 28);
            this.btnNovoAlteracoes.TabIndex = 23;
            this.btnNovoAlteracoes.Text = "Novo";
            this.btnNovoAlteracoes.UseVisualStyleBackColor = false;
            // 
            // btnAlterarAlteracoes
            // 
            this.btnAlterarAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAlteracoes.Location = new System.Drawing.Point(794, 308);
            this.btnAlterarAlteracoes.Name = "btnAlterarAlteracoes";
            this.btnAlterarAlteracoes.Size = new System.Drawing.Size(91, 28);
            this.btnAlterarAlteracoes.TabIndex = 24;
            this.btnAlterarAlteracoes.Text = "Alterar";
            this.btnAlterarAlteracoes.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAlteracoes
            // 
            this.btnExcluirAlteracoes.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluirAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAlteracoes.Location = new System.Drawing.Point(794, 342);
            this.btnExcluirAlteracoes.Name = "btnExcluirAlteracoes";
            this.btnExcluirAlteracoes.Size = new System.Drawing.Size(91, 28);
            this.btnExcluirAlteracoes.TabIndex = 25;
            this.btnExcluirAlteracoes.Text = "Excluir";
            this.btnExcluirAlteracoes.UseVisualStyleBackColor = false;
            // 
            // listViewDocumentacoes
            // 
            this.listViewDocumentacoes.HideSelection = false;
            this.listViewDocumentacoes.Location = new System.Drawing.Point(12, 412);
            this.listViewDocumentacoes.Name = "listViewDocumentacoes";
            this.listViewDocumentacoes.Size = new System.Drawing.Size(292, 96);
            this.listViewDocumentacoes.TabIndex = 26;
            this.listViewDocumentacoes.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Documentações Extras";
            // 
            // btnNovoDocumentacoes
            // 
            this.btnNovoDocumentacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoDocumentacoes.Location = new System.Drawing.Point(310, 412);
            this.btnNovoDocumentacoes.Name = "btnNovoDocumentacoes";
            this.btnNovoDocumentacoes.Size = new System.Drawing.Size(91, 28);
            this.btnNovoDocumentacoes.TabIndex = 28;
            this.btnNovoDocumentacoes.Text = "Novo";
            this.btnNovoDocumentacoes.UseVisualStyleBackColor = false;
            // 
            // btnAlterarDocumentacoes
            // 
            this.btnAlterarDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDocumentacoes.Location = new System.Drawing.Point(310, 446);
            this.btnAlterarDocumentacoes.Name = "btnAlterarDocumentacoes";
            this.btnAlterarDocumentacoes.Size = new System.Drawing.Size(91, 28);
            this.btnAlterarDocumentacoes.TabIndex = 29;
            this.btnAlterarDocumentacoes.Text = "Alterar";
            this.btnAlterarDocumentacoes.UseVisualStyleBackColor = true;
            // 
            // btnExcluirDocumentacoes
            // 
            this.btnExcluirDocumentacoes.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluirDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDocumentacoes.Location = new System.Drawing.Point(310, 480);
            this.btnExcluirDocumentacoes.Name = "btnExcluirDocumentacoes";
            this.btnExcluirDocumentacoes.Size = new System.Drawing.Size(91, 28);
            this.btnExcluirDocumentacoes.TabIndex = 30;
            this.btnExcluirDocumentacoes.Text = "Excluir";
            this.btnExcluirDocumentacoes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 564);
            this.Controls.Add(this.btnExcluirDocumentacoes);
            this.Controls.Add(this.btnAlterarDocumentacoes);
            this.Controls.Add(this.btnNovoDocumentacoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewDocumentacoes);
            this.Controls.Add(this.btnExcluirAlteracoes);
            this.Controls.Add(this.btnAlterarAlteracoes);
            this.Controls.Add(this.btnNovoAlteracoes);
            this.Controls.Add(this.listViewAlteracoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExcluirScript);
            this.Controls.Add(this.btnAlterarScript);
            this.Controls.Add(this.btnNovoScript);
            this.Controls.Add(this.listViewScripts);
            this.Controls.Add(this.btnGerarEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbHoras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbRelease);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbVersao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSigla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLiberarVersao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Liberador de versão - SUAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLiberarVersao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label Regras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVersao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbRelease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGerarEmail;
        private System.Windows.Forms.ListView listViewScripts;
        private System.Windows.Forms.Button btnNovoScript;
        private System.Windows.Forms.Button btnAlterarScript;
        private System.Windows.Forms.Button btnExcluirScript;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewAlteracoes;
        private System.Windows.Forms.Button btnNovoAlteracoes;
        private System.Windows.Forms.Button btnAlterarAlteracoes;
        private System.Windows.Forms.Button btnExcluirAlteracoes;
        private System.Windows.Forms.ListView listViewDocumentacoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovoDocumentacoes;
        private System.Windows.Forms.Button btnAlterarDocumentacoes;
        private System.Windows.Forms.Button btnExcluirDocumentacoes;
    }
}

