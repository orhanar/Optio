namespace Optio
{
    public partial class Count : Form
    {
        public Count()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int firstNumber, lastNumber = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txtStartFrom.Text);
            lastNumber = Convert.ToInt32(txtTo.Text);
            MessageBox.Show("From " + firstNumber + " To " + lastNumber);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}