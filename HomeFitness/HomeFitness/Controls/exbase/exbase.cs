using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
namespace HomeFitness.Controls.exbase
{
    public partial class exbase : UserControl
    {

        string conS; //connectionString do bazy
        string toEdit;
        public exbase()
        {
            InitializeComponent();
            //inicjalizacja polaczenia do bazy

            conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
            pokabaze();
        }

        private void pokabaze() // poka poka baze mi
        {

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cwiczenia", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_cwiczenia"].ToString());
                item.SubItems.Add(dr["Nazwa"].ToString());
                item.SubItems.Add(dr["Spalone_kalorie"].ToString());
                item.SubItems.Add(dr["Cwiczone_miesnie"].ToString());
                item.SubItems.Add(dr["Opis"].ToString());
                item.SubItems.Add(dr["Zalecana_ilosc"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




        private void button4_Click(object sender, EventArgs e) //dodanie do bazy
        {
            if (!Regex.IsMatch(textBox1.Text, @"^(?!\s*$).+"))
            {
                MessageBox.Show("Nazwa jest pusta!!!!");
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^(\s*|\d+)$"))
            {
                MessageBox.Show("Podano błędną liczbę kalorii");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^(\s*|\d+)$"))
            {
                MessageBox.Show("Podano błędną liczbę powtórzeń");
            }
            else
            {

                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("INSERT INTO Cwiczenia (Nazwa,Spalone_kalorie,Cwiczone_miesnie,Opis,Zalecana_ilosc) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "')", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Dodano ćwiczenie");


                listView1.Items.Clear();
                SqlConnection cn1 = new SqlConnection(conS);
                cn1.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from Cwiczenia", cn1);
                da1.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Nr_cwiczenia"].ToString());
                    item.SubItems.Add(dr["Nazwa"].ToString());
                    item.SubItems.Add(dr["Spalone_kalorie"].ToString());
                    item.SubItems.Add(dr["Cwiczone_miesnie"].ToString());
                    item.SubItems.Add(dr["Opis"].ToString());
                    item.SubItems.Add(dr["Zalecana_ilosc"].ToString());
                    listView1.Items.Add(item);
                }
                cn1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) // usuwanie z bazy
        {
            if (!Regex.IsMatch(textBox8.Text, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show("Podano błędny index");
            }
            else
            {
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("DELETE from Cwiczenia WHERE NR_cwiczenia='" + textBox8.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Usunięto ćwiczenie");

                listView1.Items.Clear();
                SqlConnection cn1 = new SqlConnection(conS);
                cn1.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from Cwiczenia", cn1);
                da1.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Nr_cwiczenia"].ToString());
                    item.SubItems.Add(dr["Nazwa"].ToString());
                    item.SubItems.Add(dr["Spalone_kalorie"].ToString());
                    item.SubItems.Add(dr["Cwiczone_miesnie"].ToString());
                    item.SubItems.Add(dr["Opis"].ToString());
                    item.SubItems.Add(dr["Zalecana_ilosc"].ToString());
                    listView1.Items.Add(item);
                }
                cn1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // wybranei cwiczenia do edycji
        {
            int c = 0;//pomocnicza
            int blad = 0;

            //string input = Microsoft.VisualBasic.Interaction.InputBox("Podaj ID ćwiczenia, które chcesz edytować", "Edytowanie ćwiczenia", "");
            if (!Regex.IsMatch(textBox7.Text, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show("Podano błędny index");
                blad++;
            }
            else
            {
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Nr_cwiczenia from Cwiczenia", cn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (textBox7.Text == dr["Nr_cwiczenia"].ToString())
                        c++;

                }
                cn.Close();
            }
            if (c == 0 && blad == 0)
            {
                MessageBox.Show("Podany index ćwiczenia nie istnieje w bazie");

            }
            else if (blad == 0)
            {



                string input = textBox7.Text;
                toEdit = input;
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Cwiczenia where Nr_cwiczenia='" + input + "' ", cn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox6.Text = dr["Nazwa"].ToString();
                    textBox5.Text = dr["Spalone_kalorie"].ToString();
                    comboBox2.Text = dr["Cwiczone_miesnie"].ToString();
                    textBox4.Text = dr["Zalecana_ilosc"].ToString();
                    richTextBox2.Text = dr["Opis"].ToString();
                }
                cn.Close();
                MessageBox.Show("Wybrano ćwiczenie do edycji");
            }
        }

        private void button2_Click(object sender, EventArgs e) //edycja ćwiczenia
        {
            if (!Regex.IsMatch(textBox6.Text, @"^(?!\s*$).+"))
            {
                MessageBox.Show("Nazwa jest pusta!!!!");
            }
            else if (!Regex.IsMatch(textBox5.Text, @"^(\s*|\d+)$"))
            {
                MessageBox.Show("Podano błędną liczbę kalorii");
            }
            else if (!Regex.IsMatch(textBox4.Text, @"^(\s*|\d+)$"))
            {
                MessageBox.Show("Podano błędną liczbę powtórzeń");
            }
            else
            {


                SqlConnection cn = new SqlConnection(conS);
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("UPDATE Cwiczenia SET Nazwa='" + textBox6.Text + "',Spalone_kalorie='" + textBox5.Text + "',Cwiczone_miesnie='" + comboBox2.Text + "',Opis='" + richTextBox2.Text + "',Zalecana_ilosc='" + textBox4.Text + "' where Nr_cwiczenia=" + toEdit + "", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                textBox6.Clear();
                textBox5.Clear();
                textBox7.Clear();
                textBox4.Clear();
                comboBox2.Text = "";
                richTextBox2.Clear();

                MessageBox.Show("Poprawnie zedytowano ćwiczenie");


                listView1.Items.Clear();
                SqlConnection cn1 = new SqlConnection(conS);
                cn1.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from Cwiczenia", cn1);
                da1.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Nr_cwiczenia"].ToString());
                    item.SubItems.Add(dr["Nazwa"].ToString());
                    item.SubItems.Add(dr["Spalone_kalorie"].ToString());
                    item.SubItems.Add(dr["Cwiczone_miesnie"].ToString());
                    item.SubItems.Add(dr["Opis"].ToString());
                    item.SubItems.Add(dr["Zalecana_ilosc"].ToString());
                    listView1.Items.Add(item);
                }
                cn1.Close();
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
