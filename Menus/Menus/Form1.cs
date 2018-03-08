using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {
            mnu_undo.Enabled = false;
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            mnu_undo.Enabled = true;
        }
    }
}
