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
            using (var adapter = new CwiczeniaTableAdapter())
            {
                using (bazaDataSet.CwiczeniaDataTable dt = new bazaDataSet.CwiczeniaDataTable())
                {
                    adapter.Fill(dt);

                    // Kolega sie pomylil
                    dt.Columns["Zalecana_ilosc"].ColumnName = "Zalecana liczba";

                    dt.Columns.RemoveUnderscoreFromColumns();

                    dgvTrainings.DataSource = dt;
                }
            }
            
        }

    }
}
