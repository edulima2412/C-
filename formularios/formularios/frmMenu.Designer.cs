namespace formularios
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_um = new System.Windows.Forms.Button();
            this.btn_dois = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_um
            // 
            this.btn_um.Location = new System.Drawing.Point(84, 80);
            this.btn_um.Name = "btn_um";
            this.btn_um.Size = new System.Drawing.Size(120, 41);
            this.btn_um.TabIndex = 0;
            this.btn_um.Text = "button1";
            this.btn_um.UseVisualStyleBackColor = true;
            this.btn_um.Click += new System.EventHandler(this.btn_um_Click);
            // 
            // btn_dois
            // 
            this.btn_dois.Location = new System.Drawing.Point(84, 127);
            this.btn_dois.Name = "btn_dois";
            this.btn_dois.Size = new System.Drawing.Size(120, 41);
            this.btn_dois.TabIndex = 1;
            this.btn_dois.Text = "button2";
            this.btn_dois.UseVisualStyleBackColor = true;
            this.btn_dois.Click += new System.EventHandler(this.btn_dois_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(154, 215);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(118, 34);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(15, 36);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(189, 20);
            this.text_nome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_dois);
            this.Controls.Add(this.btn_um);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_um;
        private System.Windows.Forms.Button btn_dois;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
    }
}

