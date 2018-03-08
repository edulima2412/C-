using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CaixasDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_msgbox_Click(object sender, EventArgs e)
        {
            //Titulo, botão, ícone
            if(MessageBox.Show("Deseja encerrar o programa", "Programa Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "Abrindo ficheiro";
            caixa.InitialDirectory = @"C:\";
            caixa.Filter = "Jpeg Images (*.jpg)|*.jpg|" +
                           "BMP Images (*.bmp)|*.bmp";

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackgroundImage = Image.FromFile(caixa.FileName);

            caixa.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "Salvando ficheiro";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = "TXT Files (*.txt)|*.txt|" +
                           "JPG Images (*.jpg)|*.jpg|" +
                           "BMP Images (*.bmp)|*.bmp";
            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            //Salvar ficheiro
            string ficheiro = caixa.FileName;

            StreamWriter file = new StreamWriter(ficheiro, false, Encoding.Default);
            file.WriteLine("Testando");
            file.Dispose();
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixa = new FolderBrowserDialog();
            caixa.SelectedPath = @"C:\";
            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            MessageBox.Show("A pasta escolhida foi " + caixa.SelectedPath);
        }
    }
}
