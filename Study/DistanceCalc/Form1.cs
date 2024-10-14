namespace DistanceCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous results
            lstOutput.Items.Clear();

            // Initialise variables
            string inputerror = "Enter some fucking sensical numerical values would ya, clown!?";

            // Top level if-else for inout validation and Parseing of inferior input method
            if(double.TryParse(txtSpeed.Text, out double speed) && double.TryParse(txtHours.Text, out double hours))
            {
                for (int i = 1; i <= hours; i++)
                {
                    double distance = speed * i;
                    lstOutput.Items.Add($"After {i} hours at an average speed of {speed:F2}km/h, you will have travelled {distance:F2}km!");
                }
            }
            else
            {
                MessageBox.Show(inputerror, "Error!");
            }
        }

        private void txtHours_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.SuppressKeyPress=true;
            }
        }
    }
}