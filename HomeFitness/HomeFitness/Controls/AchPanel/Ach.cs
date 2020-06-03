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
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
namespace HomeFitness.Controls.AchPanel
{
    public partial class Ach : UserControl
    {
        string conS; //connectionString do bazy
        string toEdit;
        public Ach()
        {
            
            InitializeComponent();
            conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
            {
                String nr = "1";
                
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter d = new SqlDataAdapter("Select Poprzednia from Waga where Id='" + nr + "' ", cn);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textpw.Text = dr["Poprzednia"].ToString();
                    
                }
                d= new SqlDataAdapter("Select Obecna from Waga where Id='" + nr + "' ", cn);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textnw.Text = dr["Obecna"].ToString();

                }
                d = new SqlDataAdapter("Select Cel from Waga where Id='" + nr + "' ", cn);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textdw.Text = dr["Cel"].ToString();
                    
                }
                

                //SqlDataAdapter dc = new SqlDataAdapter("INSERT INTO Czas (czas.czas,kalorie) VALUES('" + "3" + "','" + "3" + "')", cn);
               // dc.SelectCommand.ExecuteNonQuery();


                
                d= new SqlDataAdapter("Select sum(czas) as czas from czas ", cn);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textczas.Text = dr["czas"].ToString();

                }

                d = new SqlDataAdapter("Select sum(kalorie) as kalorie from czas ", cn);
                d.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    textkalorie.Text = dr["kalorie"].ToString();

                }


                cn.Close();


                
                int czas = Int32.Parse(textczas.Text);
                int kcal = Int32.Parse(textkalorie.Text);
                double wartosc = czas * 0.6 + kcal * 0.2;
                if (wartosc<=100)
                {
                    textlvl.Text = "Początkujący";
                }
                else if (wartosc > 100 && wartosc<=300)
                {
                    textlvl.Text = "Średni";
                }
                else if(wartosc>300)
                {
                    {
                        textlvl.Text = "Zaawansowany";
                    }
                }



            }
//do pliku
            {/*        { 
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
                else { 
                    File.Create(filePath).Close();
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
                else File.Create(filePath).Close();
            }

}*/
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




            if (!Regex.IsMatch(textnw.Text, @"^(?!\s*$).+"))
            {
                MessageBox.Show("Nazwa jest pusta!!!!");
            }

            else if (Regex.IsMatch(textnw.Text, @"^[0-9]*(?:\.[0-9]*)?$"))
            {//do pliku
                {/*
                
                string extension = ".txt";
                string filePath = @"Waga" + extension;


                if (!File.Exists(filePath)) File.Create(filePath).Close();
                else 
                {

                    File.AppendAllText(filePath, textnw.Text + Environment.NewLine);
                    
                    
                }
                

                MessageBox.Show("Zapisano!");*/
                }
                {
                    String nr = "1";
                    float ob = 0;
                    SqlConnection cn = new SqlConnection(conS);
                    cn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter d = new SqlDataAdapter("Select Obecna from Waga where Id='" + nr + "' ", cn);
                    d.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        ob=float.Parse( dr["Obecna"].ToString());
                    }
                    SqlDataAdapter da = new SqlDataAdapter("Update Waga SET Poprzednia='" + ob + "' ,Obecna='" + textnw.Text + "'", cn);
                    da.SelectCommand.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Zapisano");
                    
                }


            }

            
else
            {
                MessageBox.Show("Podaj poprawną wartość np. 85.5");
            }

        }

        private void CZapisz_Click(object sender, EventArgs e)
        {//zapis do pliku brak sprawdzenia poprawności
            if (!Regex.IsMatch(textdw.Text, @"^(?!\s*$).+"))
            {
                MessageBox.Show("Nazwa jest pusta!!!!");
            }
            
            else if (Regex.IsMatch(textdw.Text, @"^[0-9]*(?:\.[0-9]*)?$")) {
                
                float ob = 0;
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Update Waga SET Cel='"  + textdw.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Zapisano");

            }
            else
            {
                MessageBox.Show("Podaj poprawną wartość np. 85.5");
            }
            //do pliku

            /*{
                
                string extension = ".txt";
                string filePath = @"Cel" + extension;
                if (!File.Exists(filePath))
                File.Create(filePath).Close();
                else
                {
                    using (TextWriter TW = new StreamWriter(filePath))
                    {


                        TW.WriteLine(textdw.Text);
                        TW.Close();
                    }
                }
                
                MessageBox.Show("Zapisano!");
            }*/

        }
    }
}
