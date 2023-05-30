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
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("10");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int firstNumber, lastNumber = 0;
        int divisibleTerm = 1;
        private void btnCount_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(txtStartFrom.Text);
            lastNumber = Convert.ToInt32(txtTo.Text);
            MessageBox.Show("Divisible Term" + divisibleTerm + "From " + firstNumber + " To " + lastNumber);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);

        }
    }
}