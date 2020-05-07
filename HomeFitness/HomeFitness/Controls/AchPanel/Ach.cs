using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HomeFitness.Controls.AchPanel
{
    public partial class Ach : UserControl
    {
        public Ach()
        {
            InitializeComponent();

            //jak pusty to create

           



            //odczyt z pliku waga
            {
                string line;

               
                string extension = ".txt";
                string filePath = @"Waga" + extension;
                if (File.Exists(filePath))
                {
                    var file = new System.IO.StreamReader(filePath);

                    while ((line = file.ReadLine()) != null)
                    {
                        textpw.Text = line;

                    }

                    file.Close();
                }
                else { File.Create(filePath); 
                
                }
            }

            //odczyt z pliku cel
            {
                string line;
                
                string extension = ".txt";
                string filePath = @"Cel" + extension;
                if (File.Exists(filePath))
                { var file = new System.IO.StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    textdw.Text = line;

                }

                file.Close();
                }
                else File.Create(filePath);
            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Waga_Click(object sender, EventArgs e)
        {

        }

        private void NowaWaga_Enter(object sender, EventArgs e)
        {
            //edytujemy wagę po kliknięciu zapis do pliku
        }

        private void textpw_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textdw_TextChanged(object sender, EventArgs e)
        {
            //edytujemy wagę po kliknięciu zapis do pliku
        }

        private void textczas_TextChanged(object sender, EventArgs e)
        {
            //select z bazy
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //select z bazy
        }

        private void textlvl_TextChanged(object sender, EventArgs e)
        {
            //select z bazy z jakims przelicznikiem np na podstawie czsau albo kalorii albo 1 i 2

        }

        private void button1_Click(object sender, EventArgs e)
        {//zapis do pliku brak sprawdzenia poprawności

            if (textnw.Text.Length > 0)
            {
                
                string extension = ".txt";
                string filePath = @"Waga" + extension;


                if (!File.Exists(filePath)) File.Create(filePath);
                else 
                {

                    File.AppendAllText(filePath, textnw.Text + Environment.NewLine);
                    
                    
                }
                

                MessageBox.Show("Zapisano!");
            }

            else MessageBox.Show("Wpisz wagę!");


        }

        private void CZapisz_Click(object sender, EventArgs e)
        {//zapis do pliku brak sprawdzenia poprawności
            if (textdw.Text.Length > 0)
            {
                
                string extension = ".txt";
                string filePath = @"Cel" + extension;
                if (!File.Exists(filePath))
                File.Create(filePath);
                else
                {
                    using (TextWriter TW = new StreamWriter(filePath))
                    {


                        TW.WriteLine(textdw.Text);
                        TW.Close();
                    }
                }
                
                MessageBox.Show("Zapisano!");
            }

            else MessageBox.Show("Wpisz wagę!");
        }
    }
}
