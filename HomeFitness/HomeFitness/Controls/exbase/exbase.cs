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
namespace HomeFitness.Controls.exbase
{
    public partial class exbase : UserControl
    {
        SqlConnection connection;
        string conS;
        public exbase()
        {
            InitializeComponent();
            conS = ConfigurationManager.ConnectionStrings["HomeFitness.Properties.Settings.bazaConnectionString"].ConnectionString;

        }

        private void test()
        {
            using (connection = new SqlConnection(conS))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Cwiczenia", connection))
            {
                //DataTable exce = new DataTable();
                //adapter.Fill(exce);
                //listBox1.DisplayMember = "Nazwa";
                //listBox1.ValueMember = "Nr_cwiczenia";
                //listBox1.DataSource = exce;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
