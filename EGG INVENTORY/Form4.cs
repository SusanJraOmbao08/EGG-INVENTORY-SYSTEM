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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("Box");
            Console.WriteLine("Double Yolk 48");
            Console.WriteLine("Jumbo");
            Console.WriteLine("32");
            Console.WriteLine("X Large");
            Console.WriteLine("24");
            Console.WriteLine("Large");
            Console.WriteLine("20");
            Console.WriteLine("Medium");
            Console.WriteLine("36");
            Console.WriteLine("9");
            Console.WriteLine("Small");
            Console.WriteLine("Update");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
