namespace InvestmentCalc
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear the listbox to prevent duplicate and excessive outputs
            lbxOutput.Items.Clear();

            // Declare constants - method constants in Capital Case :)
            const int Monthly = 100;
            const float Interest = 0.05f;
            const int Periods = 6;

            // Initialise variables
            float savings = 0.0f;
            float interest_monthly = Interest / 12;

            // Loops through, totals and outputs to lbxOutput the savings info!
            for (int i = 1; i <= Periods; i++)
            {
                savings += Monthly;
                savings *= (1 + interest_monthly);
                lbxOutput.Items.Add($"Month {i}: {savings:C}");
            }
            lbxOutput.Items.Add($"Total savings after 6 months: {savings:C}");
        }
    }
}