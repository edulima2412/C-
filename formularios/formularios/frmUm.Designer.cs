namespace formularios
{
    partial class frmUm
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_outro = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(53, 228);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(120, 41);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 28);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(203, 23);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_outro
            // 
            this.lb_outro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_outro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outro.Location = new System.Drawing.Point(12, 104);
            this.lb_outro.Name = "lb_outro";
            this.lb_outro.Size = new System.Drawing.Size(203, 23);
            this.lb_outro.TabIndex = 3;
            this.lb_outro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(53, 130);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(120, 27);
            this.btn_executar.TabIndex = 4;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 281);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.lb_outro);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.btn_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_outro;
        private System.Windows.Forms.Button btn_executar;
    }
}