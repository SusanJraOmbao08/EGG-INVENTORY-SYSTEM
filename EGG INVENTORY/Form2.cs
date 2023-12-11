using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGG_INVENTORY
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Box", typeof(string));
            table.Columns.Add("Trays", typeof(string));
            table.Columns.Add("Pieces", typeof(string));
            table.Rows.Add(1, "First A", "Last A", 1);
            table.Rows.Add(2, "First B", "Last B", 2);
            table.Rows.Add(3, "First C", "Last C", 3);
            table.Rows.Add(4, "First D", "Last D", 4);
            table.Rows.Add(5, "First E", "Last E", 5);
            table.Rows.Add(6, "First F", "Last F", 6);
            table.Rows.Add(7, "First G", "Last G", 7);



        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form3 form3 = new Form3();

                form3.Show();

                this.Hide();
        }
    }
}
 
    

