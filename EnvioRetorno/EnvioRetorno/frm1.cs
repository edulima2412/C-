using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            frm2 form = new frm2();
            form.ShowDialog();

            if (form.nome != null)
                lb_nome.Text = form.nome;
        }
    }
}
