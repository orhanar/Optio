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
        string divisibleNumber = "";
        int controlNumber = 0;
        private void btnCount_Click(object sender, EventArgs e)
        {
            if(txtStartFrom.Text.Trim()=="" || txtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
            txtDivisibleNumbers.Text = String.Empty;
            divisibleNumber = String.Empty;
            firstNumber = Convert.ToInt32(txtStartFrom.Text);
            lastNumber = Convert.ToInt32(txtTo.Text);
            for (int i = firstNumber; i < lastNumber; i++)
            {
                if (i % divisibleTerm == 0)
                {
                    divisibleNumber += i.ToString() + " ";
                    if (controlNumber % 10 == 0)
                    {
                        divisibleNumber += Environment.NewLine;
                    }
                    controlNumber++;
                }
            }
            txtDivisibleNumbers.Text = divisibleNumber;
            }

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

        private void txtDivisibleNumbers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}