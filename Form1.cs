namespace TP3_1302210097
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputan = textBox1.Text;
            label1.Text = "Konniciwa, " + inputan;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}