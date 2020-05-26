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

namespace HomeFitness.Controls.TrainingPanel
{
    public partial class TrainingControl : UserControl
    {
        private Panel _mainPanel1;
        public TrainingControl()
        {
            InitializeComponent();
           
        }
        public TrainingControl(Panel mainPanel)
        {
            InitializeComponent();
            Init();
            _mainPanel1 = mainPanel;
        }

        private void Init()
        {
            using (var adapter = new TreningiTableAdapter())
            {
                using (bazaDataSet.TreningiDataTable dt = new bazaDataSet.TreningiDataTable())
                {
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
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
    }
}
