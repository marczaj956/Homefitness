using HomeFitness.Controls.AchPanel;
using HomeFitness.Controls.MainPanel;
using HomeFitness.Controls.SeriesControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFitness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new MainControl());
        }

        private void cwiczeniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cwiczeniaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDataSet.Cwiczenia' table. You can move, or remove it, as needed.
            this.cwiczeniaTableAdapter.Fill(this.bazaDataSet.Cwiczenia);

        }

        private void cwiczeniaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cwiczeniaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new SeriesControl());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRozpocznijTrening_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new StartTraningControl());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Ach());

           

        }

        private void dodajĆwiczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kontrolujWageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new Ach());

           
        }
    }
}
