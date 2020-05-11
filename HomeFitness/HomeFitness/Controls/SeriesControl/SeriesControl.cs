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

namespace HomeFitness.Controls.SeriesControl
{
    public partial class SeriesControl : UserControl
    {
       
        public SeriesControl()
        {
            InitializeComponent();
           string conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
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
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pojawianie/znikanie
            if (splitContainer1.Panel2.Visible)
            {
                this.splitContainer1.Panel2.Hide();
                this.splitContainer1.Panel2Collapsed = true;
            }
            else
            {
                this.splitContainer1.Panel2.Show();
                this.splitContainer1.Panel2Collapsed = false;

            }


            //cwiczenia
            string conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
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
            ListViewItem item = new ListViewItem(comboBox2.Text);
            item.SubItems.Add(label7.Text);
            listView2.Items.Add(item);
            comboBox3.Items.Add(comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Items.Remove(comboBox3.Text);
            comboBox3.Items.Remove(comboBox3.Text);
          
        }
    }
}
