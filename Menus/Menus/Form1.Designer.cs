namespace Menus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.propriedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_combo_1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_edit,
            this.mnu_combo_1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new,
            this.mnu_open,
            this.toolStripSeparator1,
            this.mnu_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(61, 23);
            this.mnu_file.Text = "Arquivo";
            // 
            // mnu_new
            // 
            this.mnu_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new_project,
            this.mnu_new_file});
            this.mnu_new.Name = "mnu_new";
            this.mnu_new.Size = new System.Drawing.Size(152, 22);
            this.mnu_new.Text = "Novo";
            // 
            // mnu_open
            // 
            this.mnu_open.Name = "mnu_open";
            this.mnu_open.Size = new System.Drawing.Size(152, 22);
            this.mnu_open.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_exit.Size = new System.Drawing.Size(152, 22);
            this.mnu_exit.Text = "Sair";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // mnu_new_project
            // 
            this.mnu_new_project.Name = "mnu_new_project";
            this.mnu_new_project.Size = new System.Drawing.Size(152, 22);
            this.mnu_new_project.Text = "Projeto";
            // 
            // mnu_new_file
            // 
            this.mnu_new_file.Name = "mnu_new_file";
            this.mnu_new_file.Size = new System.Drawing.Size(152, 22);
            this.mnu_new_file.Text = "Arquivo";
            // 
            // btn_desativar
            // 
            this.btn_desativar.Location = new System.Drawing.Point(218, 143);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(75, 23);
            this.btn_desativar.TabIndex = 1;
            this.btn_desativar.Text = "Desativar";
            this.btn_desativar.UseVisualStyleBackColor = true;
            this.btn_desativar.Click += new System.EventHandler(this.btn_desativar_Click);
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_undo,
            this.toolStripSeparator2,
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.toolStripSeparator3,
            this.propriedadesToolStripMenuItem});
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(49, 23);
            this.mnu_edit.Text = "Editar";
            // 
            // mnu_undo
            // 
            this.mnu_undo.Name = "mnu_undo";
            this.mnu_undo.Size = new System.Drawing.Size(152, 22);
            this.mnu_undo.Text = "Desfazer";
            // 
            // btn_ativar
            // 
            this.btn_ativar.Location = new System.Drawing.Point(137, 143);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(75, 23);
            this.btn_ativar.TabIndex = 2;
            this.btn_ativar.Text = "Ativar";
            this.btn_ativar.UseVisualStyleBackColor = true;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // propriedadesToolStripMenuItem
            // 
            this.propriedadesToolStripMenuItem.Name = "propriedadesToolStripMenuItem";
            this.propriedadesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propriedadesToolStripMenuItem.Text = "Propriedades...";
            // 
            // mnu_combo_1
            // 
            this.mnu_combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mnu_combo_1.Items.AddRange(new object[] {
            "Valor 1",
            "Valor 2",
            "Valor 3"});
            this.mnu_combo_1.Name = "mnu_combo_1";
            this.mnu_combo_1.Size = new System.Drawing.Size(121, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 184);
            this.Controls.Add(this.btn_ativar);
            this.Controls.Add(this.btn_desativar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_project;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.ToolStripMenuItem mnu_undo;
        private System.Windows.Forms.Button btn_desativar;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem propriedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mnu_combo_1;
    }
}

