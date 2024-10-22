namespace Solar4U
{
    partial class Solar4U
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solar4U));
            enterButton = new Button();
            salesRepPanel = new Panel();
            quoteIdTextBox = new TextBox();
            salesRepTextBox = new TextBox();
            quoteIdLabel = new Label();
            salesRepLabel = new Label();
            logoImage = new PictureBox();
            quotePanel = new Panel();
            quoteBottomLine = new Panel();
            invertorsTextBox = new TextBox();
            batteriesTextBox = new TextBox();
            panelsTextBox = new TextBox();
            invertorsLabel = new Label();
            batteriesLabel = new Label();
            panelsLabel = new Label();
            quoteLabel = new Label();
            quoteHeadingLine = new Panel();
            optionsPanel = new Panel();
            exitButton = new Button();
            summaryButton = new Button();
            clearButton = new Button();
            quoteButton = new Button();
            summaryPanel = new Panel();
            installationPercentage = new Label();
            invertorsPercentage = new Label();
            batteriesPercentage = new Label();
            panelsPercentage = new Label();
            averageQuoteValue = new Label();
            totalCost = new Label();
            installationCost = new Label();
            invertorsCost = new Label();
            batteriesCost = new Label();
            panelsCost = new Label();
            summaryBottomLine = new Panel();
            summaryMidLine = new Panel();
            summaryLabel = new Label();
            summaryHeadingLine = new Panel();
            totalQuotesValue = new Label();
            averageQuoteLabel = new Label();
            totalCostLabel = new Label();
            installationCostLabel = new Label();
            invertorsCostLabel = new Label();
            batteriesCostLabel = new Label();
            panelsCostLabel = new Label();
            totalQuotesLabel = new Label();
            toolTip = new ToolTip(components);
            salesRepPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            quotePanel.SuspendLayout();
            optionsPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.AutoSize = true;
            enterButton.BackColor = Color.FromArgb(247, 153, 11);
            enterButton.FlatAppearance.BorderColor = Color.Black;
            enterButton.FlatAppearance.BorderSize = 2;
            enterButton.FlatStyle = FlatStyle.Flat;
            enterButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            enterButton.ForeColor = Color.White;
            enterButton.Location = new Point(883, 35);
            enterButton.Name = "enterButton";
            enterButton.Padding = new Padding(30, 15, 30, 15);
            enterButton.Size = new Size(160, 80);
            enterButton.TabIndex = 2;
            enterButton.Text = "&Enter";
            toolTip.SetToolTip(enterButton, "Press to login with your credentials");
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += EnterButtonClickHandler;
            // 
            // salesRepPanel
            // 
            salesRepPanel.AutoSize = true;
            salesRepPanel.BackColor = Color.FromArgb(25, 157, 198);
            salesRepPanel.Controls.Add(quoteIdTextBox);
            salesRepPanel.Controls.Add(salesRepTextBox);
            salesRepPanel.Controls.Add(quoteIdLabel);
            salesRepPanel.Controls.Add(salesRepLabel);
            salesRepPanel.Controls.Add(enterButton);
            salesRepPanel.Location = new Point(50, 100);
            salesRepPanel.Margin = new Padding(0);
            salesRepPanel.Name = "salesRepPanel";
            salesRepPanel.Size = new Size(1070, 150);
            salesRepPanel.TabIndex = 5;
            // 
            // quoteIdTextBox
            // 
            quoteIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            quoteIdTextBox.Font = new Font("Arial", 10F, FontStyle.Bold);
            quoteIdTextBox.Location = new Point(618, 51);
            quoteIdTextBox.Name = "quoteIdTextBox";
            quoteIdTextBox.Size = new Size(200, 38);
            quoteIdTextBox.TabIndex = 1;
            quoteIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // salesRepTextBox
            // 
            salesRepTextBox.BorderStyle = BorderStyle.FixedSingle;
            salesRepTextBox.Font = new Font("Arial", 10F, FontStyle.Bold);
            salesRepTextBox.Location = new Point(225, 51);
            salesRepTextBox.Name = "salesRepTextBox";
            salesRepTextBox.Size = new Size(200, 38);
            salesRepTextBox.TabIndex = 0;
            salesRepTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // quoteIdLabel
            // 
            quoteIdLabel.AutoSize = true;
            quoteIdLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            quoteIdLabel.ForeColor = Color.White;
            quoteIdLabel.Location = new Point(460, 55);
            quoteIdLabel.Name = "quoteIdLabel";
            quoteIdLabel.Padding = new Padding(0, 4, 0, 4);
            quoteIdLabel.Size = new Size(139, 40);
            quoteIdLabel.TabIndex = 4;
            quoteIdLabel.Text = "Quote ID:";
            // 
            // salesRepLabel
            // 
            salesRepLabel.AutoSize = true;
            salesRepLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            salesRepLabel.ForeColor = Color.White;
            salesRepLabel.Location = new Point(50, 58);
            salesRepLabel.Name = "salesRepLabel";
            salesRepLabel.Padding = new Padding(0, 4, 0, 4);
            salesRepLabel.Size = new Size(155, 40);
            salesRepLabel.TabIndex = 3;
            salesRepLabel.Text = "Sales Rep:";
            // 
            // logoImage
            // 
            logoImage.Location = new Point(337, 280);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(500, 500);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 100;
            logoImage.TabStop = false;
            // 
            // quotePanel
            // 
            quotePanel.BackColor = Color.FromArgb(25, 157, 198);
            quotePanel.Controls.Add(quoteBottomLine);
            quotePanel.Controls.Add(invertorsTextBox);
            quotePanel.Controls.Add(batteriesTextBox);
            quotePanel.Controls.Add(panelsTextBox);
            quotePanel.Controls.Add(invertorsLabel);
            quotePanel.Controls.Add(batteriesLabel);
            quotePanel.Controls.Add(panelsLabel);
            quotePanel.Controls.Add(quoteLabel);
            quotePanel.Controls.Add(quoteHeadingLine);
            quotePanel.Location = new Point(50, 70);
            quotePanel.Name = "quotePanel";
            quotePanel.Size = new Size(1070, 340);
            quotePanel.TabIndex = 13;
            quotePanel.Visible = false;
            // 
            // quoteBottomLine
            // 
            quoteBottomLine.BackColor = Color.White;
            quoteBottomLine.Location = new Point(0, 335);
            quoteBottomLine.Name = "quoteBottomLine";
            quoteBottomLine.Size = new Size(1070, 2);
            quoteBottomLine.TabIndex = 12;
            // 
            // invertorsTextBox
            // 
            invertorsTextBox.BorderStyle = BorderStyle.FixedSingle;
            invertorsTextBox.Font = new Font("Arial", 10F, FontStyle.Bold);
            invertorsTextBox.Location = new Point(800, 240);
            invertorsTextBox.Margin = new Padding(20, 10, 20, 10);
            invertorsTextBox.Name = "invertorsTextBox";
            invertorsTextBox.Size = new Size(80, 38);
            invertorsTextBox.TabIndex = 2;
            invertorsTextBox.Text = "0";
            invertorsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // batteriesTextBox
            // 
            batteriesTextBox.BorderStyle = BorderStyle.FixedSingle;
            batteriesTextBox.Font = new Font("Arial", 10F, FontStyle.Bold);
            batteriesTextBox.Location = new Point(800, 160);
            batteriesTextBox.Margin = new Padding(20, 10, 20, 10);
            batteriesTextBox.Name = "batteriesTextBox";
            batteriesTextBox.Size = new Size(80, 38);
            batteriesTextBox.TabIndex = 1;
            batteriesTextBox.Text = "0";
            batteriesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // panelsTextBox
            // 
            panelsTextBox.BorderStyle = BorderStyle.FixedSingle;
            panelsTextBox.Font = new Font("Arial", 10F, FontStyle.Bold);
            panelsTextBox.Location = new Point(800, 80);
            panelsTextBox.Margin = new Padding(20, 10, 20, 10);
            panelsTextBox.Name = "panelsTextBox";
            panelsTextBox.Size = new Size(80, 38);
            panelsTextBox.TabIndex = 0;
            panelsTextBox.Text = "0";
            panelsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // invertorsLabel
            // 
            invertorsLabel.AutoSize = true;
            invertorsLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            invertorsLabel.ForeColor = Color.White;
            invertorsLabel.Location = new Point(200, 240);
            invertorsLabel.Name = "invertorsLabel";
            invertorsLabel.Padding = new Padding(0, 4, 0, 4);
            invertorsLabel.Size = new Size(251, 45);
            invertorsLabel.TabIndex = 9;
            invertorsLabel.Text = "No. of Invertors";
            // 
            // batteriesLabel
            // 
            batteriesLabel.AutoSize = true;
            batteriesLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            batteriesLabel.ForeColor = Color.White;
            batteriesLabel.Location = new Point(200, 160);
            batteriesLabel.Name = "batteriesLabel";
            batteriesLabel.Padding = new Padding(0, 4, 0, 4);
            batteriesLabel.Size = new Size(296, 45);
            batteriesLabel.TabIndex = 8;
            batteriesLabel.Text = "No. 5KW Batteries";
            // 
            // panelsLabel
            // 
            panelsLabel.AutoSize = true;
            panelsLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            panelsLabel.ForeColor = Color.White;
            panelsLabel.Location = new Point(200, 80);
            panelsLabel.Name = "panelsLabel";
            panelsLabel.Padding = new Padding(0, 4, 0, 4);
            panelsLabel.Size = new Size(308, 45);
            panelsLabel.TabIndex = 7;
            panelsLabel.Text = "No. of Solar Panels";
            // 
            // quoteLabel
            // 
            quoteLabel.AutoSize = true;
            quoteLabel.Font = new Font("Arial", 10F);
            quoteLabel.ForeColor = Color.White;
            quoteLabel.Location = new Point(40, 0);
            quoteLabel.Name = "quoteLabel";
            quoteLabel.Padding = new Padding(0, 4, 0, 4);
            quoteLabel.Size = new Size(229, 40);
            quoteLabel.TabIndex = 11;
            quoteLabel.Text = "PV System Quote";
            // 
            // quoteHeadingLine
            // 
            quoteHeadingLine.BackColor = Color.White;
            quoteHeadingLine.Location = new Point(0, 20);
            quoteHeadingLine.Name = "quoteHeadingLine";
            quoteHeadingLine.Size = new Size(1070, 2);
            quoteHeadingLine.TabIndex = 10;
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = Color.FromArgb(25, 157, 198);
            optionsPanel.BorderStyle = BorderStyle.FixedSingle;
            optionsPanel.Controls.Add(exitButton);
            optionsPanel.Controls.Add(summaryButton);
            optionsPanel.Controls.Add(clearButton);
            optionsPanel.Controls.Add(quoteButton);
            optionsPanel.Location = new Point(50, 450);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(1070, 150);
            optionsPanel.TabIndex = 14;
            optionsPanel.Visible = false;
            // 
            // exitButton
            // 
            exitButton.AutoSize = true;
            exitButton.BackColor = Color.FromArgb(247, 153, 11);
            exitButton.FlatAppearance.BorderColor = Color.White;
            exitButton.FlatAppearance.BorderSize = 5;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(820, 60);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 52);
            exitButton.TabIndex = 6;
            exitButton.Text = "E&xit";
            toolTip.SetToolTip(exitButton, "Press to Quit the App");
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButtonClickHandler;
            // 
            // summaryButton
            // 
            summaryButton.AutoSize = true;
            summaryButton.BackColor = Color.FromArgb(247, 153, 11);
            summaryButton.Enabled = false;
            summaryButton.FlatAppearance.BorderColor = Color.White;
            summaryButton.FlatAppearance.BorderSize = 5;
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            summaryButton.ForeColor = Color.White;
            summaryButton.Location = new Point(560, 60);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(200, 52);
            summaryButton.TabIndex = 5;
            summaryButton.Text = "&Summary";
            toolTip.SetToolTip(summaryButton, "Press to view Summary of all quotations");
            summaryButton.UseVisualStyleBackColor = true;
            summaryButton.Click += SummaryButtonClickHandler;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.BackColor = Color.FromArgb(247, 153, 11);
            clearButton.FlatAppearance.BorderColor = Color.White;
            clearButton.FlatAppearance.BorderSize = 5;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(300, 60);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 52);
            clearButton.TabIndex = 4;
            clearButton.Text = "&Clear";
            toolTip.SetToolTip(clearButton, "Press to reset the form");
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButtonClickHandler;
            // 
            // quoteButton
            // 
            quoteButton.AutoSize = true;
            quoteButton.BackColor = Color.FromArgb(247, 153, 11);
            quoteButton.FlatAppearance.BorderColor = Color.White;
            quoteButton.FlatAppearance.BorderSize = 5;
            quoteButton.FlatStyle = FlatStyle.Flat;
            quoteButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            quoteButton.ForeColor = Color.White;
            quoteButton.Location = new Point(40, 60);
            quoteButton.Name = "quoteButton";
            quoteButton.Size = new Size(200, 52);
            quoteButton.TabIndex = 3;
            quoteButton.Text = "&Quote";
            toolTip.SetToolTip(quoteButton, "Press to view quotation");
            quoteButton.UseVisualStyleBackColor = true;
            quoteButton.Click += QuoteButtonClickHandler;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.FromArgb(25, 157, 198);
            summaryPanel.Controls.Add(installationPercentage);
            summaryPanel.Controls.Add(invertorsPercentage);
            summaryPanel.Controls.Add(batteriesPercentage);
            summaryPanel.Controls.Add(panelsPercentage);
            summaryPanel.Controls.Add(averageQuoteValue);
            summaryPanel.Controls.Add(totalCost);
            summaryPanel.Controls.Add(installationCost);
            summaryPanel.Controls.Add(invertorsCost);
            summaryPanel.Controls.Add(batteriesCost);
            summaryPanel.Controls.Add(panelsCost);
            summaryPanel.Controls.Add(summaryBottomLine);
            summaryPanel.Controls.Add(summaryMidLine);
            summaryPanel.Controls.Add(summaryLabel);
            summaryPanel.Controls.Add(summaryHeadingLine);
            summaryPanel.Controls.Add(totalQuotesValue);
            summaryPanel.Controls.Add(averageQuoteLabel);
            summaryPanel.Controls.Add(totalCostLabel);
            summaryPanel.Controls.Add(installationCostLabel);
            summaryPanel.Controls.Add(invertorsCostLabel);
            summaryPanel.Controls.Add(batteriesCostLabel);
            summaryPanel.Controls.Add(panelsCostLabel);
            summaryPanel.Controls.Add(totalQuotesLabel);
            summaryPanel.Location = new Point(50, 660);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1070, 600);
            summaryPanel.TabIndex = 15;
            summaryPanel.Visible = false;
            // 
            // installationPercentage
            // 
            installationPercentage.BackColor = Color.White;
            installationPercentage.BorderStyle = BorderStyle.FixedSingle;
            installationPercentage.ForeColor = Color.Black;
            installationPercentage.Location = new Point(763, 320);
            installationPercentage.Margin = new Padding(0);
            installationPercentage.Name = "installationPercentage";
            installationPercentage.Size = new Size(100, 40);
            installationPercentage.TabIndex = 31;
            installationPercentage.Text = "0";
            installationPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsPercentage
            // 
            invertorsPercentage.BackColor = Color.White;
            invertorsPercentage.BorderStyle = BorderStyle.FixedSingle;
            invertorsPercentage.ForeColor = Color.Black;
            invertorsPercentage.Location = new Point(763, 260);
            invertorsPercentage.Margin = new Padding(0);
            invertorsPercentage.Name = "invertorsPercentage";
            invertorsPercentage.Size = new Size(100, 40);
            invertorsPercentage.TabIndex = 28;
            invertorsPercentage.Text = "0";
            invertorsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesPercentage
            // 
            batteriesPercentage.BackColor = Color.White;
            batteriesPercentage.BorderStyle = BorderStyle.FixedSingle;
            batteriesPercentage.ForeColor = Color.Black;
            batteriesPercentage.Location = new Point(763, 200);
            batteriesPercentage.Margin = new Padding(0);
            batteriesPercentage.Name = "batteriesPercentage";
            batteriesPercentage.Size = new Size(100, 40);
            batteriesPercentage.TabIndex = 25;
            batteriesPercentage.Text = "0";
            batteriesPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsPercentage
            // 
            panelsPercentage.BackColor = Color.White;
            panelsPercentage.BorderStyle = BorderStyle.FixedSingle;
            panelsPercentage.ForeColor = Color.Black;
            panelsPercentage.Location = new Point(763, 140);
            panelsPercentage.Margin = new Padding(0);
            panelsPercentage.Name = "panelsPercentage";
            panelsPercentage.Size = new Size(100, 40);
            panelsPercentage.TabIndex = 22;
            panelsPercentage.Text = "0";
            panelsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // averageQuoteValue
            // 
            averageQuoteValue.BackColor = Color.White;
            averageQuoteValue.BorderStyle = BorderStyle.FixedSingle;
            averageQuoteValue.ForeColor = Color.Black;
            averageQuoteValue.Location = new Point(560, 500);
            averageQuoteValue.Margin = new Padding(0);
            averageQuoteValue.Name = "averageQuoteValue";
            averageQuoteValue.Size = new Size(160, 40);
            averageQuoteValue.TabIndex = 36;
            averageQuoteValue.Text = "0";
            averageQuoteValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCost
            // 
            totalCost.BackColor = Color.White;
            totalCost.BorderStyle = BorderStyle.FixedSingle;
            totalCost.ForeColor = Color.Black;
            totalCost.Location = new Point(560, 440);
            totalCost.Margin = new Padding(0);
            totalCost.Name = "totalCost";
            totalCost.Size = new Size(160, 40);
            totalCost.TabIndex = 34;
            totalCost.Text = "0";
            totalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installationCost
            // 
            installationCost.BackColor = Color.White;
            installationCost.BorderStyle = BorderStyle.FixedSingle;
            installationCost.ForeColor = Color.Black;
            installationCost.Location = new Point(560, 320);
            installationCost.Margin = new Padding(0);
            installationCost.Name = "installationCost";
            installationCost.Size = new Size(160, 40);
            installationCost.TabIndex = 30;
            installationCost.Text = "0";
            installationCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsCost
            // 
            invertorsCost.BackColor = Color.White;
            invertorsCost.BorderStyle = BorderStyle.FixedSingle;
            invertorsCost.ForeColor = Color.Black;
            invertorsCost.Location = new Point(560, 260);
            invertorsCost.Margin = new Padding(0);
            invertorsCost.Name = "invertorsCost";
            invertorsCost.Size = new Size(160, 40);
            invertorsCost.TabIndex = 27;
            invertorsCost.Text = "0";
            invertorsCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesCost
            // 
            batteriesCost.BackColor = Color.White;
            batteriesCost.BorderStyle = BorderStyle.FixedSingle;
            batteriesCost.ForeColor = Color.Black;
            batteriesCost.Location = new Point(560, 200);
            batteriesCost.Margin = new Padding(0);
            batteriesCost.Name = "batteriesCost";
            batteriesCost.Size = new Size(160, 40);
            batteriesCost.TabIndex = 24;
            batteriesCost.Text = "0";
            batteriesCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsCost
            // 
            panelsCost.BackColor = Color.White;
            panelsCost.BorderStyle = BorderStyle.FixedSingle;
            panelsCost.ForeColor = Color.Black;
            panelsCost.Location = new Point(560, 140);
            panelsCost.Margin = new Padding(0);
            panelsCost.Name = "panelsCost";
            panelsCost.Size = new Size(160, 40);
            panelsCost.TabIndex = 21;
            panelsCost.Text = "0";
            panelsCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // summaryBottomLine
            // 
            summaryBottomLine.BackColor = Color.White;
            summaryBottomLine.Location = new Point(0, 595);
            summaryBottomLine.Name = "summaryBottomLine";
            summaryBottomLine.Size = new Size(1070, 2);
            summaryBottomLine.TabIndex = 37;
            // 
            // summaryMidLine
            // 
            summaryMidLine.BackColor = Color.White;
            summaryMidLine.Location = new Point(100, 400);
            summaryMidLine.Name = "summaryMidLine";
            summaryMidLine.Size = new Size(870, 5);
            summaryMidLine.TabIndex = 32;
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Arial", 10F);
            summaryLabel.ForeColor = Color.White;
            summaryLabel.Location = new Point(40, 0);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Padding = new Padding(0, 4, 0, 4);
            summaryLabel.Size = new Size(211, 40);
            summaryLabel.TabIndex = 17;
            summaryLabel.Text = "Quote Summary";
            // 
            // summaryHeadingLine
            // 
            summaryHeadingLine.BackColor = Color.White;
            summaryHeadingLine.Location = new Point(0, 20);
            summaryHeadingLine.Name = "summaryHeadingLine";
            summaryHeadingLine.Size = new Size(1070, 2);
            summaryHeadingLine.TabIndex = 16;
            // 
            // totalQuotesValue
            // 
            totalQuotesValue.BackColor = Color.White;
            totalQuotesValue.BorderStyle = BorderStyle.FixedSingle;
            totalQuotesValue.ForeColor = Color.Black;
            totalQuotesValue.Location = new Point(560, 80);
            totalQuotesValue.Margin = new Padding(0);
            totalQuotesValue.Name = "totalQuotesValue";
            totalQuotesValue.Size = new Size(160, 40);
            totalQuotesValue.TabIndex = 19;
            totalQuotesValue.Text = "0";
            totalQuotesValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // averageQuoteLabel
            // 
            averageQuoteLabel.AutoSize = true;
            averageQuoteLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            averageQuoteLabel.ForeColor = Color.White;
            averageQuoteLabel.Location = new Point(75, 500);
            averageQuoteLabel.Name = "averageQuoteLabel";
            averageQuoteLabel.Padding = new Padding(0, 4, 0, 4);
            averageQuoteLabel.Size = new Size(335, 45);
            averageQuoteLabel.TabIndex = 35;
            averageQuoteLabel.Text = "Average Quote Value";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            totalCostLabel.ForeColor = Color.White;
            totalCostLabel.Location = new Point(75, 440);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Padding = new Padding(0, 4, 0, 4);
            totalCostLabel.Size = new Size(273, 45);
            totalCostLabel.TabIndex = 33;
            totalCostLabel.Text = "Total Cost Quote";
            // 
            // installationCostLabel
            // 
            installationCostLabel.AutoSize = true;
            installationCostLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            installationCostLabel.ForeColor = Color.White;
            installationCostLabel.Location = new Point(75, 320);
            installationCostLabel.Name = "installationCostLabel";
            installationCostLabel.Padding = new Padding(0, 4, 0, 4);
            installationCostLabel.Size = new Size(268, 45);
            installationCostLabel.TabIndex = 29;
            installationCostLabel.Text = "Cost Installation";
            // 
            // invertorsCostLabel
            // 
            invertorsCostLabel.AutoSize = true;
            invertorsCostLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            invertorsCostLabel.ForeColor = Color.White;
            invertorsCostLabel.Location = new Point(75, 260);
            invertorsCostLabel.Name = "invertorsCostLabel";
            invertorsCostLabel.Padding = new Padding(0, 4, 0, 4);
            invertorsCostLabel.Size = new Size(233, 45);
            invertorsCostLabel.TabIndex = 26;
            invertorsCostLabel.Text = "Cost Invertors";
            // 
            // batteriesCostLabel
            // 
            batteriesCostLabel.AutoSize = true;
            batteriesCostLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            batteriesCostLabel.ForeColor = Color.White;
            batteriesCostLabel.Location = new Point(75, 200);
            batteriesCostLabel.Name = "batteriesCostLabel";
            batteriesCostLabel.Padding = new Padding(0, 4, 0, 4);
            batteriesCostLabel.Size = new Size(236, 45);
            batteriesCostLabel.TabIndex = 23;
            batteriesCostLabel.Text = "Cost Batteries";
            // 
            // panelsCostLabel
            // 
            panelsCostLabel.AutoSize = true;
            panelsCostLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            panelsCostLabel.ForeColor = Color.White;
            panelsCostLabel.Location = new Point(75, 140);
            panelsCostLabel.Name = "panelsCostLabel";
            panelsCostLabel.Padding = new Padding(0, 4, 0, 4);
            panelsCostLabel.Size = new Size(290, 45);
            panelsCostLabel.TabIndex = 20;
            panelsCostLabel.Text = "Cost Solar Panels";
            // 
            // totalQuotesLabel
            // 
            totalQuotesLabel.AutoSize = true;
            totalQuotesLabel.Font = new Font("Arial", 12F, FontStyle.Bold);
            totalQuotesLabel.ForeColor = Color.White;
            totalQuotesLabel.Location = new Point(75, 80);
            totalQuotesLabel.Name = "totalQuotesLabel";
            totalQuotesLabel.Padding = new Padding(0, 4, 0, 4);
            totalQuotesLabel.Size = new Size(309, 45);
            totalQuotesLabel.TabIndex = 18;
            totalQuotesLabel.Text = "Total No. of Quotes";
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info";
            // 
            // Solar4U
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 1529);
            Controls.Add(quotePanel);
            Controls.Add(summaryPanel);
            Controls.Add(optionsPanel);
            Controls.Add(logoImage);
            Controls.Add(salesRepPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Solar4U";
            Text = "Solar4U Sales Quote Calculator";
            Load += Solar4UOnLoad;
            salesRepPanel.ResumeLayout(false);
            salesRepPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            quotePanel.ResumeLayout(false);
            quotePanel.PerformLayout();
            optionsPanel.ResumeLayout(false);
            optionsPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterButton;
        private Panel salesRepPanel;
        private PictureBox logoImage;
        private Label salesRepLabel;
        private Label quoteIdLabel;
        private TextBox quoteIdTextBox;
        private TextBox salesRepTextBox;
        private Panel quotePanel;
        private Panel optionsPanel;
        private Panel summaryPanel;
        private Panel quoteHeadingLine;
        private Label quoteLabel;
        private Label panelsLabel;
        private Label batteriesLabel;
        private Label invertorsLabel;
        private Label totalQuotesLabel;
        private Label invertorsCostLabel;
        private Label batteriesCostLabel;
        private Label panelsCostLabel;
        private Label installationCostLabel;
        private Label totalCostLabel;
        private Label averageQuoteLabel;
        private TextBox invertorsTextBox;
        private TextBox batteriesTextBox;
        private TextBox panelsTextBox;
        private Label totalQuotesValue;
        private Button quoteButton;
        private Button exitButton;
        private Button summaryButton;
        private Button clearButton;
        private Label summaryLabel;
        private Panel quoteBottomLine;
        private Panel summaryHeadingLine;
        private Panel summaryBottomLine;
        private Panel summaryMidLine;
        private Label panelsCost;
        private Label installationPercentage;
        private Label invertorsPercentage;
        private Label batteriesPercentage;
        private Label panelsPercentage;
        private Label averageQuoteValue;
        private Label totalCost;
        private Label installationCost;
        private Label invertorsCost;
        private Label batteriesCost;
        private ToolTip toolTip;
    }
}
