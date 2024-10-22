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
        private int totalQuotes, totalPanels, totalBatteries, totalInvertors = 0;

        // Global Constants, to avoid reinitiation of constant variables on every function call.
        const decimal PANEL_COST = 119.50m, BATTERY_COST = 568.75m, INVERTOR_COST = 224m, INSTALLATION_COST = 499m;

        // Default Constructor Function
        public Solar4U()
        {
            InitializeComponent();
        }

        // Used to Initialize heavy components separately to improve form loading time.
        private void Solar4UOnLoad(object sender, EventArgs e)
        {
            logoImage.Image = Properties.Resources.logo;
        }

        // On Click handler for Enter Button on Sales Rep Login Page
        private void EnterButtonClickHandler(object sender, EventArgs e)
        {
            // If the inputs are not empty, then user is taken to next page
            if (salesRepTextBox.Text == "")
            {
                DisplayError("Sales Rep Input Required");
            }
            else if (quoteIdTextBox.Text == "")
            {
                DisplayError("Quote ID Input Required");
            }
            else
            {
                // Switch page within same form using panel visibilty 
                salesRepPanel.Visible = false;
                quotePanel.Visible = true;
                optionsPanel.Visible = true;

                // Reusing same picturebox for another page with change in location and size
                logoImage.Location = new Point(450, 1250);
                logoImage.Size = new Size(300, 300);

                // Change Form Heading
                this.Text = $"Data Entry for Sales Rep: {salesRepTextBox.Text} Quote ID: {quoteIdTextBox.Text}";

                // Highlight First Input box on new page
                HighlightInput(panelsTextBox);
            }
        }

        //Displays Error Box
        private void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Focuses on a text box selects all text to give user visual cues.
        private void HighlightInput(TextBox textBox)
        {
            textBox.SelectAll();
            textBox.Focus();
        }

        //On Click handler for Quote Button
        private void QuoteButtonClickHandler(object sender, EventArgs e)
        {
            // Initiate the variables with error handling function.
            // A less than zero value returned from the fetch input function denotes an error conveyed to user.
            int panels = ParseIntegerInput("Solar Panels", panelsTextBox);
            if (panels < 0) return;
            int batteries = ParseIntegerInput("Batteries", batteriesTextBox);
            if (batteries < 0) return;
            int invertors = ParseIntegerInput("Invertors", invertorsTextBox);
            if (invertors < 0) return;

            // All values cannot be zero to request a quotation
            if (panels == 0 && batteries == 0 && invertors == 0)
            {
                DisplayError("Please request a quotation for atleast one item");
                HighlightInput(panelsTextBox);
                return;
            }
            // This function is stopped before this point in case of an error to allow user make input corrections.

            // Disable quote button to prevent multiple clicks
            ToggleQuotesInput(false);

            // Calculate Quote
            CalculateQuote(panels, batteries, invertors);

            // Display information relavent to the quote Summary.
            ToggleQuotesAverageSummary(false);
        }

        // A method utilized to remove redundancy when parsing int values from strings.
        private int ParseIntegerInput(string inputName, TextBox textBox)
        {
            string inputValue = textBox.Text;
            int value = -1;

            try
            {
                // Text inputs are stored in numerical form
                value = int.Parse(inputValue);
                // Handles negative numbers as an error.
                if (value < 0) throw new ArgumentException($"{inputName} cannot be less than zero", nameof(value));
            }
            catch (Exception ex)
            {
                // Provides feedback to the user
                DisplayError($"Please enter valid numerical value for {inputName}");

                // Provides additional details for developers
                Console.WriteLine($"Error while updating variable for {inputName} based on user input \n Details: {ex.Message}");

                // Focus on the source of the error.
                HighlightInput(textBox);

                // Returns a negative number if the user was shown an error.
                return -1;
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

            // Calculate cost of each equipment
            decimal panelsCostVal = PANEL_COST * panels;
            decimal batteriesCostVal = BATTERY_COST * batteries;
            decimal invertorsCostVal = INVERTOR_COST * invertors;
            decimal totalCostVal = panelsCostVal + batteriesCostVal + invertorsCostVal + INSTALLATION_COST;

            // Update information in Quote Summary
            panelsCost.Text = panelsCostVal.ToString("C2");
            batteriesCost.Text = batteriesCostVal.ToString("C2");
            invertorsCost.Text = invertorsCostVal.ToString("C2");
            installationCost.Text = INSTALLATION_COST.ToString("C2");
            totalCost.Text = totalCostVal.ToString("C2");
            panelsPercentage.Text = (panelsCostVal / totalCostVal).ToString("P2");
            batteriesPercentage.Text = (batteriesCostVal / totalCostVal).ToString("P2");
            invertorsPercentage.Text = (invertorsCostVal / totalCostVal).ToString("P2");
            installationPercentage.Text = (INSTALLATION_COST / totalCostVal).ToString("P2");

            // Update Total Quotes
            totalQuotes++;
            totalPanels += panels;
            totalBatteries += batteries;
            totalInvertors += invertors;

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
            totalQuotesValue.Visible = isAverage;

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
            // Disable clear button to prevent multiple clicks
            clearButton.Enabled = false;

            // Enable previously disabled buttons with the exception of summary button if there are no quotes
            summaryButton.Enabled = totalQuotes != 0;

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

            // Move Cursor to sales rep input box
            salesRepTextBox.Focus();
        }

        // Used to clear all input fields
        private void ClearInputs()
        {
            salesRepTextBox.Clear();
            quoteIdTextBox.Clear();
            panelsTextBox.Text = "0";
            batteriesTextBox.Text = "0";
            invertorsTextBox.Text = "0";
        }

        // Enables user to view Average Quotes Summary
        private void SummaryButtonClickHandler(object sender, EventArgs e)
        {
            // Disable summary button to prevent multiple clicks.
            summaryButton.Enabled = false;

            // Hides the quotation input panel
            quotePanel.Visible = false;

            // Updates form information for Average Summary of Quotes
            int totalPanelsCost = (int)(totalPanels * PANEL_COST);
            int totalBatteriesCost = (int)(totalBatteries * BATTERY_COST);
            int totalInvertorsCost = (int)(totalInvertors * INVERTOR_COST);
            int totalQuotesCost = (int)(totalQuotes * INSTALLATION_COST);
            // Rounding off before adding prevents deviation in sum.
            int totalCostValue = totalPanelsCost + totalBatteriesCost + totalInvertorsCost + totalQuotesCost;

            totalQuotesValue.Text = totalQuotes.ToString("N0");
            panelsCost.Text = totalPanelsCost.ToString("C0");
            batteriesCost.Text = totalBatteriesCost.ToString("C0");
            invertorsCost.Text = totalInvertorsCost.ToString("C0");
            installationCost.Text = totalQuotesCost.ToString("C0");
            totalCost.Text = totalCostValue.ToString("C0");
            averageQuoteValue.Text = (totalCostValue / totalQuotes).ToString("C0");

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
