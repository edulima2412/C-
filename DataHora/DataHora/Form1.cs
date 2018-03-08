using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(textBox1.Text);
            int mes = int.Parse(textBox2.Text);
            int ano = int.Parse(textBox3.Text);

            DateTime data = new DateTime(ano, mes, dia);
            lb_resultado.Text = "Eu nasci " + data.DayOfWeek;
        }
    }
}
