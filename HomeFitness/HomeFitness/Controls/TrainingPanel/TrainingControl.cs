using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeFitness.bazaDataSetTableAdapters;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HomeFitness.Controls.TrainingPanel
{
    public partial class TrainingControl : UserControl
    {
        int x;
        int x1;
        string conS;
        Stopwatch stopwatch = new Stopwatch();
        int i = 0;
        private Panel _mainPanel1;
        public TrainingControl()
        {
            InitializeComponent();
           
        }
        public TrainingControl(Panel mainPanel,string u, string a)
        {
            InitializeComponent();
            x = Convert.ToInt32(u);
            x1 = Convert.ToInt32(a);
           
                _mainPanel1 = mainPanel;
                conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
                pokabaze();
                textBox1.Text = listView1.Items[i].SubItems[1].Text;
                stopwatch.Start();
           
        }
      
            private void pokabaze() // poka poka baze mi
        {
                 
            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from cwiczenia where Cwiczenia.Nazwa in (select   nazwa  from Cwiczenia as cw join CwSC on cw.Nr_cwiczenia = CwSC.Cwiczenia_Nr_cwiczenia join SCT on CwSC.Seria_cwiczen_Nr_Serii =SCT.Seria_cwiczen_Nr_Serii join Plan_treningu on Plan_treningu.Treningi_Nr_treningu=sct.Treningi_Nr_treningu where Plan_treningu.Treningi_Nr_treningu='" +x1 +"' group by nazwa)", cn);
            da.Fill(dt);
          
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Nr_cwiczenia"].ToString());
                item.SubItems.Add(dr["Nazwa"].ToString());
                item.SubItems.Add(dr["Spalone_Kalorie"].ToString());
                item.SubItems.Add(dr["Cwiczone_Miesnie"].ToString());
                item.SubItems.Add(dr["Opis"].ToString());
                item.SubItems.Add(dr["Zalecana_ilosc"].ToString());
                listView1.Items.Add(item);
            }
           
            cn.Close();
        }


        private void btnSTOP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trening został zakończony");
            _mainPanel1.Controls.Clear();
            _mainPanel1.Controls.Add(new StartTraningControl(_mainPanel1));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrainingControl_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= listView1.Items.Count - 1)
            {

                textBox1.Text = listView1.Items[i].SubItems[1].Text;

                if (i == listView1.Items.Count - 1)
                {
                    button1.Text = "zakoncz trening";
                }
            }
            else
            {
                button1.Hide();
                stopwatch.Stop();
                var milliSeocnds = stopwatch.ElapsedMilliseconds;
                var timeSpan = stopwatch.Elapsed;
                MessageBox.Show("Twój trening trwał: "+(milliSeocnds / 1000).ToString()+ " sekund(y).");
               
                SqlConnection cn = new SqlConnection(conS);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("DELETE from Plan_treningu WHERE Nr_Planu='" + x + "' ", cn);
                da.SelectCommand.ExecuteNonQuery();
                int kcal = 0;
                foreach(ListViewItem item in listView1.Items)

                {
                    kcal += Convert.ToInt32(item.SubItems[2].Text)* Convert.ToInt32(item.SubItems[5].Text);
                }
                
                SqlDataAdapter dc = new SqlDataAdapter("INSERT INTO Czas (czas.czas,kalorie) VALUES('" + (milliSeocnds/1000).ToString() + "','" + kcal.ToString() + "')", cn);
                dc.SelectCommand.ExecuteNonQuery();

                cn.Close();
               
                
            }
          
        }





       
       
    }

}

