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

namespace HomeFitness.Controls.MainPanel
{
    public partial class MainControl : UserControl
    {
        string conS1;
        int c=0;
        
        public MainControl()
        {
            InitializeComponent();
            conS1 = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
            najblizszytrening();
           
        }
        private void najblizszytrening () // poka poka baze mi
        {
            int c = 0;
            SqlConnection cn = new SqlConnection(conS1);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Plan_treningu order by Dzien asc", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (c == 0)
                {
                    ListViewItem item = new ListViewItem(dr["Dzien"].ToString());
                    item.SubItems.Add(dr["godzina"].ToString());


                    listView1.Items.Add(item);
                }
                c++;
            }
    
            cn.Close();
         

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
