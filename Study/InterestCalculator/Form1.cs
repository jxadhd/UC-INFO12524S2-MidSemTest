namespace InterestCalculator
{
    public partial class interestCalculator : Form
    {
        public interestCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear the list, in case user has not done it yet
            lbxBreakdown.Items.Clear();

            // Initalise variables
            
            // Top level if-else performs input validation and parsation
            if(float.TryParse(txtOpening.Text, out float opening) && float.TryParse(txtPeriods.Text, out float periods) && float.TryParse(txtRate.Text, out float annual))
            {
                float monthly = annual / periods;
                var balance = opening;

                // Loop through number of periods as 'month' and add up balance, compounding each period
                for(int month = 1; month <= periods; month++)
                {
                    balance += balance * monthly;
                    lbxBreakdown.Items.Add($"Month {month}: ${balance}");
                }

                txtClosing.Text = $"{balance:C}";
            }
            else
            {
                MessageBox.Show("Error! Please check input values.", "Error!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields and reset focus to first field
            txtOpening.Clear();
            txtPeriods.Clear();
            txtRate.Clear();
            txtClosing.Clear();
            lbxBreakdown.Items.Clear();
            txtOpening.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // User confirmation before closing the application
            if(MessageBox.Show("Are you sure you want to quit?", "Hang on!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                // Do nothing, clear the dialog
            }
        }
    }
}