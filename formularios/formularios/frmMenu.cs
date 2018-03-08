using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            frmUm form1 = new frmUm(text_nome.Text);
            form1.ShowDialog();
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            frmDois form2 = new frmDois();
            form2.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
