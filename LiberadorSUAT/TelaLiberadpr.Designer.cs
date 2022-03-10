
namespace LiberadorSUAT
{
    partial class TelaLiberadpr
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
            this.btnLiberarVersao = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnNovoScripts = new System.Windows.Forms.Button();
            this.btnAlterarScripts = new System.Windows.Forms.Button();
            this.btnExcluirScripts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewAlteracoes = new System.Windows.Forms.ListView();
            this.btnNovoAlteracoes = new System.Windows.Forms.Button();
            this.btnAlterarAlteracoes = new System.Windows.Forms.Button();
            this.btnExcluirAlteracoes = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewDocumentacoes = new System.Windows.Forms.ListView();
            this.btnNovoDocumentacoes = new System.Windows.Forms.Button();
            this.btnAlterarDocumentacoes = new System.Windows.Forms.Button();
            this.btnExcluirDocumentacoes = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLiberarVersao
            // 
            this.btnLiberarVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLiberarVersao.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarVersao.Location = new System.Drawing.Point(620, 518);
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
            this.btnCancelar.Location = new System.Drawing.Point(788, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regras de Liberação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título da Liberação";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 139);
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
            this.listTipoLiberacao.Location = new System.Drawing.Point(535, 159);
            this.listTipoLiberacao.Name = "listTipoLiberacao";
            this.listTipoLiberacao.Size = new System.Drawing.Size(130, 20);
            this.listTipoLiberacao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 139);
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
            this.listSigla.Location = new System.Drawing.Point(754, 159);
            this.listSigla.Name = "listSigla";
            this.listSigla.Size = new System.Drawing.Size(130, 20);
            this.listSigla.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 194);
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
            this.label6.Location = new System.Drawing.Point(188, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Horas Franquia";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txbVersao
            // 
            this.txbVersao.Location = new System.Drawing.Point(18, 214);
            this.txbVersao.Name = "txbVersao";
            this.txbVersao.Size = new System.Drawing.Size(110, 20);
            this.txbVersao.TabIndex = 12;
            // 
            // txbRelease
            // 
            this.txbRelease.Location = new System.Drawing.Point(191, 214);
            this.txbRelease.Name = "txbRelease";
            this.txbRelease.Size = new System.Drawing.Size(113, 20);
            this.txbRelease.TabIndex = 13;
            // 
            // txbHoras
            // 
            this.txbHoras.Location = new System.Drawing.Point(359, 214);
            this.txbHoras.Name = "txbHoras";
            this.txbHoras.Size = new System.Drawing.Size(117, 20);
            this.txbHoras.TabIndex = 14;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnviarEmail.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.Location = new System.Drawing.Point(21, 518);
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
            this.label8.Location = new System.Drawing.Point(18, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Scripts de Banco de Dados";
            // 
            // listViewScripts
            // 
            this.listViewScripts.HideSelection = false;
            this.listViewScripts.Location = new System.Drawing.Point(21, 287);
            this.listViewScripts.Name = "listViewScripts";
            this.listViewScripts.Size = new System.Drawing.Size(263, 90);
            this.listViewScripts.TabIndex = 17;
            this.listViewScripts.UseCompatibleStateImageBehavior = false;
            // 
            // btnNovoScripts
            // 
            this.btnNovoScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoScripts.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoScripts.Location = new System.Drawing.Point(290, 287);
            this.btnNovoScripts.Name = "btnNovoScripts";
            this.btnNovoScripts.Size = new System.Drawing.Size(96, 26);
            this.btnNovoScripts.TabIndex = 18;
            this.btnNovoScripts.Text = "Novo";
            this.btnNovoScripts.UseVisualStyleBackColor = false;
            // 
            // btnAlterarScripts
            // 
            this.btnAlterarScripts.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarScripts.Location = new System.Drawing.Point(290, 319);
            this.btnAlterarScripts.Name = "btnAlterarScripts";
            this.btnAlterarScripts.Size = new System.Drawing.Size(96, 26);
            this.btnAlterarScripts.TabIndex = 19;
            this.btnAlterarScripts.Text = "Alterar";
            this.btnAlterarScripts.UseVisualStyleBackColor = true;
            // 
            // btnExcluirScripts
            // 
            this.btnExcluirScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirScripts.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirScripts.Location = new System.Drawing.Point(290, 351);
            this.btnExcluirScripts.Name = "btnExcluirScripts";
            this.btnExcluirScripts.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirScripts.TabIndex = 20;
            this.btnExcluirScripts.Text = "Excluir";
            this.btnExcluirScripts.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alterações Realizadas no Projeto";
            // 
            // listViewAlteracoes
            // 
            this.listViewAlteracoes.HideSelection = false;
            this.listViewAlteracoes.Location = new System.Drawing.Point(519, 286);
            this.listViewAlteracoes.Name = "listViewAlteracoes";
            this.listViewAlteracoes.Size = new System.Drawing.Size(263, 90);
            this.listViewAlteracoes.TabIndex = 22;
            this.listViewAlteracoes.UseCompatibleStateImageBehavior = false;
            this.listViewAlteracoes.SelectedIndexChanged += new System.EventHandler(this.listViewAlteracoes_SelectedIndexChanged);
            // 
            // btnNovoAlteracoes
            // 
            this.btnNovoAlteracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAlteracoes.Location = new System.Drawing.Point(788, 287);
            this.btnNovoAlteracoes.Name = "btnNovoAlteracoes";
            this.btnNovoAlteracoes.Size = new System.Drawing.Size(96, 26);
            this.btnNovoAlteracoes.TabIndex = 23;
            this.btnNovoAlteracoes.Text = "Novo";
            this.btnNovoAlteracoes.UseVisualStyleBackColor = false;
            // 
            // btnAlterarAlteracoes
            // 
            this.btnAlterarAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAlteracoes.Location = new System.Drawing.Point(788, 319);
            this.btnAlterarAlteracoes.Name = "btnAlterarAlteracoes";
            this.btnAlterarAlteracoes.Size = new System.Drawing.Size(96, 26);
            this.btnAlterarAlteracoes.TabIndex = 24;
            this.btnAlterarAlteracoes.Text = "Alterar";
            this.btnAlterarAlteracoes.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAlteracoes
            // 
            this.btnExcluirAlteracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirAlteracoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAlteracoes.Location = new System.Drawing.Point(788, 350);
            this.btnExcluirAlteracoes.Name = "btnExcluirAlteracoes";
            this.btnExcluirAlteracoes.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirAlteracoes.TabIndex = 25;
            this.btnExcluirAlteracoes.Text = "Excluir";
            this.btnExcluirAlteracoes.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Documentações Extras";
            // 
            // listViewDocumentacoes
            // 
            this.listViewDocumentacoes.HideSelection = false;
            this.listViewDocumentacoes.Location = new System.Drawing.Point(21, 414);
            this.listViewDocumentacoes.Name = "listViewDocumentacoes";
            this.listViewDocumentacoes.Size = new System.Drawing.Size(263, 90);
            this.listViewDocumentacoes.TabIndex = 27;
            this.listViewDocumentacoes.UseCompatibleStateImageBehavior = false;
            // 
            // btnNovoDocumentacoes
            // 
            this.btnNovoDocumentacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNovoDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoDocumentacoes.Location = new System.Drawing.Point(290, 414);
            this.btnNovoDocumentacoes.Name = "btnNovoDocumentacoes";
            this.btnNovoDocumentacoes.Size = new System.Drawing.Size(96, 26);
            this.btnNovoDocumentacoes.TabIndex = 28;
            this.btnNovoDocumentacoes.Text = "Novo";
            this.btnNovoDocumentacoes.UseVisualStyleBackColor = false;
            // 
            // btnAlterarDocumentacoes
            // 
            this.btnAlterarDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDocumentacoes.Location = new System.Drawing.Point(290, 446);
            this.btnAlterarDocumentacoes.Name = "btnAlterarDocumentacoes";
            this.btnAlterarDocumentacoes.Size = new System.Drawing.Size(96, 26);
            this.btnAlterarDocumentacoes.TabIndex = 29;
            this.btnAlterarDocumentacoes.Text = "Alterar";
            this.btnAlterarDocumentacoes.UseVisualStyleBackColor = true;
            // 
            // btnExcluirDocumentacoes
            // 
            this.btnExcluirDocumentacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirDocumentacoes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDocumentacoes.Location = new System.Drawing.Point(290, 478);
            this.btnExcluirDocumentacoes.Name = "btnExcluirDocumentacoes";
            this.btnExcluirDocumentacoes.Size = new System.Drawing.Size(96, 26);
            this.btnExcluirDocumentacoes.TabIndex = 30;
            this.btnExcluirDocumentacoes.Text = "Excluir";
            this.btnExcluirDocumentacoes.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(424, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "1. Verificar se os scripts/fontes estão atualizados.\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(18, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(432, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "3. Atualizar branchs referentes ao sistema no Github.\r\n\r\n";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(18, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(768, 32);
            this.label13.TabIndex = 33;
            this.label13.Text = "2. Colocar no corpo do e-mail a ordem de compilação dos scripts, as parametrizaçõ" +
    "es necessárias\r\n e quais os sistemas que precisarão ser parados.\r\n";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // TelaLiberadpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 556);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirDocumentacoes);
            this.Controls.Add(this.btnAlterarDocumentacoes);
            this.Controls.Add(this.btnNovoDocumentacoes);
            this.Controls.Add(this.listViewDocumentacoes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExcluirAlteracoes);
            this.Controls.Add(this.btnAlterarAlteracoes);
            this.Controls.Add(this.btnNovoAlteracoes);
            this.Controls.Add(this.listViewAlteracoes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExcluirScripts);
            this.Controls.Add(this.btnAlterarScripts);
            this.Controls.Add(this.btnNovoScripts);
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
            this.Name = "TelaLiberadpr";
            this.Text = "Liberador de versão - SUAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLiberarVersao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnNovoScripts;
        private System.Windows.Forms.Button btnAlterarScripts;
        private System.Windows.Forms.Button btnExcluirScripts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewAlteracoes;
        private System.Windows.Forms.Button btnNovoAlteracoes;
        private System.Windows.Forms.Button btnAlterarAlteracoes;
        private System.Windows.Forms.Button btnExcluirAlteracoes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewDocumentacoes;
        private System.Windows.Forms.Button btnNovoDocumentacoes;
        private System.Windows.Forms.Button btnAlterarDocumentacoes;
        private System.Windows.Forms.Button btnExcluirDocumentacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

