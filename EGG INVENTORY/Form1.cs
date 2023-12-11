namespace EGG_INVENTORY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = this.textBox1.Text;
            pass = this.textBox2.Text;

            // For demonstration purposes, checking against hardcoded credentials
            if (user == "Query" && pass == "typewriter")
            {
                MessageBox.Show("Successful!");

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
