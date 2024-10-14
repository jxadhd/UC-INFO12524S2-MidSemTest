namespace IncomeTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double rate1 = 0.1f;
        const double rate2 = 0.15f;
        const double rate3 = 0.25f;
        const double rate4 = 0.3f;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Top level if-else for inputval
            if(double.TryParse(txtInput.Text, out double income))
            {
                double rate = 0;
                if(income <= 10000)
                {
                    rate = rate1;
                }
                else if(income <= 50000)
                {
                    rate = rate2;
                }
                else if(income <= 100000)
                {
                    rate = rate3;
                }
                else
                {
                    rate = rate4;
                }
                double tax = income * rate;
                txtOutput.Text = tax.ToString("C");
            }
            else
            {
                MessageBox.Show("Invalid input, sorry!", "Error");
            }
        }
    }
}