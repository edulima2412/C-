using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FicheirosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar ficheiro de texto - @(Identificar a \)
            StreamWriter ficheiro = new StreamWriter(@"C:\Users\cyber\OneDrive\Documentos\C#\FicheirosTexto\teste.txt", true, Encoding.Default);
            ficheiro.WriteLine(textBox1.Text);

            textBox1.Text = "";
            textBox1.Focus();

            //Encerra a execução do ficheiro
            ficheiro.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\Users\cyber\OneDrive\Documentos\C#\FicheirosTexto\teste.txt");
            while (!ficheiro.EndOfStream)
            {
                lista.Items.Add(ficheiro.ReadLine());
            }

            ficheiro.Dispose();
        }
    }
}
