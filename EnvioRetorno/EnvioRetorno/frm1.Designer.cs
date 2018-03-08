namespace EnvioRetorno
{
    partial class frm1
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
            this.btn_avancar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(235, 203);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(81, 25);
            this.btn_avancar.TabIndex = 0;
            this.btn_avancar.Text = "Avançar";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_nome.Location = new System.Drawing.Point(12, 66);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(304, 34);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 240);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.btn_avancar);
            this.Name = "frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.Label lb_nome;
    }
}

