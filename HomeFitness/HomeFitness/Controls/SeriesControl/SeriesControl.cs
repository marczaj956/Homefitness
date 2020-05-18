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

namespace HomeFitness.Controls.SeriesControl
{
    public partial class SeriesControl : UserControl
    {
        //zmienna do zapisu edytowanych
        int edit;
        //zmienna do połączenia z bazą
        string conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;

        public SeriesControl()
        {
            InitializeComponent();

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Seria_cwiczen", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_Serii"].ToString());
                item.SubItems.Add(dr["Nazwa_serii"].ToString());
                item.SubItems.Add(dr["Cwiczona_partia"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
            this.splitContainer1.Panel2.Hide();
            this.splitContainer1.Panel2Collapsed = true;

            edit = 0;
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //dodaj serie 
        {
            //pojawianie
            
                this.splitContainer1.Panel2.Show();
                this.splitContainer1.Panel2Collapsed = false;

            exInCombo();

        }

        private void exInCombo()
        {
            
            //cwiczenia
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Cwiczenia", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["Nazwa"].ToString());


            }
            cn.Close();
        } 

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar1.Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int exist = 0;
            foreach (ListViewItem item in listView2.Items) //spr czy jest juz takie cwiczenie
            {
                if (item.Text == comboBox2.Text)
                {
                    exist = 1;
                    MessageBox.Show("Takie cwiczenie juz istnieje");
                }
            }

            if (exist !=1 &&  comboBox2.Text != "" && label7.Text != "0") {
                ListViewItem item1 = new ListViewItem(comboBox2.Text);
                item1.SubItems.Add(label7.Text);
                listView2.Items.Add(item1);
                comboBox3.Items.Add(comboBox2.Text);
                comboBox2.SelectedIndex = -1;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //usun cwiczenie
        {

            foreach (ListViewItem item in listView2.Items)
            {
                if (item.Text == comboBox3.Text)
                    listView2.Items.Remove(item);
            }

            comboBox3.Items.Remove(comboBox3.Text);
          
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //zapisz serie
        {
            //połączenie z bazą 
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            //nr serii
            DataTable dt2 = new DataTable();
            string que1 = "Select Nr_Serii from Seria_cwiczen where Nazwa_serii like '" + textBox3.Text + "' ";
            SqlDataAdapter da2 = new SqlDataAdapter(que1, cn);
            da2.Fill(dt2);
            string seID = "0";
            foreach (DataRow dr in dt2.Rows)
            {
                seID = dr["Nr_Serii"].ToString();
            }

            //dodanie serii
            if (edit == 0 && textBox3.Text != "" && comboBox1.Text != "" && listView2.Items.Count != 0)
            {
               
                SqlDataAdapter da = new SqlDataAdapter("INSERT INTO Seria_cwiczen (Nazwa_serii, Cwiczona_partia) VALUES('" + textBox3.Text + "','" + comboBox1.Text + "')", cn);
                da.SelectCommand.ExecuteNonQuery();
                int temp = 0;
                foreach (ListViewItem items in listView2.Items)
                {
                   //nr cwiczenia
                    DataTable dt1 = new DataTable();
                    ListViewItem item = listView2.Items[temp];
                    string name = item.Text;
                    name = name.Trim();
                    //ilosc
                    string count = item.SubItems[1].Text;
                    string que = "Select Nr_cwiczenia from Cwiczenia where Nazwa like '" + name +"' " ;
                    SqlDataAdapter da1 = new SqlDataAdapter(que, cn);
                    da1.Fill(dt1);
                    string exID= "0";
                    temp++;

                    foreach (DataRow dr in dt1.Rows)
                    {
                       exID = dr["Nr_cwiczenia"].ToString();
                    }
                  
                    if (seID != "0" && exID != "0")
                    {
                        string que3 = "INSERT INTO CwSC (Cwiczenia_Nr_cwiczenia, Seria_cwiczen_Nr_Serii, Ilosc) VALUES('" + exID + "','" + seID + "', '" + count + "')";
                        SqlDataAdapter da3 = new SqlDataAdapter(que3, cn);
                        da3.SelectCommand.ExecuteNonQuery();
                        
                    }
                }
                
                MessageBox.Show("Dodano serię");
            }
            else //przy edycji
            {
                //update serii
                string que = "UPDATE Seria_cwiczen SET Nazwa_serii= '" + textBox3.Text + "', Cwiczona_partia = '" + comboBox1.Text + "' WHERE Nazwa_serii='" + textBox3.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(que, cn);
                da.SelectCommand.ExecuteNonQuery();

                int temp = 0;// pomocnicza do nr cwiczenia

                foreach (ListViewItem items in listView2.Items)
                {
                    //nr cwiczenia
                    DataTable dt1 = new DataTable();
                    ListViewItem item = listView2.Items[temp];
                    string name = item.Text;
                    name = name.Trim();
                    //ilosc
                    string count = item.SubItems[1].Text;

                    string que4 = "Select Nr_cwiczenia from Cwiczenia where Nazwa like '" + name + "' ";
                    SqlDataAdapter da1 = new SqlDataAdapter(que4, cn);
                    da1.Fill(dt1);
                    string exID = "0";
                    temp++;

                    foreach (DataRow dr in dt1.Rows)
                    {
                        exID = dr["Nr_cwiczenia"].ToString();
                    }
                   

                    if (seID != "0" && exID != "0")
                    {
                    
                        //update CwSC
                        string que2 = "UPDATE CwSC SET Ilosc= '" + count  + "', Cwiczenia_Nr_cwiczenia = '" + exID + "' WHERE Seria_cwiczen_Nr_Serii='" + seID + "'";
                        SqlDataAdapter da3 = new SqlDataAdapter(que2, cn);
                        da3.SelectCommand.ExecuteNonQuery();

                    }

                  
                }

                MessageBox.Show("Zapisano zmiany");
                edit = 0;

            }
            cn.Close();
            clean();
            this.splitContainer1.Panel2.Hide();
            this.splitContainer1.Panel2Collapsed = true;
        }

        private void clean()
        {
            listView2.Items.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //odswiez
        {
            listView1.Items.Clear();
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Seria_cwiczen", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_Serii"].ToString());
                item.SubItems.Add(dr["Nazwa_serii"].ToString());
                item.SubItems.Add(dr["Cwiczona_partia"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e) //edytuj
        {
            edit = 1;

            //pojawianie
            
                this.splitContainer1.Panel2.Show();
                this.splitContainer1.Panel2Collapsed = false;

            
            if (!Regex.IsMatch(textBox1.Text, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show("Podano błędny index");
            }
            else
            {
                exInCombo();
                //załadowanie danych o serii  
                //cwiczenia
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT  Seria_cwiczen.Nazwa_serii,Cwiczenia.Nazwa,Seria_cwiczen.Cwiczona_partia, CwSC.Ilosc from Seria_cwiczen JOIN CwSC on Seria_cwiczen.Nr_Serii = CwSC.Seria_cwiczen_Nr_Serii JOIN Cwiczenia on Cwiczenia.Nr_cwiczenia = CwSC.Cwiczenia_Nr_cwiczenia WHERE Seria_cwiczen.Nr_Serii = '" + textBox1.Text + "'", cn); 
                da1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                    textBox3.Text = dr["Nazwa_serii"].ToString();
                    comboBox1.Text = dr["Cwiczona_partia"].ToString();
                    ListViewItem item = new ListViewItem(dr["Nazwa"].ToString());
                    item.SubItems.Add(dr["Ilosc"].ToString());
                    listView2.Items.Add(item);
                    comboBox3.Items.Add(dr["Nazwa"].ToString());
                }

                cn.Close();
            }
        
        }

        private void button7_Click(object sender, EventArgs e) //usuń
        {
            if (!Regex.IsMatch(textBox2.Text, @"^\d*[1-9]\d*$"))
            {
                MessageBox.Show("Podano błędny index");
            }
            else
            {
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
              
                SqlDataAdapter da = new SqlDataAdapter("DELETE from CwSC WHERE Seria_cwiczen_Nr_Serii='" + textBox2.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter da1 = new SqlDataAdapter("DELETE from Seria_cwiczen WHERE Nr_Serii='" + textBox2.Text + "'", cn);
                da1.SelectCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Usunięto serie");
                textBox2.Text = "";

              
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
