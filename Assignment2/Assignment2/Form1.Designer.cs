namespace Assignment2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FirstLogoPicBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ServingPanel = new System.Windows.Forms.Panel();
            this.TableNumberTextBox = new System.Windows.Forms.TextBox();
            this.TableNumberLabel = new System.Windows.Forms.Label();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.FoodTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CalzoniPriceLabel = new System.Windows.Forms.Label();
            this.PineapplePizzaPriceLabel = new System.Windows.Forms.Label();
            this.PepperoniPizzaPriceLabel = new System.Windows.Forms.Label();
            this.HamPizzaPriceLabel = new System.Windows.Forms.Label();
            this.CalzoniTextBox = new System.Windows.Forms.TextBox();
            this.PineapplePizzaTextBox = new System.Windows.Forms.TextBox();
            this.PepperoniPizzaTextBox = new System.Windows.Forms.TextBox();
            this.HamPizzaTextBox = new System.Windows.Forms.TextBox();
            this.CalzoniLabel = new System.Windows.Forms.Label();
            this.PineapplePizzaLabel = new System.Windows.Forms.Label();
            this.PepperoniPizzaLabel = new System.Windows.Forms.Label();
            this.HamPizzaLabel = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SecondLogoPicBox = new System.Windows.Forms.PictureBox();
            this.CompanySummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AvgTransactionValueTextBox = new System.Windows.Forms.TextBox();
            this.TotalRecieptsTextBox = new System.Windows.Forms.TextBox();
            this.NumPizzaOrderedTextBox = new System.Windows.Forms.TextBox();
            this.TotalTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.AvgTransactionLabel = new System.Windows.Forms.Label();
            this.TotalRecieptsLabel = new System.Windows.Forms.Label();
            this.NumberOfPizzasOrderedLabel = new System.Windows.Forms.Label();
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.TableSummaryDataGroupBox = new System.Windows.Forms.GroupBox();
            this.TableTotalRecieptsTextBox = new System.Windows.Forms.TextBox();
            this.TablePizzasOrderedTextBox = new System.Windows.Forms.TextBox();
            this.DisplayServerTextBox = new System.Windows.Forms.TextBox();
            this.TotalTableRecieptsLabel = new System.Windows.Forms.Label();
            this.NumPizzasOrdered = new System.Windows.Forms.Label();
            this.ServersNameLabel = new System.Windows.Forms.Label();
            this.OrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Summary = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FirstLogoPicBox)).BeginInit();
            this.ServingPanel.SuspendLayout();
            this.FoodTypeGroupBox.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondLogoPicBox)).BeginInit();
            this.CompanySummaryGroupBox.SuspendLayout();
            this.TableSummaryDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstLogoPicBox
            // 
            this.FirstLogoPicBox.Image = global::Assignment2.Properties.Resources.PizzaBothánLogoRectangle;
            this.FirstLogoPicBox.Location = new System.Drawing.Point(87, 13);
            this.FirstLogoPicBox.Name = "FirstLogoPicBox";
            this.FirstLogoPicBox.Size = new System.Drawing.Size(339, 162);
            this.FirstLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstLogoPicBox.TabIndex = 0;
            this.FirstLogoPicBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Cyan;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(212, 288);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 37);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "&Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ServingPanel
            // 
            this.ServingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServingPanel.Controls.Add(this.TableNumberTextBox);
            this.ServingPanel.Controls.Add(this.TableNumberLabel);
            this.ServingPanel.Controls.Add(this.ServerNameLabel);
            this.ServingPanel.Controls.Add(this.ServerNameTextBox);
            this.ServingPanel.Location = new System.Drawing.Point(13, 13);
            this.ServingPanel.Name = "ServingPanel";
            this.ServingPanel.Size = new System.Drawing.Size(495, 55);
            this.ServingPanel.TabIndex = 2;
            // 
            // TableNumberTextBox
            // 
            this.TableNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberTextBox.Location = new System.Drawing.Point(402, 14);
            this.TableNumberTextBox.Name = "TableNumberTextBox";
            this.TableNumberTextBox.Size = new System.Drawing.Size(70, 22);
            this.TableNumberTextBox.TabIndex = 3;
            this.TableNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TableNumberLabel
            // 
            this.TableNumberLabel.AutoSize = true;
            this.TableNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNumberLabel.Location = new System.Drawing.Point(285, 16);
            this.TableNumberLabel.Name = "TableNumberLabel";
            this.TableNumberLabel.Size = new System.Drawing.Size(110, 16);
            this.TableNumberLabel.TabIndex = 2;
            this.TableNumberLabel.Text = "Table Number:";
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNameLabel.Location = new System.Drawing.Point(25, 16);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(102, 16);
            this.ServerNameLabel.TabIndex = 1;
            this.ServerNameLabel.Text = "Server Name:";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerNameTextBox.Location = new System.Drawing.Point(140, 14);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.ServerNameTextBox.TabIndex = 0;
            this.ServerNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FoodTypeGroupBox
            // 
            this.FoodTypeGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.FoodTypeGroupBox.Controls.Add(this.CalzoniPriceLabel);
            this.FoodTypeGroupBox.Controls.Add(this.PineapplePizzaPriceLabel);
            this.FoodTypeGroupBox.Controls.Add(this.PepperoniPizzaPriceLabel);
            this.FoodTypeGroupBox.Controls.Add(this.HamPizzaPriceLabel);
            this.FoodTypeGroupBox.Controls.Add(this.CalzoniTextBox);
            this.FoodTypeGroupBox.Controls.Add(this.PineapplePizzaTextBox);
            this.FoodTypeGroupBox.Controls.Add(this.PepperoniPizzaTextBox);
            this.FoodTypeGroupBox.Controls.Add(this.HamPizzaTextBox);
            this.FoodTypeGroupBox.Controls.Add(this.CalzoniLabel);
            this.FoodTypeGroupBox.Controls.Add(this.PineapplePizzaLabel);
            this.FoodTypeGroupBox.Controls.Add(this.PepperoniPizzaLabel);
            this.FoodTypeGroupBox.Controls.Add(this.HamPizzaLabel);
            this.FoodTypeGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FoodTypeGroupBox.Location = new System.Drawing.Point(13, 74);
            this.FoodTypeGroupBox.Name = "FoodTypeGroupBox";
            this.FoodTypeGroupBox.Size = new System.Drawing.Size(495, 207);
            this.FoodTypeGroupBox.TabIndex = 3;
            this.FoodTypeGroupBox.TabStop = false;
            this.FoodTypeGroupBox.Text = "Menu";
            // 
            // CalzoniPriceLabel
            // 
            this.CalzoniPriceLabel.AutoSize = true;
            this.CalzoniPriceLabel.Location = new System.Drawing.Point(366, 164);
            this.CalzoniPriceLabel.Name = "CalzoniPriceLabel";
            this.CalzoniPriceLabel.Size = new System.Drawing.Size(62, 16);
            this.CalzoniPriceLabel.TabIndex = 11;
            this.CalzoniPriceLabel.Text = "@ €11.99";
            // 
            // PineapplePizzaPriceLabel
            // 
            this.PineapplePizzaPriceLabel.AutoSize = true;
            this.PineapplePizzaPriceLabel.Location = new System.Drawing.Point(366, 123);
            this.PineapplePizzaPriceLabel.Name = "PineapplePizzaPriceLabel";
            this.PineapplePizzaPriceLabel.Size = new System.Drawing.Size(55, 16);
            this.PineapplePizzaPriceLabel.TabIndex = 10;
            this.PineapplePizzaPriceLabel.Text = "@ €9.99";
            // 
            // PepperoniPizzaPriceLabel
            // 
            this.PepperoniPizzaPriceLabel.AutoSize = true;
            this.PepperoniPizzaPriceLabel.Location = new System.Drawing.Point(366, 82);
            this.PepperoniPizzaPriceLabel.Name = "PepperoniPizzaPriceLabel";
            this.PepperoniPizzaPriceLabel.Size = new System.Drawing.Size(55, 16);
            this.PepperoniPizzaPriceLabel.TabIndex = 9;
            this.PepperoniPizzaPriceLabel.Text = "@ €8.99";
            // 
            // HamPizzaPriceLabel
            // 
            this.HamPizzaPriceLabel.AutoSize = true;
            this.HamPizzaPriceLabel.Location = new System.Drawing.Point(366, 41);
            this.HamPizzaPriceLabel.Name = "HamPizzaPriceLabel";
            this.HamPizzaPriceLabel.Size = new System.Drawing.Size(55, 16);
            this.HamPizzaPriceLabel.TabIndex = 8;
            this.HamPizzaPriceLabel.Text = "@ €7.99";
            // 
            // CalzoniTextBox
            // 
            this.CalzoniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalzoniTextBox.Location = new System.Drawing.Point(269, 158);
            this.CalzoniTextBox.Name = "CalzoniTextBox";
            this.CalzoniTextBox.Size = new System.Drawing.Size(50, 22);
            this.CalzoniTextBox.TabIndex = 7;
            this.CalzoniTextBox.Text = "0";
            this.CalzoniTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PineapplePizzaTextBox
            // 
            this.PineapplePizzaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PineapplePizzaTextBox.Location = new System.Drawing.Point(269, 117);
            this.PineapplePizzaTextBox.Name = "PineapplePizzaTextBox";
            this.PineapplePizzaTextBox.Size = new System.Drawing.Size(50, 22);
            this.PineapplePizzaTextBox.TabIndex = 6;
            this.PineapplePizzaTextBox.Text = "0";
            this.PineapplePizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PepperoniPizzaTextBox
            // 
            this.PepperoniPizzaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperoniPizzaTextBox.Location = new System.Drawing.Point(269, 76);
            this.PepperoniPizzaTextBox.Name = "PepperoniPizzaTextBox";
            this.PepperoniPizzaTextBox.Size = new System.Drawing.Size(50, 22);
            this.PepperoniPizzaTextBox.TabIndex = 5;
            this.PepperoniPizzaTextBox.Text = "0";
            this.PepperoniPizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamPizzaTextBox
            // 
            this.HamPizzaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamPizzaTextBox.Location = new System.Drawing.Point(269, 35);
            this.HamPizzaTextBox.Name = "HamPizzaTextBox";
            this.HamPizzaTextBox.Size = new System.Drawing.Size(50, 22);
            this.HamPizzaTextBox.TabIndex = 4;
            this.HamPizzaTextBox.Text = "0";
            this.HamPizzaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalzoniLabel
            // 
            this.CalzoniLabel.AutoSize = true;
            this.CalzoniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalzoniLabel.Location = new System.Drawing.Point(78, 164);
            this.CalzoniLabel.Name = "CalzoniLabel";
            this.CalzoniLabel.Size = new System.Drawing.Size(58, 16);
            this.CalzoniLabel.TabIndex = 3;
            this.CalzoniLabel.Text = "Calzoni";
            // 
            // PineapplePizzaLabel
            // 
            this.PineapplePizzaLabel.AutoSize = true;
            this.PineapplePizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PineapplePizzaLabel.Location = new System.Drawing.Point(78, 122);
            this.PineapplePizzaLabel.Name = "PineapplePizzaLabel";
            this.PineapplePizzaLabel.Size = new System.Drawing.Size(119, 16);
            this.PineapplePizzaLabel.TabIndex = 2;
            this.PineapplePizzaLabel.Text = "Pineapple Pizza";
            // 
            // PepperoniPizzaLabel
            // 
            this.PepperoniPizzaLabel.AutoSize = true;
            this.PepperoniPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PepperoniPizzaLabel.Location = new System.Drawing.Point(78, 80);
            this.PepperoniPizzaLabel.Name = "PepperoniPizzaLabel";
            this.PepperoniPizzaLabel.Size = new System.Drawing.Size(120, 16);
            this.PepperoniPizzaLabel.TabIndex = 1;
            this.PepperoniPizzaLabel.Text = "Pepperoni Pizza";
            // 
            // HamPizzaLabel
            // 
            this.HamPizzaLabel.AutoSize = true;
            this.HamPizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamPizzaLabel.Location = new System.Drawing.Point(78, 38);
            this.HamPizzaLabel.Name = "HamPizzaLabel";
            this.HamPizzaLabel.Size = new System.Drawing.Size(80, 16);
            this.HamPizzaLabel.TabIndex = 0;
            this.HamPizzaLabel.Text = "Ham Pizza";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.ExitButton);
            this.ControlPanel.Controls.Add(this.SummaryButton);
            this.ControlPanel.Controls.Add(this.ClearButton);
            this.ControlPanel.Controls.Add(this.OrderButton);
            this.ControlPanel.Location = new System.Drawing.Point(13, 287);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(495, 54);
            this.ControlPanel.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Cyan;
            this.ExitButton.FlatAppearance.BorderSize = 3;
            this.ExitButton.Location = new System.Drawing.Point(376, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 28);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Press to Exit Application");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.Cyan;
            this.SummaryButton.FlatAppearance.BorderSize = 3;
            this.SummaryButton.Location = new System.Drawing.Point(260, 12);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(85, 28);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "&Summary";
            this.Summary.SetToolTip(this.SummaryButton, "Press to Display form for Business Summary");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Cyan;
            this.ClearButton.FlatAppearance.BorderSize = 3;
            this.ClearButton.Location = new System.Drawing.Point(144, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 28);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "&Clear";
            this.ClearToolTip.SetToolTip(this.ClearButton, "Press to Clear Form for New Order");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.Cyan;
            this.OrderButton.FlatAppearance.BorderSize = 3;
            this.OrderButton.Location = new System.Drawing.Point(28, 12);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(85, 28);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "&Order";
            this.OrderToolTip.SetToolTip(this.OrderButton, "Press to Process Order");
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // SecondLogoPicBox
            // 
            this.SecondLogoPicBox.Image = global::Assignment2.Properties.Resources.PizzaBothánLogoRectangle;
            this.SecondLogoPicBox.Location = new System.Drawing.Point(119, 536);
            this.SecondLogoPicBox.Name = "SecondLogoPicBox";
            this.SecondLogoPicBox.Size = new System.Drawing.Size(261, 106);
            this.SecondLogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondLogoPicBox.TabIndex = 5;
            this.SecondLogoPicBox.TabStop = false;
            // 
            // CompanySummaryGroupBox
            // 
            this.CompanySummaryGroupBox.Controls.Add(this.AvgTransactionValueTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalRecieptsTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.NumPizzaOrderedTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalTransactionsTextBox);
            this.CompanySummaryGroupBox.Controls.Add(this.AvgTransactionLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalRecieptsLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.NumberOfPizzasOrderedLabel);
            this.CompanySummaryGroupBox.Controls.Add(this.TotalTransactionsLabel);
            this.CompanySummaryGroupBox.Location = new System.Drawing.Point(13, 347);
            this.CompanySummaryGroupBox.Name = "CompanySummaryGroupBox";
            this.CompanySummaryGroupBox.Size = new System.Drawing.Size(496, 159);
            this.CompanySummaryGroupBox.TabIndex = 6;
            this.CompanySummaryGroupBox.TabStop = false;
            this.CompanySummaryGroupBox.Text = "Company Summary Data";
            // 
            // AvgTransactionValueTextBox
            // 
            this.AvgTransactionValueTextBox.Location = new System.Drawing.Point(283, 128);
            this.AvgTransactionValueTextBox.Name = "AvgTransactionValueTextBox";
            this.AvgTransactionValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.AvgTransactionValueTextBox.TabIndex = 7;
            this.AvgTransactionValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalRecieptsTextBox
            // 
            this.TotalRecieptsTextBox.Location = new System.Drawing.Point(283, 98);
            this.TotalRecieptsTextBox.Name = "TotalRecieptsTextBox";
            this.TotalRecieptsTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalRecieptsTextBox.TabIndex = 6;
            this.TotalRecieptsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumPizzaOrderedTextBox
            // 
            this.NumPizzaOrderedTextBox.Location = new System.Drawing.Point(283, 68);
            this.NumPizzaOrderedTextBox.Name = "NumPizzaOrderedTextBox";
            this.NumPizzaOrderedTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumPizzaOrderedTextBox.TabIndex = 5;
            this.NumPizzaOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTransactionsTextBox
            // 
            this.TotalTransactionsTextBox.Location = new System.Drawing.Point(283, 38);
            this.TotalTransactionsTextBox.Name = "TotalTransactionsTextBox";
            this.TotalTransactionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalTransactionsTextBox.TabIndex = 4;
            this.TotalTransactionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AvgTransactionLabel
            // 
            this.AvgTransactionLabel.AutoSize = true;
            this.AvgTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgTransactionLabel.Location = new System.Drawing.Point(50, 128);
            this.AvgTransactionLabel.Name = "AvgTransactionLabel";
            this.AvgTransactionLabel.Size = new System.Drawing.Size(164, 16);
            this.AvgTransactionLabel.TabIndex = 3;
            this.AvgTransactionLabel.Text = "Avg Transaction Value";
            // 
            // TotalRecieptsLabel
            // 
            this.TotalRecieptsLabel.AutoSize = true;
            this.TotalRecieptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRecieptsLabel.Location = new System.Drawing.Point(50, 98);
            this.TotalRecieptsLabel.Name = "TotalRecieptsLabel";
            this.TotalRecieptsLabel.Size = new System.Drawing.Size(186, 16);
            this.TotalRecieptsLabel.TabIndex = 2;
            this.TotalRecieptsLabel.Text = "Total Companys Reciepts";
            // 
            // NumberOfPizzasOrderedLabel
            // 
            this.NumberOfPizzasOrderedLabel.AutoSize = true;
            this.NumberOfPizzasOrderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPizzasOrderedLabel.Location = new System.Drawing.Point(50, 68);
            this.NumberOfPizzasOrderedLabel.Name = "NumberOfPizzasOrderedLabel";
            this.NumberOfPizzasOrderedLabel.Size = new System.Drawing.Size(194, 16);
            this.NumberOfPizzasOrderedLabel.TabIndex = 1;
            this.NumberOfPizzasOrderedLabel.Text = "Number Of Pizza\'s Ordered";
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.AutoSize = true;
            this.TotalTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(50, 38);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(214, 16);
            this.TotalTransactionsLabel.TabIndex = 0;
            this.TotalTransactionsLabel.Text = "Total Companys Transactions";
            // 
            // TableSummaryDataGroupBox
            // 
            this.TableSummaryDataGroupBox.Controls.Add(this.TableTotalRecieptsTextBox);
            this.TableSummaryDataGroupBox.Controls.Add(this.TablePizzasOrderedTextBox);
            this.TableSummaryDataGroupBox.Controls.Add(this.DisplayServerTextBox);
            this.TableSummaryDataGroupBox.Controls.Add(this.TotalTableRecieptsLabel);
            this.TableSummaryDataGroupBox.Controls.Add(this.NumPizzasOrdered);
            this.TableSummaryDataGroupBox.Controls.Add(this.ServersNameLabel);
            this.TableSummaryDataGroupBox.Location = new System.Drawing.Point(13, 347);
            this.TableSummaryDataGroupBox.Name = "TableSummaryDataGroupBox";
            this.TableSummaryDataGroupBox.Size = new System.Drawing.Size(495, 159);
            this.TableSummaryDataGroupBox.TabIndex = 7;
            this.TableSummaryDataGroupBox.TabStop = false;
            this.TableSummaryDataGroupBox.Text = "Table Order Summary Data";
            // 
            // TableTotalRecieptsTextBox
            // 
            this.TableTotalRecieptsTextBox.Location = new System.Drawing.Point(289, 115);
            this.TableTotalRecieptsTextBox.Name = "TableTotalRecieptsTextBox";
            this.TableTotalRecieptsTextBox.Size = new System.Drawing.Size(109, 22);
            this.TableTotalRecieptsTextBox.TabIndex = 5;
            this.TableTotalRecieptsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TablePizzasOrderedTextBox
            // 
            this.TablePizzasOrderedTextBox.Location = new System.Drawing.Point(289, 75);
            this.TablePizzasOrderedTextBox.Name = "TablePizzasOrderedTextBox";
            this.TablePizzasOrderedTextBox.Size = new System.Drawing.Size(109, 22);
            this.TablePizzasOrderedTextBox.TabIndex = 4;
            this.TablePizzasOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisplayServerTextBox
            // 
            this.DisplayServerTextBox.Location = new System.Drawing.Point(289, 35);
            this.DisplayServerTextBox.Name = "DisplayServerTextBox";
            this.DisplayServerTextBox.Size = new System.Drawing.Size(109, 22);
            this.DisplayServerTextBox.TabIndex = 3;
            this.DisplayServerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTableRecieptsLabel
            // 
            this.TotalTableRecieptsLabel.AutoSize = true;
            this.TotalTableRecieptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTableRecieptsLabel.Location = new System.Drawing.Point(50, 115);
            this.TotalTableRecieptsLabel.Name = "TotalTableRecieptsLabel";
            this.TotalTableRecieptsLabel.Size = new System.Drawing.Size(154, 16);
            this.TotalTableRecieptsLabel.TabIndex = 2;
            this.TotalTableRecieptsLabel.Text = "Total Table Reciepts";
            // 
            // NumPizzasOrdered
            // 
            this.NumPizzasOrdered.AutoSize = true;
            this.NumPizzasOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPizzasOrdered.Location = new System.Drawing.Point(50, 78);
            this.NumPizzasOrdered.Name = "NumPizzasOrdered";
            this.NumPizzasOrdered.Size = new System.Drawing.Size(175, 16);
            this.NumPizzasOrdered.TabIndex = 1;
            this.NumPizzasOrdered.Text = "Number Pizza\'s Ordered";
            // 
            // ServersNameLabel
            // 
            this.ServersNameLabel.AutoSize = true;
            this.ServersNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersNameLabel.Location = new System.Drawing.Point(50, 38);
            this.ServersNameLabel.Name = "ServersNameLabel";
            this.ServersNameLabel.Size = new System.Drawing.Size(94, 16);
            this.ServersNameLabel.TabIndex = 0;
            this.ServersNameLabel.Text = "ServerName";
            // 
            // OrderToolTip
            // 
            this.OrderToolTip.IsBalloon = true;
            this.OrderToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.OrderToolTip.ToolTipTitle = "Info";
            // 
            // ClearToolTip
            // 
            this.ClearToolTip.IsBalloon = true;
            this.ClearToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ClearToolTip.ToolTipTitle = "Info";
            // 
            // Summary
            // 
            this.Summary.IsBalloon = true;
            this.Summary.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Summary.ToolTipTitle = "Info";
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.IsBalloon = true;
            this.ExitToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExitToolTip.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 693);
            this.Controls.Add(this.TableSummaryDataGroupBox);
            this.Controls.Add(this.CompanySummaryGroupBox);
            this.Controls.Add(this.SecondLogoPicBox);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.FoodTypeGroupBox);
            this.Controls.Add(this.ServingPanel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FirstLogoPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to PizzaBothán";
            ((System.ComponentModel.ISupportInitialize)(this.FirstLogoPicBox)).EndInit();
            this.ServingPanel.ResumeLayout(false);
            this.ServingPanel.PerformLayout();
            this.FoodTypeGroupBox.ResumeLayout(false);
            this.FoodTypeGroupBox.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecondLogoPicBox)).EndInit();
            this.CompanySummaryGroupBox.ResumeLayout(false);
            this.CompanySummaryGroupBox.PerformLayout();
            this.TableSummaryDataGroupBox.ResumeLayout(false);
            this.TableSummaryDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FirstLogoPicBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel ServingPanel;
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.TextBox TableNumberTextBox;
        private System.Windows.Forms.Label TableNumberLabel;
        private System.Windows.Forms.GroupBox FoodTypeGroupBox;
        private System.Windows.Forms.Label CalzoniPriceLabel;
        private System.Windows.Forms.Label PineapplePizzaPriceLabel;
        private System.Windows.Forms.Label PepperoniPizzaPriceLabel;
        private System.Windows.Forms.Label HamPizzaPriceLabel;
        private System.Windows.Forms.TextBox CalzoniTextBox;
        private System.Windows.Forms.TextBox PineapplePizzaTextBox;
        private System.Windows.Forms.TextBox PepperoniPizzaTextBox;
        private System.Windows.Forms.TextBox HamPizzaTextBox;
        private System.Windows.Forms.Label CalzoniLabel;
        private System.Windows.Forms.Label PineapplePizzaLabel;
        private System.Windows.Forms.Label PepperoniPizzaLabel;
        private System.Windows.Forms.Label HamPizzaLabel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.PictureBox SecondLogoPicBox;
        private System.Windows.Forms.GroupBox CompanySummaryGroupBox;
        private System.Windows.Forms.TextBox AvgTransactionValueTextBox;
        private System.Windows.Forms.TextBox TotalRecieptsTextBox;
        private System.Windows.Forms.TextBox NumPizzaOrderedTextBox;
        private System.Windows.Forms.TextBox TotalTransactionsTextBox;
        private System.Windows.Forms.Label AvgTransactionLabel;
        private System.Windows.Forms.Label TotalRecieptsLabel;
        private System.Windows.Forms.Label NumberOfPizzasOrderedLabel;
        private System.Windows.Forms.Label TotalTransactionsLabel;
        private System.Windows.Forms.GroupBox TableSummaryDataGroupBox;
        private System.Windows.Forms.TextBox TableTotalRecieptsTextBox;
        private System.Windows.Forms.TextBox TablePizzasOrderedTextBox;
        private System.Windows.Forms.TextBox DisplayServerTextBox;
        private System.Windows.Forms.Label TotalTableRecieptsLabel;
        private System.Windows.Forms.Label NumPizzasOrdered;
        private System.Windows.Forms.Label ServersNameLabel;
        private System.Windows.Forms.ToolTip OrderToolTip;
        private System.Windows.Forms.ToolTip ExitToolTip;
        private System.Windows.Forms.ToolTip Summary;
        private System.Windows.Forms.ToolTip ClearToolTip;
    }
}

