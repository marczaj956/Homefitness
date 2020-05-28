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
using HomeFitness.Common;
using HomeFitness.Controls.TrainingPanel;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace HomeFitness
{
    
    public partial class StartTraningControl : UserControl
    {
        string conS;
        private string _mojaZmienna = "";
        private Panel _mainPanel;

        public StartTraningControl()
        {
            InitializeComponent();
            
        }

   

        public StartTraningControl(Panel mainPanel)
        {
            InitializeComponent();
            _mainPanel = mainPanel;
            conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;
            pokabaze();

        }


        private void pokabaze() // poka poka baze mi
        {

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Plan_treningu order by Dzien asc", cn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["Dzien"].ToString());
                item.SubItems.Add(dr["godzina"].ToString());
                item.SubItems.Add(dr["Treningi_Nr_treningu"].ToString());
              
                listView1.Items.Add(item);
            }
            cn.Close();
        }
        
           
        
       
        private void dgvTrainings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRozpocznijTrening_Click(object sender, EventArgs e)
        {
            
          _mainPanel.Controls.Clear();
            _mainPanel.Controls.Add(new TrainingControl(_mainPanel));

        }

        private void StartTraningControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
