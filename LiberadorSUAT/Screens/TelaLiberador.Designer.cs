
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
            this.regras = new LiberadorSUAT.Screens.RegrasLiberacao();
            this.btnLiberarVersao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listTipoLiberacao = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listSigla = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbVersao = new System.Windows.Forms.TextBox();
            this.txbRelease = new System.Windows.Forms.TextBox();
            this.txbHoras = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewScripts = new System.Windows.Forms.ListView();
            this.btnAdicionarScript = new System.Windows.Forms.Button();
            this.btnExcluirScript = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewAlteracoes = new System.Windows.Forms.ListView();
            this.btnNovoAlteracao = new System.Windows.Forms.Button();
            this.btnAlterarAlteracao = new System.Windows.Forms.Button();
            this.btnExcluirAlteracao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewDocumentacoes = new System.Windows.Forms.ListView();
            this.btnAdcionarDocumentacao = new System.Windows.Forms.Button();
            this.btnExcluirDocumentacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regras
            // 
            this.regras.ClientSize = new System.Drawing.Size(464, 251);
            this.regras.Location = new System.Drawing.Point(156, 156);
            this.regras.Name = "regras";
            this.regras.Text = "RegrasLiberacao";
            this.regras.Visible = false;
            this.regras.Load += new System.EventHandler(this.regras_Load_1);
            // 
            // btnLiberarVersao
            // 
            this.btnLiberarVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLiberarVersao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarVersao.Location = new System.Drawing.Point(609, 467);
            this.btnLiberarVersao.Name = "btnLiberarVersao";
            this.btnLiberarVersao.Size = new System.Drawing.Size(147, 26);
            this.btnLiberarVersao.TabIndex = 1;
            this.btnLiberarVersao.Text = "Liberar Versão";
            this.btnLiberarVersao.UseVisualStyleBackColor = false;
            this.btnLiberarVersao.Click += new System.EventHandler(this.btn_Liberar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(769, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título da Liberação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 34);
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
            this.listTipoLiberacao.Location = new System.Drawing.Point(524, 54);
            this.listTipoLiberacao.Name = "listTipoLiberacao";
            this.listTipoLiberacao.Size = new System.Drawing.Size(130, 20);
            this.listTipoLiberacao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sigla";
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
            this.listSigla.Location = new System.Drawing.Point(735, 54);
            this.listSigla.Name = "listSigla";
            this.listSigla.Size = new System.Drawing.Size(130, 20);
            this.listSigla.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Versão";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Horas Franquia";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txbVersao
            // 
            this.txbVersao.Location = new System.Drawing.Point(15, 119);
            this.txbVersao.Name = "txbVersao";
            this.txbVersao.Size = new System.Drawing.Size(110, 20);
            this.txbVersao.TabIndex = 12;
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(182, 119);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.Size = new System.Drawing.Size(113, 20);
            this.txbRelease.TabIndex = 13;
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(342, 119);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(117, 20);
            this.txbHoras.TabIndex = 14;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnviarEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(21, 467);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(147, 26);
            this.btnEnviarEmail.TabIndex = 15;
            this.btnEnviarEmail.Text = "Enviar E-mail";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Scripts de Banco de Dados";
            // 
            // listViewScripts
            // 
            this.listViewScripts.HideSelection = false;
            this.listViewScripts.Location = new System.Drawing.Point(15, 204);
            this.listViewScripts.Name = "listViewScripts";
            this.listViewScripts.Size = new System.Drawing.Size(263, 90);
            this.listViewScripts.TabIndex = 17;
            this.listViewScripts.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionarScript
            // 
            this.btnAdicionarScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionarScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarScript.Location = new System.Drawing.Point(284, 204);
            this.btnAdicionarScript.Name = "btnAdicionarScript";
            this.btnAdicionarScript.Size = new System.Drawing.Size(96, 26);
            this.btnAdicionarScript.TabIndex = 18;
            this.btnAdicionarScript.Text = "Adicionar";
            this.btnAdicionarScript.UseVisualStyleBackColor = false;
            this.btnAdicionarScript.Click += new System.EventHandler(this.btnAdicionarScript_Click);
            // 
            // btnExcluirScript
            // 
            this.btnExcluirScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirScript.Location = new System.Drawing.Point(284, 236);
            this.btnExcluirScript.Name = "btnExcluirScript";
            this.btnExcluirScript.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirScript.TabIndex = 20;
            this.btnExcluirScript.Text = "Excluir";
            this.btnExcluirScript.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alterações Realizadas no Projeto";
            // 
            // listViewAlteracoes
            // 
            this.listViewAlteracoes.HideSelection = false;
            this.listViewAlteracoes.Location = new System.Drawing.Point(519, 204);
            this.listViewAlteracoes.Name = "listViewAlteracoes";
            this.listViewAlteracoes.Size = new System.Drawing.Size(263, 90);
            this.listViewAlteracoes.TabIndex = 22;
            this.listViewAlteracoes.UseCompatibleStateImageBehavior = false;
            this.listViewAlteracoes.SelectedIndexChanged += new System.EventHandler(this.listViewAlteracoes_SelectedIndexChanged);
            // 
            // btnNovoAlteracao
            // 
            this.btnNovoAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAlteracao.Location = new System.Drawing.Point(788, 204);
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
            this.btnAlterarAlteracao.Location = new System.Drawing.Point(788, 236);
            this.btnAlterarAlteracao.Name = "btnAlterarAlteracao";
            this.btnAlterarAlteracao.Size = new System.Drawing.Size(96, 26);
            this.btnAlterarAlteracao.TabIndex = 24;
            this.btnAlterarAlteracao.Text = "Alterar";
            this.btnAlterarAlteracao.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAlteracao
            // 
            this.btnExcluirAlteracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirAlteracao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAlteracao.Location = new System.Drawing.Point(788, 268);
            this.btnExcluirAlteracao.Name = "btnExcluirAlteracao";
            this.btnExcluirAlteracao.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirAlteracao.TabIndex = 25;
            this.btnExcluirAlteracao.Text = "Excluir";
            this.btnExcluirAlteracao.UseVisualStyleBackColor = false;
            this.btnExcluirAlteracao.Click += new System.EventHandler(this.btnExcluirAlteracao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Documentações Extras";
            // 
            // listViewDocumentacoes
            // 
            this.listViewDocumentacoes.HideSelection = false;
            this.listViewDocumentacoes.Location = new System.Drawing.Point(15, 345);
            this.listViewDocumentacoes.Name = "listViewDocumentacoes";
            this.listViewDocumentacoes.Size = new System.Drawing.Size(263, 90);
            this.listViewDocumentacoes.TabIndex = 27;
            this.listViewDocumentacoes.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdcionarDocumentacao
            // 
            this.btnAdcionarDocumentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdcionarDocumentacao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionarDocumentacao.Location = new System.Drawing.Point(284, 345);
            this.btnAdcionarDocumentacao.Name = "btnAdcionarDocumentacao";
            this.btnAdcionarDocumentacao.Size = new System.Drawing.Size(96, 26);
            this.btnAdcionarDocumentacao.TabIndex = 28;
            this.btnAdcionarDocumentacao.Text = "Adicionar";
            this.btnAdcionarDocumentacao.UseVisualStyleBackColor = false;
            // 
            // btnExcluirDocumentacao
            // 
            this.btnExcluirDocumentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirDocumentacao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDocumentacao.Location = new System.Drawing.Point(284, 377);
            this.btnExcluirDocumentacao.Name = "btnExcluirDocumentacao";
            this.btnExcluirDocumentacao.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirDocumentacao.TabIndex = 30;
            this.btnExcluirDocumentacao.Text = "Excluir";
            this.btnExcluirDocumentacao.UseVisualStyleBackColor = false;
            // 
            // TelaLiberador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 509);
            this.Controls.Add(this.btnExcluirDocumentacao);
            this.Controls.Add(this.btnAdcionarDocumentacao);
            this.Controls.Add(this.listViewDocumentacoes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExcluirAlteracao);
            this.Controls.Add(this.btnAlterarAlteracao);
            this.Controls.Add(this.btnNovoAlteracao);
            this.Controls.Add(this.listViewAlteracoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExcluirScript);
            this.Controls.Add(this.btnAdicionarScript);
            this.Controls.Add(this.listViewScripts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txbHoras);
            this.Controls.Add(this.txbRelease);
            this.Controls.Add(this.txbVersao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listSigla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTipoLiberacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLiberarVersao);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TelaLiberador";
            this.Text = "Liberador de versão - SUAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLiberarVersao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listTipoLiberacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listSigla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbVersao;
        private System.Windows.Forms.TextBox txbRelease;
        private System.Windows.Forms.TextBox txbHoras;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewScripts;
        private System.Windows.Forms.Button btnAdicionarScript;
        private System.Windows.Forms.Button btnExcluirScript;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovoAlteracao;
        private System.Windows.Forms.Button btnAlterarAlteracao;
        private System.Windows.Forms.Button btnExcluirAlteracao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewDocumentacoes;
        private System.Windows.Forms.Button btnAdcionarDocumentacao;
        private System.Windows.Forms.Button btnExcluirDocumentacao;
        private RegrasLiberacao regras;
        public System.Windows.Forms.ListView listViewAlteracoes;
    }
}

