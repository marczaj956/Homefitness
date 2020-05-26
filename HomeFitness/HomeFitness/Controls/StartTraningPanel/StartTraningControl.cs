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

namespace HomeFitness
{
    public partial class StartTraningControl : UserControl
    {
        private string _mojaZmienna = "";

        public StartTraningControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            using (var adapter = new Plan_treninguTableAdapter())
            {
                using (bazaDataSet.Plan_treninguDataTable dt = new bazaDataSet.Plan_treninguDataTable())
                {
                    //adapter.Fill(dt);

                    
                

                   

                    dgvTrainings.DataSource = dt;
                }
            }
            
        }

        private void dgvTrainings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRozpocznijTrening_Click(object sender, EventArgs e)
        {
            
          
        }

        private void StartTraningControl_Load(object sender, EventArgs e)
        {

        }
    }
}
