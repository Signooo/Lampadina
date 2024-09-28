namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
