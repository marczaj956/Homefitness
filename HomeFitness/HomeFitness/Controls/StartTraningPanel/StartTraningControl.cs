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
        private string _mojaZmienna = "";
        private Panel _mainPanel;

        public StartTraningControl()
        {
            InitializeComponent();
            Init();
        }

        public void UpdateMainPanel(Panel panel)
        {

            // naucz sie wzorca DEPENDENCY INJECTION
            // razem z tym w parze idzie wzorzec IoT - Inversion of Control - czyli kontenery typu AUTOFAC
            if (panel == null) throw new ArgumentNullException("Panel can not be null or empty");
            _mainPanel = panel;
        }

        public StartTraningControl(Panel mainPanel)
        {
            InitializeComponent();
            Init();
            _mainPanel = mainPanel;
            int x = Init1();
        }
        private void Init()
        {
            using (var adapter = new Plan_treninguTableAdapter())
            {
                using (bazaDataSet.Plan_treninguDataTable dt = new bazaDataSet.Plan_treninguDataTable())
                {
                    
                    adapter.Fill(dt);

                    // bazy danych => Entity Framework 6  // NHibernate

                    var time = new TimeSpanConverter();

                    var res1 = dt.
                    Where(s => Convert.ToDateTime(s["Dzien"]) >= DateTime.Today
                        && ((TimeSpan)time.ConvertFromString((s["Godzina"].ToString())) >= DateTime.Now.TimeOfDay)).FirstOrDefault();

                    var res = dt.
                    Where(s =>  Convert.ToDateTime(s["Dzien"]) >= DateTime.Today
                        && ((TimeSpan)time.ConvertFromString((s["Godzina"].ToString())) >= DateTime.Now.TimeOfDay))
                    .Select(w => new { Data = w.Dzien, Godzina = w.Godzina, NrTreningu = w.Treningi_Nr_treningu})
                        .ToArray();

                    dgvTrainings.DataSource = res;
                    
                   
                }
            }
            
        }
        private int Init1()
        {
            using (var adapter = new Plan_treninguTableAdapter())
            {
                using (bazaDataSet.Plan_treninguDataTable dt = new bazaDataSet.Plan_treninguDataTable())
                {

                    adapter.Fill(dt);

                    // bazy danych => Entity Framework 6  // NHibernate

                    var time = new TimeSpanConverter();

                    var res1 = dt.
                    Where(s => Convert.ToDateTime(s["Dzien"]) >= DateTime.Today
                        && ((TimeSpan)time.ConvertFromString((s["Godzina"].ToString())) >= DateTime.Now.TimeOfDay)).FirstOrDefault();

                    var res = dt.
                    Where(s => Convert.ToDateTime(s["Dzien"]) >= DateTime.Today
                        && ((TimeSpan)time.ConvertFromString((s["Godzina"].ToString())) >= DateTime.Now.TimeOfDay))
                    .Select(w => new { Data = w.Dzien, Godzina = w.Godzina, NrTreningu = w.Treningi_Nr_treningu })
                        .ToArray();

                    dgvTrainings.DataSource = res;
                    return res1.Treningi_Nr_treningu;


                }
            }

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
    }
}
