using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace ApagarPastaFicheiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            //Copia o arquivo desejado
            File.Copy(@"C:\Users\cyber\OneDrive\Documentos\C#\PastaFicheiro\Config\config.dat", @"C:\Users\cyber\OneDrive\Documentos\C#\ApagarPastaFicheiro\config.dat");

            MessageBox.Show("Copiado com sucesso.");
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            string[] lista_ficheiros = Directory.GetFiles(@"C:\Users\cyber\OneDrive\Documentos\C#\ApagarPastaFicheiro\Testando", "*.*");

            foreach (string item in lista_ficheiros)
                lista.Items.Add(item);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string folderName = @"C:\Users\cyber\OneDrive\Documentos\C#\ApagarPastaFicheiro";

            string pathString = Path.Combine(folderName, "Testando");

            Directory.CreateDirectory(pathString);

            string fileName = Path.GetRandomFileName();

            pathString = Path.Combine(pathString, fileName);

            if (!File.Exists(pathString))
            {
                using (FileStream fs = File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
        }
    }
}
