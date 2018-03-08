using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PastaFicheiro
{
    public partial class Form1 : Form
    {
        string pasta_config = @"C:\Users\cyber\OneDrive\Documentos\C#\PastaFicheiro\Config\";
        string ficheiro_config = "config.dat";

        public Form1()
        {
            InitializeComponent();

            //Localiza a pasta e o ficheiro em Meus Documentos
            //pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Determinar se uma pasta existe
            if (!Directory.Exists(pasta_config))
                Directory.CreateDirectory(pasta_config);

            StreamWriter ficheiro = new StreamWriter(pasta_config + ficheiro_config, false, Encoding.Default);
            ficheiro.WriteLine(texto_nome.Text);
            ficheiro.WriteLine(data_hora.Value.ToShortDateString());

            ficheiro.Dispose();

            MessageBox.Show("Configurações gravadas com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pasta_config))
            {
                StreamReader ficheiro = new StreamReader(pasta_config + ficheiro_config, Encoding.Default);
                texto_nome.Text = ficheiro.ReadLine();
                data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());

                ficheiro.Dispose();
                MessageBox.Show("Carregamento feito com sucesso.");
            }
            else
            {
                MessageBox.Show("Essa pasta não existe");
            }

        }
    }
}
