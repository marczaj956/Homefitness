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

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
