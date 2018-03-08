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
    public partial class frmUm : Form
    {
        string valor;

        public frmUm(string nome)
        {
            InitializeComponent();

            valor = nome;

            lb_nome.Text = valor;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            lb_outro.Text = valor;
        }
    }
}
