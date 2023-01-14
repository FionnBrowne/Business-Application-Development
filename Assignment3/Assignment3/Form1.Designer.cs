namespace Assignment3
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
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.DepartureListBox = new System.Windows.Forms.ListBox();
            this.RatingGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NoHotelRadioButton = new System.Windows.Forms.RadioButton();
            this.PackeLnchPriceLabel = new System.Windows.Forms.Label();
            this.FiveStarHotelPrice = new System.Windows.Forms.Label();
            this.FourStarPriceLabel = new System.Windows.Forms.Label();
            this.ThreeStarLabelPrice = new System.Windows.Forms.Label();
            this.PackedLunchCheckBox = new System.Windows.Forms.CheckBox();
            this.FiveStarRadio = new System.Windows.Forms.RadioButton();
            this.FourStarRadio = new System.Windows.Forms.RadioButton();
            this.ThreeStarRaido = new System.Windows.Forms.RadioButton();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.AttendeesTextBox = new System.Windows.Forms.TextBox();
            this.TripPanel = new System.Windows.Forms.Panel();
            this.PriceHotelLabel = new System.Windows.Forms.Label();
            this.DiscountTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.LocationListLabel = new System.Windows.Forms.Label();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.DIsplayButton = new System.Windows.Forms.Button();
            this.TripDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DisplayTotalCostTextBox = new System.Windows.Forms.TextBox();
            this.TravelCostDisplayTextBox = new System.Windows.Forms.TextBox();
            this.HotelCostDisplayTextBox = new System.Windows.Forms.TextBox();
            this.HotelRatingDisplayTextBox = new System.Windows.Forms.TextBox();
            this.LocationDisplayTextBox = new System.Windows.Forms.TextBox();
            this.AttendeesDisplayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TravelCostLabel = new System.Windows.Forms.Label();
            this.HotelCostLabel = new System.Windows.Forms.Label();
            this.HotelRatingLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.AttendeesTotalLabel = new System.Windows.Forms.Label();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageTransactionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalNumDiscountTextBox = new System.Windows.Forms.TextBox();
            this.TotalPackedLunchTextBox = new System.Windows.Forms.TextBox();
            this.TotalHotelCost = new System.Windows.Forms.TextBox();
            this.TotalTravelFeesTextBox = new System.Windows.Forms.TextBox();
            this.SummaryTotalValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalBookingsLabel = new System.Windows.Forms.Label();
            this.DisplayToolTIp = new System.Windows.Forms.ToolTip(this.components);
            this.RatingGroupBox.SuspendLayout();
            this.TripPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.TripDetailsGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationListBox
            // 
            this.LocationListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 20;
            this.LocationListBox.Items.AddRange(new object[] {
            "Cliffs of Mohe        €55",
            "Kylemore Abbey  €50",
            "Bunratty Castle     €75",
            "The Burren            €45",
            "Connemara           €75",
            "Belmullet               €99"});
            this.LocationListBox.Location = new System.Drawing.Point(18, 56);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(221, 142);
            this.LocationListBox.TabIndex = 0;
            // 
            // DepartureListBox
            // 
            this.DepartureListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepartureListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureListBox.FormattingEnabled = true;
            this.DepartureListBox.ItemHeight = 20;
            this.DepartureListBox.Items.AddRange(new object[] {
            "07.00\t           20%",
            "08.00\t           10%",
            "09.00\t             5%",
            "10.00\t             0%",
            "11.00\t             0%",
            "13.00\t           25%"});
            this.DepartureListBox.Location = new System.Drawing.Point(302, 56);
            this.DepartureListBox.Name = "DepartureListBox";
            this.DepartureListBox.Size = new System.Drawing.Size(208, 142);
            this.DepartureListBox.TabIndex = 1;
            // 
            // RatingGroupBox
            // 
            this.RatingGroupBox.Controls.Add(this.label8);
            this.RatingGroupBox.Controls.Add(this.NoHotelRadioButton);
            this.RatingGroupBox.Controls.Add(this.PackeLnchPriceLabel);
            this.RatingGroupBox.Controls.Add(this.FiveStarHotelPrice);
            this.RatingGroupBox.Controls.Add(this.FourStarPriceLabel);
            this.RatingGroupBox.Controls.Add(this.ThreeStarLabelPrice);
            this.RatingGroupBox.Controls.Add(this.PackedLunchCheckBox);
            this.RatingGroupBox.Controls.Add(this.FiveStarRadio);
            this.RatingGroupBox.Controls.Add(this.FourStarRadio);
            this.RatingGroupBox.Controls.Add(this.ThreeStarRaido);
            this.RatingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingGroupBox.Location = new System.Drawing.Point(579, 47);
            this.RatingGroupBox.Name = "RatingGroupBox";
            this.RatingGroupBox.Size = new System.Drawing.Size(260, 169);
            this.RatingGroupBox.TabIndex = 2;
            this.RatingGroupBox.TabStop = false;
            this.RatingGroupBox.Text = "Hotel Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "€0";
            // 
            // NoHotelRadioButton
            // 
            this.NoHotelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHotelRadioButton.Location = new System.Drawing.Point(6, 25);
            this.NoHotelRadioButton.Name = "NoHotelRadioButton";
            this.NoHotelRadioButton.Size = new System.Drawing.Size(146, 24);
            this.NoHotelRadioButton.TabIndex = 8;
            this.NoHotelRadioButton.TabStop = true;
            this.NoHotelRadioButton.Text = "No Hotel";
            this.NoHotelRadioButton.UseVisualStyleBackColor = true;
            // 
            // PackeLnchPriceLabel
            // 
            this.PackeLnchPriceLabel.AutoSize = true;
            this.PackeLnchPriceLabel.Location = new System.Drawing.Point(168, 137);
            this.PackeLnchPriceLabel.Name = "PackeLnchPriceLabel";
            this.PackeLnchPriceLabel.Size = new System.Drawing.Size(64, 20);
            this.PackeLnchPriceLabel.TabIndex = 7;
            this.PackeLnchPriceLabel.Text = "€11.50";
            // 
            // FiveStarHotelPrice
            // 
            this.FiveStarHotelPrice.AutoSize = true;
            this.FiveStarHotelPrice.Location = new System.Drawing.Point(168, 110);
            this.FiveStarHotelPrice.Name = "FiveStarHotelPrice";
            this.FiveStarHotelPrice.Size = new System.Drawing.Size(49, 20);
            this.FiveStarHotelPrice.TabIndex = 6;
            this.FiveStarHotelPrice.Text = "€100";
            // 
            // FourStarPriceLabel
            // 
            this.FourStarPriceLabel.AutoSize = true;
            this.FourStarPriceLabel.Location = new System.Drawing.Point(168, 83);
            this.FourStarPriceLabel.Name = "FourStarPriceLabel";
            this.FourStarPriceLabel.Size = new System.Drawing.Size(39, 20);
            this.FourStarPriceLabel.TabIndex = 5;
            this.FourStarPriceLabel.Text = "€75";
            // 
            // ThreeStarLabelPrice
            // 
            this.ThreeStarLabelPrice.AutoSize = true;
            this.ThreeStarLabelPrice.Location = new System.Drawing.Point(168, 56);
            this.ThreeStarLabelPrice.Name = "ThreeStarLabelPrice";
            this.ThreeStarLabelPrice.Size = new System.Drawing.Size(39, 20);
            this.ThreeStarLabelPrice.TabIndex = 4;
            this.ThreeStarLabelPrice.Text = "€55";
            // 
            // PackedLunchCheckBox
            // 
            this.PackedLunchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackedLunchCheckBox.Location = new System.Drawing.Point(6, 139);
            this.PackedLunchCheckBox.Name = "PackedLunchCheckBox";
            this.PackedLunchCheckBox.Size = new System.Drawing.Size(153, 24);
            this.PackedLunchCheckBox.TabIndex = 3;
            this.PackedLunchCheckBox.Text = "Packed Lunch";
            this.PackedLunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiveStarRadio
            // 
            this.FiveStarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveStarRadio.Location = new System.Drawing.Point(6, 109);
            this.FiveStarRadio.Name = "FiveStarRadio";
            this.FiveStarRadio.Size = new System.Drawing.Size(104, 27);
            this.FiveStarRadio.TabIndex = 2;
            this.FiveStarRadio.TabStop = true;
            this.FiveStarRadio.Text = "5 Stars";
            this.FiveStarRadio.UseVisualStyleBackColor = true;
            // 
            // FourStarRadio
            // 
            this.FourStarRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourStarRadio.Location = new System.Drawing.Point(6, 79);
            this.FourStarRadio.Name = "FourStarRadio";
            this.FourStarRadio.Size = new System.Drawing.Size(104, 27);
            this.FourStarRadio.TabIndex = 1;
            this.FourStarRadio.TabStop = true;
            this.FourStarRadio.Text = "4 Stars";
            this.FourStarRadio.UseVisualStyleBackColor = true;
            // 
            // ThreeStarRaido
            // 
            this.ThreeStarRaido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeStarRaido.Location = new System.Drawing.Point(6, 52);
            this.ThreeStarRaido.Name = "ThreeStarRaido";
            this.ThreeStarRaido.Size = new System.Drawing.Size(146, 24);
            this.ThreeStarRaido.TabIndex = 0;
            this.ThreeStarRaido.TabStop = true;
            this.ThreeStarRaido.Text = "3 Stars";
            this.ThreeStarRaido.UseVisualStyleBackColor = true;
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesLabel.Location = new System.Drawing.Point(892, 56);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(110, 25);
            this.AttendeesLabel.TabIndex = 3;
            this.AttendeesLabel.Text = "Attendees";
            // 
            // AttendeesTextBox
            // 
            this.AttendeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttendeesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesTextBox.Location = new System.Drawing.Point(888, 101);
            this.AttendeesTextBox.Name = "AttendeesTextBox";
            this.AttendeesTextBox.Size = new System.Drawing.Size(125, 30);
            this.AttendeesTextBox.TabIndex = 4;
            this.AttendeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TripPanel
            // 
            this.TripPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TripPanel.Controls.Add(this.PriceHotelLabel);
            this.TripPanel.Controls.Add(this.DiscountTimeLabel);
            this.TripPanel.Controls.Add(this.TimeLabel);
            this.TripPanel.Controls.Add(this.PriceLabel);
            this.TripPanel.Controls.Add(this.LocationListLabel);
            this.TripPanel.Controls.Add(this.AttendeesLabel);
            this.TripPanel.Controls.Add(this.AttendeesTextBox);
            this.TripPanel.Controls.Add(this.RatingGroupBox);
            this.TripPanel.Controls.Add(this.DepartureListBox);
            this.TripPanel.Controls.Add(this.LocationListBox);
            this.TripPanel.Location = new System.Drawing.Point(16, 14);
            this.TripPanel.Name = "TripPanel";
            this.TripPanel.Size = new System.Drawing.Size(1039, 230);
            this.TripPanel.TabIndex = 5;
            // 
            // PriceHotelLabel
            // 
            this.PriceHotelLabel.AutoSize = true;
            this.PriceHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceHotelLabel.Location = new System.Drawing.Point(736, 33);
            this.PriceHotelLabel.Name = "PriceHotelLabel";
            this.PriceHotelLabel.Size = new System.Drawing.Size(103, 20);
            this.PriceHotelLabel.TabIndex = 9;
            this.PriceHotelLabel.Text = "Per Person";
            // 
            // DiscountTimeLabel
            // 
            this.DiscountTimeLabel.AutoSize = true;
            this.DiscountTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTimeLabel.Location = new System.Drawing.Point(426, 21);
            this.DiscountTimeLabel.Name = "DiscountTimeLabel";
            this.DiscountTimeLabel.Size = new System.Drawing.Size(84, 20);
            this.DiscountTimeLabel.TabIndex = 8;
            this.DiscountTimeLabel.Text = "Discount";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(298, 19);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(67, 24);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Times";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(174, 19);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(58, 24);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price";
            // 
            // LocationListLabel
            // 
            this.LocationListLabel.AutoSize = true;
            this.LocationListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationListLabel.Location = new System.Drawing.Point(18, 19);
            this.LocationListLabel.Name = "LocationListLabel";
            this.LocationListLabel.Size = new System.Drawing.Size(89, 24);
            this.LocationListLabel.TabIndex = 5;
            this.LocationListLabel.Text = "Location";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel.Controls.Add(this.ExitButton);
            this.OptionsPanel.Controls.Add(this.ClearButton);
            this.OptionsPanel.Controls.Add(this.SummaryButton);
            this.OptionsPanel.Controls.Add(this.BookButton);
            this.OptionsPanel.Controls.Add(this.DIsplayButton);
            this.OptionsPanel.Location = new System.Drawing.Point(867, 266);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(188, 330);
            this.OptionsPanel.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(13, 272);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(161, 42);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(13, 207);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(161, 42);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(13, 142);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(161, 42);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "&Summary";
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(13, 77);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(161, 42);
            this.BookButton.TabIndex = 1;
            this.BookButton.Text = "&Book";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // DIsplayButton
            // 
            this.DIsplayButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.DIsplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIsplayButton.Location = new System.Drawing.Point(13, 12);
            this.DIsplayButton.Name = "DIsplayButton";
            this.DIsplayButton.Size = new System.Drawing.Size(161, 42);
            this.DIsplayButton.TabIndex = 0;
            this.DIsplayButton.Text = "&Display";
            this.DisplayToolTIp.SetToolTip(this.DIsplayButton, "Displays the transaction value");
            this.DIsplayButton.UseVisualStyleBackColor = false;
            this.DIsplayButton.Click += new System.EventHandler(this.DIsplayButton_Click);
            // 
            // TripDetailsGroupBox
            // 
            this.TripDetailsGroupBox.Controls.Add(this.DisplayTotalCostTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.TravelCostDisplayTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.HotelCostDisplayTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.HotelRatingDisplayTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.LocationDisplayTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.AttendeesDisplayTextBox);
            this.TripDetailsGroupBox.Controls.Add(this.label7);
            this.TripDetailsGroupBox.Controls.Add(this.TravelCostLabel);
            this.TripDetailsGroupBox.Controls.Add(this.HotelCostLabel);
            this.TripDetailsGroupBox.Controls.Add(this.HotelRatingLabel);
            this.TripDetailsGroupBox.Controls.Add(this.LocationLabel);
            this.TripDetailsGroupBox.Controls.Add(this.AttendeesTotalLabel);
            this.TripDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TripDetailsGroupBox.Location = new System.Drawing.Point(12, 266);
            this.TripDetailsGroupBox.Name = "TripDetailsGroupBox";
            this.TripDetailsGroupBox.Size = new System.Drawing.Size(844, 330);
            this.TripDetailsGroupBox.TabIndex = 7;
            this.TripDetailsGroupBox.TabStop = false;
            this.TripDetailsGroupBox.Text = "Trip Details";
            // 
            // DisplayTotalCostTextBox
            // 
            this.DisplayTotalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalCostTextBox.Location = new System.Drawing.Point(530, 157);
            this.DisplayTotalCostTextBox.Name = "DisplayTotalCostTextBox";
            this.DisplayTotalCostTextBox.Size = new System.Drawing.Size(226, 26);
            this.DisplayTotalCostTextBox.TabIndex = 13;
            this.DisplayTotalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TravelCostDisplayTextBox
            // 
            this.TravelCostDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelCostDisplayTextBox.Location = new System.Drawing.Point(158, 279);
            this.TravelCostDisplayTextBox.Name = "TravelCostDisplayTextBox";
            this.TravelCostDisplayTextBox.Size = new System.Drawing.Size(226, 26);
            this.TravelCostDisplayTextBox.TabIndex = 11;
            this.TravelCostDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotelCostDisplayTextBox
            // 
            this.HotelCostDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCostDisplayTextBox.Location = new System.Drawing.Point(158, 217);
            this.HotelCostDisplayTextBox.Name = "HotelCostDisplayTextBox";
            this.HotelCostDisplayTextBox.Size = new System.Drawing.Size(226, 26);
            this.HotelCostDisplayTextBox.TabIndex = 10;
            this.HotelCostDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotelRatingDisplayTextBox
            // 
            this.HotelRatingDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRatingDisplayTextBox.Location = new System.Drawing.Point(158, 155);
            this.HotelRatingDisplayTextBox.Name = "HotelRatingDisplayTextBox";
            this.HotelRatingDisplayTextBox.Size = new System.Drawing.Size(226, 26);
            this.HotelRatingDisplayTextBox.TabIndex = 9;
            this.HotelRatingDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationDisplayTextBox
            // 
            this.LocationDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationDisplayTextBox.Location = new System.Drawing.Point(158, 93);
            this.LocationDisplayTextBox.Name = "LocationDisplayTextBox";
            this.LocationDisplayTextBox.Size = new System.Drawing.Size(226, 26);
            this.LocationDisplayTextBox.TabIndex = 8;
            this.LocationDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttendeesDisplayTextBox
            // 
            this.AttendeesDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesDisplayTextBox.Location = new System.Drawing.Point(158, 31);
            this.AttendeesDisplayTextBox.Name = "AttendeesDisplayTextBox";
            this.AttendeesDisplayTextBox.Size = new System.Drawing.Size(226, 26);
            this.AttendeesDisplayTextBox.TabIndex = 7;
            this.AttendeesDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Cost";
            // 
            // TravelCostLabel
            // 
            this.TravelCostLabel.AutoSize = true;
            this.TravelCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelCostLabel.Location = new System.Drawing.Point(11, 282);
            this.TravelCostLabel.Name = "TravelCostLabel";
            this.TravelCostLabel.Size = new System.Drawing.Size(124, 25);
            this.TravelCostLabel.TabIndex = 4;
            this.TravelCostLabel.Text = "Travel Cost";
            // 
            // HotelCostLabel
            // 
            this.HotelCostLabel.AutoSize = true;
            this.HotelCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelCostLabel.Location = new System.Drawing.Point(11, 219);
            this.HotelCostLabel.Name = "HotelCostLabel";
            this.HotelCostLabel.Size = new System.Drawing.Size(113, 25);
            this.HotelCostLabel.TabIndex = 3;
            this.HotelCostLabel.Text = "Hotel Cost";
            // 
            // HotelRatingLabel
            // 
            this.HotelRatingLabel.AutoSize = true;
            this.HotelRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelRatingLabel.Location = new System.Drawing.Point(11, 156);
            this.HotelRatingLabel.Name = "HotelRatingLabel";
            this.HotelRatingLabel.Size = new System.Drawing.Size(129, 25);
            this.HotelRatingLabel.TabIndex = 2;
            this.HotelRatingLabel.Text = "Hotel Rating";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(11, 93);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(94, 25);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location";
            // 
            // AttendeesTotalLabel
            // 
            this.AttendeesTotalLabel.AutoSize = true;
            this.AttendeesTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesTotalLabel.Location = new System.Drawing.Point(11, 30);
            this.AttendeesTotalLabel.Name = "AttendeesTotalLabel";
            this.AttendeesTotalLabel.Size = new System.Drawing.Size(110, 25);
            this.AttendeesTotalLabel.TabIndex = 0;
            this.AttendeesTotalLabel.Text = "Attendees";
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.AverageTransactionTextBox);
            this.SummaryGroupBox.Controls.Add(this.label6);
            this.SummaryGroupBox.Controls.Add(this.TotalTransactionsTextBox);
            this.SummaryGroupBox.Controls.Add(this.label1);
            this.SummaryGroupBox.Controls.Add(this.TotalNumDiscountTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalPackedLunchTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalHotelCost);
            this.SummaryGroupBox.Controls.Add(this.TotalTravelFeesTextBox);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalValueTextBox);
            this.SummaryGroupBox.Controls.Add(this.label2);
            this.SummaryGroupBox.Controls.Add(this.label3);
            this.SummaryGroupBox.Controls.Add(this.label4);
            this.SummaryGroupBox.Controls.Add(this.label5);
            this.SummaryGroupBox.Controls.Add(this.TotalBookingsLabel);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(195, 260);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(549, 335);
            this.SummaryGroupBox.TabIndex = 8;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary Details";
            // 
            // AverageTransactionTextBox
            // 
            this.AverageTransactionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTransactionTextBox.Location = new System.Drawing.Point(318, 168);
            this.AverageTransactionTextBox.Name = "AverageTransactionTextBox";
            this.AverageTransactionTextBox.Size = new System.Drawing.Size(220, 26);
            this.AverageTransactionTextBox.TabIndex = 26;
            this.AverageTransactionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Average Transaction";
            // 
            // TotalTransactionsTextBox
            // 
            this.TotalTransactionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactionsTextBox.Location = new System.Drawing.Point(318, 294);
            this.TotalTransactionsTextBox.Name = "TotalTransactionsTextBox";
            this.TotalTransactionsTextBox.Size = new System.Drawing.Size(220, 26);
            this.TotalTransactionsTextBox.TabIndex = 24;
            this.TotalTransactionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Transactions";
            // 
            // TotalNumDiscountTextBox
            // 
            this.TotalNumDiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumDiscountTextBox.Location = new System.Drawing.Point(318, 252);
            this.TotalNumDiscountTextBox.Name = "TotalNumDiscountTextBox";
            this.TotalNumDiscountTextBox.Size = new System.Drawing.Size(220, 26);
            this.TotalNumDiscountTextBox.TabIndex = 22;
            this.TotalNumDiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalPackedLunchTextBox
            // 
            this.TotalPackedLunchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPackedLunchTextBox.Location = new System.Drawing.Point(318, 210);
            this.TotalPackedLunchTextBox.Name = "TotalPackedLunchTextBox";
            this.TotalPackedLunchTextBox.Size = new System.Drawing.Size(220, 26);
            this.TotalPackedLunchTextBox.TabIndex = 21;
            this.TotalPackedLunchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalHotelCost
            // 
            this.TotalHotelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHotelCost.Location = new System.Drawing.Point(318, 126);
            this.TotalHotelCost.Name = "TotalHotelCost";
            this.TotalHotelCost.Size = new System.Drawing.Size(220, 26);
            this.TotalHotelCost.TabIndex = 20;
            this.TotalHotelCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTravelFeesTextBox
            // 
            this.TotalTravelFeesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTravelFeesTextBox.Location = new System.Drawing.Point(318, 84);
            this.TotalTravelFeesTextBox.Name = "TotalTravelFeesTextBox";
            this.TotalTravelFeesTextBox.Size = new System.Drawing.Size(220, 26);
            this.TotalTravelFeesTextBox.TabIndex = 19;
            this.TotalTravelFeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SummaryTotalValueTextBox
            // 
            this.SummaryTotalValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalValueTextBox.Location = new System.Drawing.Point(318, 42);
            this.SummaryTotalValueTextBox.Name = "SummaryTotalValueTextBox";
            this.SummaryTotalValueTextBox.Size = new System.Drawing.Size(220, 26);
            this.SummaryTotalValueTextBox.TabIndex = 18;
            this.SummaryTotalValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Number of discounts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Packed Lunch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Hotel Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Travel Fees";
            // 
            // TotalBookingsLabel
            // 
            this.TotalBookingsLabel.AutoSize = true;
            this.TotalBookingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBookingsLabel.Location = new System.Drawing.Point(18, 41);
            this.TotalBookingsLabel.Name = "TotalBookingsLabel";
            this.TotalBookingsLabel.Size = new System.Drawing.Size(218, 25);
            this.TotalBookingsLabel.TabIndex = 12;
            this.TotalBookingsLabel.Text = "Total Value Bookings";
            // 
            // DisplayToolTIp
            // 
            this.DisplayToolTIp.IsBalloon = true;
            this.DisplayToolTIp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DisplayToolTIp.ToolTipTitle = "Display";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 692);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.TripDetailsGroupBox);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.TripPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mild Atlantic Bus Tours";
            this.RatingGroupBox.ResumeLayout(false);
            this.RatingGroupBox.PerformLayout();
            this.TripPanel.ResumeLayout(false);
            this.TripPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.TripDetailsGroupBox.ResumeLayout(false);
            this.TripDetailsGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LocationListBox;
        private System.Windows.Forms.ListBox DepartureListBox;
        private System.Windows.Forms.GroupBox RatingGroupBox;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.TextBox AttendeesTextBox;
        private System.Windows.Forms.Panel TripPanel;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.GroupBox TripDetailsGroupBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button DIsplayButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TravelCostLabel;
        private System.Windows.Forms.Label HotelCostLabel;
        private System.Windows.Forms.Label HotelRatingLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label AttendeesTotalLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label LocationListLabel;
        private System.Windows.Forms.CheckBox PackedLunchCheckBox;
        private System.Windows.Forms.RadioButton FiveStarRadio;
        private System.Windows.Forms.RadioButton FourStarRadio;
        private System.Windows.Forms.RadioButton ThreeStarRaido;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label PackeLnchPriceLabel;
        private System.Windows.Forms.Label FiveStarHotelPrice;
        private System.Windows.Forms.Label FourStarPriceLabel;
        private System.Windows.Forms.Label ThreeStarLabelPrice;
        private System.Windows.Forms.Label PriceHotelLabel;
        private System.Windows.Forms.Label DiscountTimeLabel;
        private System.Windows.Forms.TextBox DisplayTotalCostTextBox;
        private System.Windows.Forms.TextBox TravelCostDisplayTextBox;
        private System.Windows.Forms.TextBox HotelCostDisplayTextBox;
        private System.Windows.Forms.TextBox HotelRatingDisplayTextBox;
        private System.Windows.Forms.TextBox LocationDisplayTextBox;
        private System.Windows.Forms.TextBox AttendeesDisplayTextBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.TextBox TotalNumDiscountTextBox;
        private System.Windows.Forms.TextBox TotalPackedLunchTextBox;
        private System.Windows.Forms.TextBox TotalHotelCost;
        private System.Windows.Forms.TextBox TotalTravelFeesTextBox;
        private System.Windows.Forms.TextBox SummaryTotalValueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalBookingsLabel;
        private System.Windows.Forms.TextBox AverageTransactionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTransactionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton NoHotelRadioButton;
        public System.Windows.Forms.ToolTip DisplayToolTIp;
    }
}

