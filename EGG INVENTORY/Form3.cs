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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("Box");
            Console.WriteLine("Trays");
            Console.WriteLine("Pieces");
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }
    }
}

