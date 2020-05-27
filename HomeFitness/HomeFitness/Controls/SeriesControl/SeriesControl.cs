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
            showBase();
            this.splitContainer1.Panel2.Hide();
            this.splitContainer1.Panel2Collapsed = true;

            edit = 0;

        }

        private void showBase()
        {
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

        private void trackBar1_Scroll(object sender, EventArgs e) //ilosc w label
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

        private void button4_Click(object sender, EventArgs e) //dodaj cwiczenie
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

            if (exist != 1 && comboBox2.Text != "" && label7.Text != "0")
            {
                ListViewItem item1 = new ListViewItem(comboBox2.Text);
                item1.SubItems.Add(label7.Text);
                listView2.Items.Add(item1);
                comboBox3.Items.Add(comboBox2.Text);
                comboBox2.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Sprawdź czy wszystkie pola są poprawnie wypełnione");
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


            //dodanie serii
            if (edit == 0 && textBox3.Text != "" && comboBox1.Text != "" && listView2.Items.Count != 0)
            {

                //nr serii

                string name = textBox3.Text;
                string part = comboBox1.Text;

                using (SqlConnection cn1 = new SqlConnection(conS))
                using (SqlCommand command = cn1.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Seria_cwiczen (Nazwa_serii, Cwiczona_partia) VALUES(@name, @part)";

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@part", part);
                    cn1.Open();
                    command.ExecuteNonQuery();
                    cn1.Close();
                }

                //połączenie z bazą 
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt2 = new DataTable();
                string que1 = "Select Nr_Serii from Seria_cwiczen where Nazwa_serii like '" + textBox3.Text + "' ";
                SqlDataAdapter da2 = new SqlDataAdapter(que1, cn);
                da2.Fill(dt2);
                string seID = "0";
                foreach (DataRow dr in dt2.Rows)
                {
                    seID = dr["Nr_Serii"].ToString();
                }
                cn.Close();



                int temp = 0;
                foreach (ListViewItem items in listView2.Items)
                {
                    //nr cwiczenia
                    DataTable dt1 = new DataTable();
                    ListViewItem item = listView2.Items[temp];
                    string nameex = item.Text;
                    nameex = nameex.Trim();
                    //ilosc
                    string count = item.SubItems[1].Text;
                    string que = "Select Nr_cwiczenia from Cwiczenia where Nazwa like '" + nameex + "' ";
                    SqlDataAdapter da1 = new SqlDataAdapter(que, cn);
                    da1.Fill(dt1);
                    string exID = "0";
                    temp++;

                    foreach (DataRow dr in dt1.Rows)
                    {
                        exID = dr["Nr_cwiczenia"].ToString();
                    }

                    if (seID != "0" && exID != "0")
                    {

                        using (SqlConnection cn1 = new SqlConnection(conS))
                        using (SqlCommand command = cn1.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO CwSC (Cwiczenia_Nr_cwiczenia, Seria_cwiczen_Nr_Serii, Ilosc) VALUES (@exNum, @seNum, @count)";

                            command.Parameters.AddWithValue("@exNum", exID);
                            command.Parameters.AddWithValue("@seNum", seID);
                            command.Parameters.AddWithValue("@count", count);
                            cn1.Open();
                            int rowsAdded = command.ExecuteNonQuery();
                            if (rowsAdded > 0)
                                MessageBox.Show("Dodano serie!");
                            else
                                MessageBox.Show("Nie dodano serii");
                            cn1.Close();
                        }
                    }
                }
            }
            else //przy edycji
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
                //update serii
                string que = "UPDATE Seria_cwiczen SET Nazwa_serii= '" + textBox3.Text + "', Cwiczona_partia = '" + comboBox1.Text + "' WHERE Nazwa_serii='" + textBox3.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(que, cn);
                da.SelectCommand.ExecuteNonQuery();

                int temp = 0;// pomocnicza do nr cwiczenia
                cn.Close();
                foreach (ListViewItem items in listView2.Items)
                {

                    //nr cwiczenia
                    DataTable dt1 = new DataTable();
                    ListViewItem item = listView2.Items[temp];
                    string name = item.Text;
                    name = name.Trim();
                    //ilosc
                    string count = item.SubItems[1].Text;
                    if (count == "")
                    {
                        count = "0";
                    }
                    cn.Open();
                    string que4 = "Select Nr_cwiczenia from Cwiczenia where Nazwa like '" + name + "' ";
                    SqlDataAdapter da1 = new SqlDataAdapter(que4, cn);
                    da1.Fill(dt1);
                    cn.Close();
                    string exID = "0";
                    temp++;

                    foreach (DataRow dr in dt1.Rows)
                    {
                        exID = dr["Nr_cwiczenia"].ToString();
                    }


                    if (seID != "0" && exID != "0")
                    {
                        using (SqlConnection cn1 = new SqlConnection(conS))
                        using (SqlCommand command = cn1.CreateCommand())
                        {
                            command.CommandText = "UPDATE CwSC SET Ilosc = @count  WHERE Seria_cwiczen_Nr_Serii = @seNum and Cwiczenia_Nr_cwiczenia = @exNum ";

                            command.Parameters.AddWithValue("@exNum", exID);
                            command.Parameters.AddWithValue("@seNum", seID);
                            command.Parameters.AddWithValue("@count", count);
                            cn1.Open();
                            command.ExecuteNonQuery();
                            int rowsAddedU = command.ExecuteNonQuery();
                            cn1.Close();
                            // Let's ask the db to execute the query

                            if (rowsAddedU <= 0)
                            {

                                command.CommandText = "INSERT INTO CwSC (Cwiczenia_Nr_cwiczenia, Seria_cwiczen_Nr_Serii, Ilosc) VALUES (@exNum1, @seNum1, @count1)";

                                command.Parameters.AddWithValue("@exNum1", exID);
                                command.Parameters.AddWithValue("@seNum1", seID);
                                command.Parameters.AddWithValue("@count1", count);
                                cn1.Open();
                                command.ExecuteNonQuery();
                                cn1.Close();
                            }
                        }
                    }

                }
                MessageBox.Show("Zapisano zmiany");
                edit = 0;

            }

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
            showBase();
        }

        private void button1_Click(object sender, EventArgs e) //edytuj
        {
            edit = 1;
            int pom1;
            bool isNumeric = int.TryParse(textBox1.Text, out pom1);

            if (isNumeric)
            {
                //załadowanie danych o serii  
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT Seria_cwiczen.Nazwa_serii,Cwiczenia.Nazwa,Seria_cwiczen.Cwiczona_partia, CwSC.Ilosc from Seria_cwiczen JOIN CwSC on Seria_cwiczen.Nr_Serii = CwSC.Seria_cwiczen_Nr_Serii JOIN Cwiczenia on Cwiczenia.Nr_cwiczenia = CwSC.Cwiczenia_Nr_cwiczenia WHERE Seria_cwiczen.Nr_Serii = '" + textBox1.Text + "'", cn);
                if (da1.Fill(dt1) != 0)
                {
                    this.splitContainer1.Panel2.Show();
                    this.splitContainer1.Panel2Collapsed = false;
                    exInCombo();

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
                else
                {
                    MessageBox.Show("Podano błędny index");
                    textBox1.Clear();
                }
                   
            }
            else
            {
                MessageBox.Show("Podano błędny index");
                textBox1.Clear();
            }
        }
        private void button7_Click(object sender, EventArgs e) //usuń
        {

            int pom;
            bool isNumeric = int.TryParse(textBox2.Text, out pom);


            if (!Regex.IsMatch(textBox2.Text, @"^\d*[1-9]\d*$") || !isNumeric)
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
