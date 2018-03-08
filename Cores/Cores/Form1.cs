using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void ApresentarCor()
        {
            cor = Color.FromArgb(track1.Value, track2.Value, track3.Value);
            caixa.BackColor = cor;
        }

        private void track1_Scroll(object sender, EventArgs e)
        {
            label1.Text = track1.Value.ToString();
            ApresentarCor();
        }

        private void track2_Scroll(object sender, EventArgs e)
        {
            label2.Text = track2.Value.ToString();
            ApresentarCor();
        }

        private void track3_Scroll(object sender, EventArgs e)
        {
            label3.Text = track3.Value.ToString();
            ApresentarCor();
        }
    }
}
