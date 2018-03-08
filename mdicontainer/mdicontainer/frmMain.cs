using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mdicontainer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnu_abrir_Click(object sender, EventArgs e)
        {
            frmUm form = new frmUm(this);
            form.MdiParent = this;
            form.Show();

        }
    }
}
