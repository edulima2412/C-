namespace Cores
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
            this.caixa = new System.Windows.Forms.PictureBox();
            this.track1 = new System.Windows.Forms.TrackBar();
            this.track3 = new System.Windows.Forms.TrackBar();
            this.track2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            this.SuspendLayout();
            // 
            // caixa
            // 
            this.caixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa.Location = new System.Drawing.Point(12, 12);
            this.caixa.Name = "caixa";
            this.caixa.Size = new System.Drawing.Size(233, 100);
            this.caixa.TabIndex = 0;
            this.caixa.TabStop = false;
            // 
            // track1
            // 
            this.track1.Location = new System.Drawing.Point(12, 118);
            this.track1.Maximum = 255;
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(214, 45);
            this.track1.TabIndex = 1;
            this.track1.Scroll += new System.EventHandler(this.track1_Scroll);
            // 
            // track3
            // 
            this.track3.Location = new System.Drawing.Point(12, 210);
            this.track3.Maximum = 255;
            this.track3.Name = "track3";
            this.track3.Size = new System.Drawing.Size(214, 45);
            this.track3.TabIndex = 2;
            this.track3.Scroll += new System.EventHandler(this.track3_Scroll);
            // 
            // track2
            // 
            this.track2.Location = new System.Drawing.Point(12, 163);
            this.track2.Maximum = 255;
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(214, 45);
            this.track2.TabIndex = 3;
            this.track2.Scroll += new System.EventHandler(this.track2_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track2);
            this.Controls.Add(this.track3);
            this.Controls.Add(this.track1);
            this.Controls.Add(this.caixa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox caixa;
        private System.Windows.Forms.TrackBar track1;
        private System.Windows.Forms.TrackBar track3;
        private System.Windows.Forms.TrackBar track2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

