using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFitness.Controls.SeriesControl
{
    public partial class SeriesControl : UserControl
    {
        public SeriesControl()
        {
            InitializeComponent();
            this.splitContainer1.Panel2.Hide();
            this.splitContainer1.Panel2Collapsed = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
            

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e) //dodaj nowa serie
        {
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) //suwak wyznaczanie ilosci
        {
            label8.Text = trackBar1.Value.ToString();
        }

        private void label8_Click(object sender, EventArgs e) // ilosc
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
