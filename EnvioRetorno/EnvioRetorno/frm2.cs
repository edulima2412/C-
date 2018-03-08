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
    public partial class frm2 : Form
    {
        public string nome { get; set; }

        public frm2()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            nome = null;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
                nome = null;
            else
                nome = txt_nome.Text;
            this.Close();
        }
    }
}
