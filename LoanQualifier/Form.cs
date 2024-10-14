namespace LoanQualifier
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Global constants, in caps as always ;)
        const int MIN_SALARY = 40000;
        const int MIN_JOB_TIME = 2;
        const float LOAN_ALLOWED = 0.2f;

        public Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQualify_Click(object sender, EventArgs e)
        {
            // Error strings
            string salError = "Your Salary Amount is either empty or contains invalid input";
            string jobError = "Your Years Employed is either empty or contains invalid input";

            // Initialise int variables to store salary and job
            int salary = 0;
            int job = 0;

            // Failure string
            string failure = "Your salary is below the minimum level, or your have not been employed long enough";

            // Input validation and Parse Text fields to int
            if (int.TryParse(txtSalary.Text, out salary))
            {
                if (int.TryParse(txtYearsEmployed.Text, out job))
                {
                    if (salary >= MIN_SALARY && job >= MIN_JOB_TIME)
                    {
                        // Calculate loan amount and tell the user
                        float qualified = salary * LOAN_ALLOWED;
                        string success = $"You qualify for a loan up to {qualified:C}";
                        MessageBox.Show(success, "Success!");
                    }
                    else
                    {
                        // Break the bad news to the user
                        MessageBox.Show(failure, "Bad news :(");
                    }
                }
                else
                {
                    MessageBox.Show(jobError, "Error :(");
                }
            }
            else
            {
                MessageBox.Show(salError, "Error :(");
            }
        }
    }
}