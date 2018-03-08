namespace CaixasDialogo
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
            this.btn_msgbox = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_folder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_msgbox
            // 
            this.btn_msgbox.Location = new System.Drawing.Point(226, 12);
            this.btn_msgbox.Name = "btn_msgbox";
            this.btn_msgbox.Size = new System.Drawing.Size(113, 29);
            this.btn_msgbox.TabIndex = 0;
            this.btn_msgbox.Text = "MessageBox";
            this.btn_msgbox.UseVisualStyleBackColor = true;
            this.btn_msgbox.Click += new System.EventHandler(this.btn_msgbox_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(226, 47);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(113, 29);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "OpenFileDialog";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(226, 82);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 29);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "SaveFileDialog";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(226, 117);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(113, 29);
            this.btn_folder.TabIndex = 4;
            this.btn_folder.Text = "FolderBrowserDialog";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_msgbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_msgbox;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_folder;
    }
}

