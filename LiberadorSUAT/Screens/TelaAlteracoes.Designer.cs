
namespace LiberadorSUAT.Screens
{
    partial class TelaAlteracoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHelpdesk = new System.Windows.Forms.TextBox();
            this.txbResponsavel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAlteracao = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listViewTeste = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alteração Realizada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HelpDesk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Responsável";
            // 
            // txbHelpdesk
            // 
            this.txbHelpdesk.Location = new System.Drawing.Point(15, 83);
            this.txbHelpdesk.Name = "txbHelpdesk";
            this.txbHelpdesk.Size = new System.Drawing.Size(100, 20);
            this.txbHelpdesk.TabIndex = 3;
            // 
            // txbResponsavel
            // 
            this.txbResponsavel.Location = new System.Drawing.Point(170, 83);
            this.txbResponsavel.Name = "txbResponsavel";
            this.txbResponsavel.Size = new System.Drawing.Size(346, 20);
            this.txbResponsavel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição do Chamado";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(15, 150);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(501, 20);
            this.txbDescricao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alteração Realizada";
            // 
            // txbAlteracao
            // 
            this.txbAlteracao.Location = new System.Drawing.Point(15, 217);
            this.txbAlteracao.Name = "txbAlteracao";
            this.txbAlteracao.Size = new System.Drawing.Size(501, 20);
            this.txbAlteracao.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOk.Location = new System.Drawing.Point(348, 252);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(441, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listViewTeste
            // 
            this.listViewTeste.HideSelection = false;
            this.listViewTeste.Location = new System.Drawing.Point(12, 283);
            this.listViewTeste.Name = "listViewTeste";
            this.listViewTeste.Size = new System.Drawing.Size(277, 131);
            this.listViewTeste.TabIndex = 11;
            this.listViewTeste.UseCompatibleStateImageBehavior = false;
            this.listViewTeste.SelectedIndexChanged += new System.EventHandler(this.listViewTeste_SelectedIndexChanged);
            // 
            // TelaAlteracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 441);
            this.Controls.Add(this.listViewTeste);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbAlteracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResponsavel);
            this.Controls.Add(this.txbHelpdesk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlteracoes";
            this.Text = "TelaAlteracoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbHelpdesk;
        private System.Windows.Forms.TextBox txbResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAlteracao;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView listViewTeste;
    }
}