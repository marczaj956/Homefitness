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

namespace HomeFitness.Controls.Trening
{
    public partial class Trening_click : UserControl
    {

        //zmienna do zapisu edytowanych
        int edit;
        //zmienna do połączenia z bazą
        string conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;

        public Trening_click()
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
            SqlDataAdapter da = new SqlDataAdapter("Select * from Treningi", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_treningu"].ToString());
                item.SubItems.Add(dr["Nazwa"].ToString());
                item.SubItems.Add(dr["Stopien_Zaawansowania"].ToString());
                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void serInCombo()
        {

            //cwiczenia
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Seria_cwiczen", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox4.Items.Add(dr["Nazwa_serii"].ToString());


            }
            cn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pojawianie
            this.splitContainer1.Panel2.Show();
            this.splitContainer1.Panel2Collapsed = false;

            serInCombo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int exist = 0;
            foreach (ListViewItem item in listView2.Items) //spr czy jest juz takie cwiczenie
            {
                if (item.Text == comboBox4.Text)
                {
                    exist = 1;

                }
            }

            if (exist != 1 && comboBox4.Text != "")
            {
                ListViewItem item1 = new ListViewItem(comboBox4.Text);

                listView2.Items.Add(item1);
                comboBox3.Items.Add(comboBox4.Text);
                comboBox4.SelectedIndex = -1;

            }
            else if (exist == 1)
            {
                MessageBox.Show("Istniejąca seria");
            }
            else
            {
                MessageBox.Show("Sprawdź czy wszystkie pola są poprawnie wypełnione");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView2.Items)
            {
                if (item.Text == comboBox3.Text)
                    listView2.Items.Remove(item);
            }

            comboBox3.Items.Remove(comboBox3.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            string name = textBox2.Text;
            name.Trim();
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt2 = new DataTable();
            string que1 = "Select Nr_treningu from Treningi where Nazwa like '" + textBox2.Text + "' ";
            SqlDataAdapter da2 = new SqlDataAdapter(que1, cn);
            if (da2.Fill(dt2) < 2)
            {


                if (edit == 0 && textBox2.Text != "" && comboBox5.Text != "" && listView2.Items.Count != 0)
                {



                    string part = comboBox5.Text;

                    using (SqlConnection cn1 = new SqlConnection(conS))
                    using (SqlCommand command = cn1.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Treningi (Nazwa, Stopien_Zaawansowania) VALUES(@name, @part)";

                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@part", part);
                        cn1.Open();
                        command.ExecuteNonQuery();
                        cn1.Close();
                    }


                    DataTable dt6 = new DataTable();
                    string que6 = "Select Nr_treningu from Treningi where Nazwa like '" + textBox2.Text + "' ";
                    SqlDataAdapter da6 = new SqlDataAdapter(que6, cn);
                    da6.Fill(dt6);
                    string seID = "0";
                    foreach (DataRow dr in dt6.Rows)
                    {
                        seID = dr["Nr_treningu"].ToString();
                    }
                    cn.Close();



                    int temp = 0;
                    foreach (ListViewItem items in listView2.Items)
                    {

                        DataTable dt1 = new DataTable();
                        ListViewItem item = listView2.Items[temp];
                        string nameex = item.Text;
                        nameex = nameex.Trim();


                        string que = "Select Nr_Serii from Seria_cwiczen where Nazwa_serii like '" + nameex + "' ";
                        SqlDataAdapter da1 = new SqlDataAdapter(que, cn);
                        da1.Fill(dt1);
                        string exID = "0";
                        temp++;

                        foreach (DataRow dr in dt1.Rows)
                        {
                            exID = dr["Nr_Serii"].ToString();
                        }

                        if (seID != "0" && exID != "0")
                        {

                            using (SqlConnection cn1 = new SqlConnection(conS))
                            using (SqlCommand command = cn1.CreateCommand())
                            {
                                command.CommandText = "INSERT INTO SCT (Seria_cwiczen_Nr_Serii,Treningi_Nr_treningu) VALUES (@exNum,@seNum)";

                                command.Parameters.AddWithValue("@exNum", exID);
                                command.Parameters.AddWithValue("@seNum", seID);

                                cn1.Open();
                                int rowsAdded = command.ExecuteNonQuery();
                                if (rowsAdded > 0)
                                {
                                    refresh();
                                    MessageBox.Show("Dodano trening!");
                                }
                                else
                                    MessageBox.Show("Nie dodano treningu");
                                cn1.Close();
                            }
                        }
                    }
                }
                else //przy edycji
                {


                    DataTable dt5 = new DataTable();
                    string que5 = "Select Nr_treningu from Treningi where Nazwa like '" + name + "' ";
                    SqlDataAdapter da5 = new SqlDataAdapter(que5, cn);
                    da5.Fill(dt5);
                    string seID = "0";
                    foreach (DataRow dr in dt5.Rows)
                    {
                        seID = dr["Nr_treningu"].ToString();
                    }
                    //update serii
                    string que = "UPDATE Treningi SET Nazwa= '" + textBox2.Text + "', Stopien_Zaawansowania = '" + comboBox5.Text + "' WHERE Nazwa='" + textBox2.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(que, cn);
                    da.SelectCommand.ExecuteNonQuery();

                    int temp = 0;
                    cn.Close();
                    foreach (ListViewItem items in listView2.Items)
                    {


                        DataTable dt1 = new DataTable();
                        ListViewItem item = listView2.Items[temp];
                        string name1 = item.Text;
                        name1 = name1.Trim();

                        cn.Open();
                        string que4 = "Select Nr_Serii from Seria_cwiczen where Nazwa_serii like '" + name1 + "' ";
                        SqlDataAdapter da1 = new SqlDataAdapter(que4, cn);
                        da1.Fill(dt1);
                        cn.Close();
                        string exID = "0";
                        temp++;

                        foreach (DataRow dr in dt1.Rows)
                        {
                            exID = dr["Nr_serii"].ToString();
                        }


                        if (seID != "0" && exID != "0")
                        {
                            using (SqlConnection cn1 = new SqlConnection(conS))
                            using (SqlCommand command = cn1.CreateCommand())
                            {

                                cn.Open();
                                string que7 = "Select Nr_Serii from Seria_cwiczen where Nazwa_serii like '" + name1 + "' ";
                                SqlDataAdapter da7 = new SqlDataAdapter(que7, cn);





                                if (da7.Fill(dt1) >= 1)
                                {
                                    cn.Close();

                                }
                                else
                                {
                                    cn.Close();
                                    command.CommandText = "INSERT INTO SCT (Seria_cwiczen_Nr_Serii,Treningi_Nr_treningu) VALUES (@exNum1,@seNum1)";

                                    command.Parameters.AddWithValue("@exNum1", exID);
                                    command.Parameters.AddWithValue("@seNum1", seID);

                                    cn1.Open();
                                    command.ExecuteNonQuery();
                                    cn1.Close();

                                }
                            }
                        }

                    }
                    MessageBox.Show("Zapisano zmiany");
                    textBox3.ReadOnly = false;
                    edit = 0;

                }

                clean();
                this.splitContainer1.Panel2.Hide();
                this.splitContainer1.Panel2Collapsed = true;
            }
            else
            {
                MessageBox.Show("Nazwy treningu nie mogą się powtarzać");
            }
        }
        private void clean()
        {
            listView2.Items.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void refresh() //odswiez
        {
            listView1.Items.Clear();
            showBase();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            edit = 1;
            int pom1;
            bool isNumeric = int.TryParse(textBox4.Text, out pom1);

            if (isNumeric)
            {

                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT Treningi.Nazwa,Seria_cwiczen.Nazwa_serii,Treningi.Stopien_Zaawansowania from Treningi JOIN SCT on Treningi.Nr_treningu = SCT.Treningi_Nr_treningu JOIN Seria_cwiczen on Seria_cwiczen.Nr_serii = SCT.Seria_cwiczen_Nr_Serii WHERE Treningi.Nr_treningu = '" + textBox4.Text + "'", cn);
                if (da1.Fill(dt1) != 0)
                {
                    this.splitContainer1.Panel2.Show();
                    this.splitContainer1.Panel2Collapsed = false;
                    serInCombo();

                    foreach (DataRow dr in dt1.Rows)
                    {
                        textBox2.Text = dr["Nazwa"].ToString();
                        comboBox5.Text = dr["Stopien_Zaawansowania"].ToString();
                        ListViewItem item = new ListViewItem(dr["Nazwa_serii"].ToString());
                        listView2.Items.Add(item);
                        comboBox3.Items.Add(dr["Nazwa_serii"].ToString());
                    }

                    cn.Close();
                    textBox2.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Podano błędny index");
                    textBox4.Clear();
                }

            }
            else
            {
                MessageBox.Show("Podano błędny index");
                textBox4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pom;
            bool isNumeric = int.TryParse(textBox3.Text, out pom);


            if (!Regex.IsMatch(textBox3.Text, @"^\d*[1-9]\d*$") || !isNumeric)
            {
                MessageBox.Show("Podano błędny index");
            }
            else
            {
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("DELETE from SCT WHERE Treningi_Nr_treningu='" + textBox3.Text + "'", cn);
                da.SelectCommand.ExecuteNonQuery();

                SqlDataAdapter da1 = new SqlDataAdapter("DELETE from Treningi WHERE Nr_treningu='" + textBox3.Text + "'", cn);
                da1.SelectCommand.ExecuteNonQuery();
                cn.Close();
                refresh();
                MessageBox.Show("Usunięto trening");
                textBox3.Text = "";

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
