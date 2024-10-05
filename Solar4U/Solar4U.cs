/* Student Name: Saurabveer Singh
 * Student ID: 24239833
 * Date:04/10/2024
 * Assignment: 1
 * Assignment: Create a form App that can be used by sales representatives to calculate 
 * quotations for prospective clients while also being able to generate summary of all quotes generated
 */

namespace Solar4U
{
    public partial class Solar4U : Form
    {
        // Global Variable to keep track of number of quotes
        private int numOfQuotes = 0;

        // Global Variable to keep track of total quotes
        private double panelsTotal, batteriesTotal, invertorsTotal, installationsTotal = 0;

        // Global Constants, to avoid reinitiation of constant variables on every function call.
        const double PanelCost = 119.50;
        const double BatteryCost = 568.75;
        const double InvertorCost = 224.00;
        const double InstallationCost = 499.00;

        // Default Constructor Function
        public Solar4U()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        // Used to Initialize heavy components separately to improve form loading time.
        private void InitializeCustomComponents()
        {
            logoImage.Image = Properties.Resources.logo;
        }

        // On Click handler for Enter Button on Sales Rep Login Page
        private void EnterButton_Click(object sender, EventArgs e)
        {
            // If the inputs are not empty, then user is taken to next page
            if (salesRepTextBox.Text == "")
            {
                MessageBox.Show("Sales Rep Input Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quoteIdTextBox.Text == "")
            {
                MessageBox.Show("Quote ID Input Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Switch page within same for using panel visibilty 
                salesRepPanel.Visible = false;
                quotePanel.Visible = true;
                optionsPanel.Visible = true;

                // Reusing same picturebox for another page with change in location and size
                logoImage.Location = new Point(450, 1250);
                logoImage.Size = new Size(300, 300);
            }
        }

        //On Click handler for Quote Button
        private void QuoteButtonClickHandler(object sender, EventArgs e)
        {
            // Initiate the variables with error handling function.
            int panels = ParseIntegerInput("Solar Panels", panelsTextBox.Text);
            int batteries = ParseIntegerInput("Batteries", batteriesTextBox.Text);
            int invertors = ParseIntegerInput("Invertors", invertorsTextBox.Text);

            // A less than zero value returned from the fetch input function denotes an error conveyed to user.
            if (panels < 0 || batteries < 0 || invertors < 0) return;

            // All values cannot be zero to request a quotation
            if (panels == 0 && batteries == 0 && invertors == 0)
            {
                MessageBox.Show("Please request a quotation for atleast one item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // This function is stopped at this point in case of an error to allow user make input corrections.

            // Disable quote button to prevent multiple clicks
            ToggleQuotesInput(false);

            // Calculate Quote
            CalculateQuote(panels, batteries, invertors);

            // Display information relavent to the quote Summary.
            ToggleQuotesAverageSummary(false);
        }

        // A method utilized to remove redundancy when parsing int values from strings.
        private int ParseIntegerInput(string inputName, string inputValue)
        {
            int value = -1;

            try
            {
                // Text inputs are stored in numerical form
                value = int.Parse(inputValue);
            }
            catch (Exception ex)
            {
                // Provides feedback to the user
                MessageBox.Show($"Please enter numerical data for {inputName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Provides additional details for developers
                Console.WriteLine($"Error while updating variable for {inputName} based on user input \n Details: {ex.Message}");

                // Returns a negative number if the user was shown an error.
                return -1;
            }

            // Handles negative numbers as an error.
            if (value < 0)
            {
                MessageBox.Show($"Please enter positive numerical value for {inputName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return value;
        }

        // Used to toggle between active and inactive status for elements in Quotation Panel.
        public void ToggleQuotesInput(bool isActive)
        {
            // Disables the quote button in options panel to avoid multiple clicks
            quoteButton.Enabled = isActive;

            // Disables label and turns fonts to darker colors in quotes panel
            quoteLabel.Enabled = isActive;
            panelsLabel.Enabled = isActive;
            batteriesLabel.Enabled = isActive;
            invertorsLabel.Enabled = isActive;

            // Disable Inputs such that user cannot change entered values to be used for reviewing quote
            panelsTextBox.Enabled = isActive;
            batteriesTextBox.Enabled = isActive;
            invertorsTextBox.Enabled = isActive;
        }

        // Used to calculate Quotes and update the form information.
        public void CalculateQuote(int panels, int batteries, int invertors)
        {
            // Increments total number of quotes recieved
            numOfQuotes++;

            // Calculate cost of each equipment
            double panelsCostVal = (double)PanelCost * panels;
            double batteriesCostVal = (double)BatteryCost * batteries;
            double invertorsCostVal = (double)InvertorCost * invertors;
            double installationCostVal = InstallationCost;
            double totalCostVal = panelsCostVal + batteriesCostVal + invertorsCostVal + installationCostVal;

            // Update information in Quote Summary
            panelsCost.Text = $"€{panelsCostVal}";
            batteriesCost.Text = $"€{batteriesCostVal}";
            invertorsCost.Text = $"€{invertorsCostVal}";
            installationCost.Text = $"€{installationCostVal}";
            totalCost.Text = $"€{totalCostVal}";
            panelsPercentage.Text = $"{Math.Round((double)(panelsCostVal * 100) / totalCostVal, 2)}%";
            batteriesPercentage.Text = $"{Math.Round((double)(batteriesCostVal * 100) / totalCostVal, 2)}%";
            invertorsPercentage.Text = $"{Math.Round((double)(invertorsCostVal * 100) / totalCostVal, 2)}%";
            installationPercentage.Text = $"{Math.Round((double)(installationCostVal * 100) / totalCostVal, 2)}%";

            // Update Total Costs
            panelsTotal += panelsCostVal;
            batteriesTotal += batteriesCostVal;
            invertorsTotal += invertorsCostVal;
            installationsTotal += installationCostVal;

            // Enables the summary Button in presence of more than one Quote.
            summaryButton.Enabled = true;
        }

        // Used to toggle between Quote Summary and Quote Average Summary in the Form
        private void ToggleQuotesAverageSummary(bool isAverage)
        {
            // Switch summary heading as per relavence.
            summaryLabel.Text = isAverage ? "Quote Average Summary" : "Quote Summary";

            // Show Total quotes recieved on Average Quote Summary.
            totalQuotesLabel.Visible = isAverage;
            totalQuotes.Visible = isAverage;

            // Show average quote on Average Quote Summary
            averageQuoteLabel.Visible = isAverage;
            averageQuoteValue.Visible = isAverage;

            // Hide percentages on Average Quote Summary
            panelsPercentage.Visible = !isAverage;
            batteriesPercentage.Visible = !isAverage;
            invertorsPercentage.Visible = !isAverage;
            installationPercentage.Visible = !isAverage;

            // Display the results to the user
            summaryPanel.Visible = true;
        }

        // Used to reset the form while keeping historical data safe.
        private void ClearButtonClickHandler(object sender, EventArgs e)
        {
            // Enable previously disabled buttons with the exception of summary button if there are no quotes
            summaryButton.Enabled = true;

            // Disable clear button to prevent multiple clicks
            clearButton.Enabled = false;

            // Resets Quotes inputs.
            ToggleQuotesInput(true);

            // Clear out user's previously entered values
            ClearInputs();

            // Switch page within same for using panel visibilty
            quotePanel.Visible = false;
            optionsPanel.Visible = false;
            summaryPanel.Visible = false;
            salesRepPanel.Visible = true;

            // Reusing same picturebox for another page with change in location and size
            logoImage.Location = new Point(337, 280);
            logoImage.Size = new Size(500, 500);

            // Renable clear button after page is switched
            clearButton.Enabled = true;
        }

        // Used to clear all input fields
        private void ClearInputs()
        {
            salesRepTextBox.Clear();
            quoteIdTextBox.Clear();
            panelsTextBox.Clear();
            batteriesTextBox.Clear();
            invertorsTextBox.Clear();
        }

        // Enables user to view Average Quotes Summary
        private void SummaryButtonClickHandler(object sender, EventArgs e)
        {
            // Disable summary button to prevent multiple clicks.
            summaryButton.Enabled = false;

            // Hides the quotation input panel
            quotePanel.Visible = false;

            // Updates form information for Average Summary of Quotes
            totalQuotes.Text = $"{numOfQuotes}";
            panelsCost.Text = $"€{(int)panelsTotal}";
            batteriesCost.Text = $"€{(int)batteriesTotal}";
            invertorsCost.Text = $"€{(int)invertorsTotal}";
            installationCost.Text = $"€{(int)installationsTotal}";
            int totalCostValue = (int)panelsTotal + (int)batteriesTotal + (int)invertorsTotal + (int)installationsTotal;
            totalCost.Text = $"€{totalCostValue}";
            averageQuoteValue.Text = $"€{totalCostValue / numOfQuotes}";

            // Displays Quotes Average Summary
            ToggleQuotesAverageSummary(true);
        }

        // Enables User to Quit the App
        private void ExitButtonClickHandler(object sender, EventArgs e)
        {
            // Disable exit button to prevent multiple clicks
            exitButton.Enabled = false;

            // Closes the Form Application
            Application.Exit();
        }
    }
}
