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

namespace HomeFitness.Controls.Calendar
{
    public partial class Calendar : UserControl
    {
        string conS; //connectionString do bazy
        string toEdit;

        public Calendar()
        {
            InitializeComponent();
            conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
            Fillcombo();
            pokabaze();
        }

        private void pokabaze() // poka poka baze mi
        {

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Plan_treningu", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_Planu"].ToString());
                item.SubItems.Add(dr["Dzien"].ToString());
                item.SubItems.Add(dr["Godzina"].ToString());
                item.SubItems.Add(dr["Treningi_Nr_treningu"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //edycja
        {
            
            int c = 0;//pomocnicza
            int blad = 0;

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
                SqlDataAdapter da = new SqlDataAdapter("Select Nr_Planu from Plan_treningu", cn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (textBox7.Text == dr["Nr_Planu"].ToString())
                        c++;

                }
                cn.Close();
            }
            if (c == 0 && blad == 0)
            {
                MessageBox.Show("Podany index planu treningowego nie istnieje w bazie");

            }
            else if (blad == 0)
            {

                string input = textBox7.Text;
                toEdit = input;
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Plan_treningu where Nr_Planu='" + input + "' ", cn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    dateTimePicker2.Text = dr["Dzien"].ToString();
                    dateTimePicker4.Text = dr["Godzina"].ToString();                 
                    comboBox2.Text = dr["Treningi_Nr_treningu"].ToString();
                }
                cn.Close();
                MessageBox.Show("Wybrano ćwiczenie do edycji");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            string cos = comboBox2.Text;
            string[] tc = cos.Split(new char[] { ' ' });
            string wartosc = tc[0];
            SqlDataAdapter da = new SqlDataAdapter("UPDATE Plan_treningu SET Dzien='" + dateTimePicker2.Text + "',Godzina='" + dateTimePicker4.Text + "',Treningi_Nr_treningu='" + wartosc + "' where Nr_Planu=" + toEdit + "", cn);
            da.SelectCommand.ExecuteNonQuery();
            cn.Close();
            comboBox2.Text = "";

            MessageBox.Show("Poprawnie zedytowano ćwiczenie");
        }

        private void button4_Click(object sender, EventArgs e) //dodanie do bazy
        {


            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            string cos = comboBox1.Text;
            string[] tc = cos.Split(new char[] { ' ' });
            string wartosc = tc[0];
            SqlDataAdapter da = new SqlDataAdapter("INSERT INTO Plan_treningu (Dzien,Godzina,Treningi_Nr_treningu) VALUES('" + dateTimePicker1.Text + "','" + dateTimePicker3.Text + "','" + wartosc + "')", cn);
            da.SelectCommand.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Dodano trening do planu");
        }


        private void button5_Click_1(object sender, EventArgs e) // usuwanie z bazy
        {
            if (!Regex.IsMatch(textBox8.Text, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show("Podano błędny index");
            }
            else
            {
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("DELETE from Plan_treningu WHERE NR_Planu='" + textBox8.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Usunięto zaplanowany trening");
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            listView1.Items.Clear();
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Plan_treningu", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_Planu"].ToString());
                item.SubItems.Add(dr["Dzien"].ToString());
                item.SubItems.Add(dr["Godzina"].ToString());
                item.SubItems.Add(dr["Treningi_Nr_treningu"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fillcombo()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Treningi", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                string cos = dr["Nr_treningu"].ToString();
                string cos2 = dr["Nazwa"].ToString();
                string cos3 = cos + " " + cos2;
                comboBox1.Items.Add(cos3);
                comboBox2.Items.Add(cos3);
            }
            cn.Close();
        }
        
 
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 
        }

    }
}
