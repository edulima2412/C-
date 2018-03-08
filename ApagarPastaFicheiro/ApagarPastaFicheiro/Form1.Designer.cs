namespace ApagarPastaFicheiro
{
    partial class Form1
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(405, 221);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(125, 35);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "Copiar";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(274, 221);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(125, 35);
            this.btn_listar.TabIndex = 1;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 13);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(517, 199);
            this.lista.TabIndex = 2;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(143, 221);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(125, 35);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(12, 221);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(125, 35);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 268);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_copy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_criar;
    }
}

