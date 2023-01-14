namespace Assignment1P2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ColourBox = new System.Windows.Forms.GroupBox();
            this.OrangeRadio = new System.Windows.Forms.RadioButton();
            this.GreenRadio = new System.Windows.Forms.RadioButton();
            this.PurpleRadio = new System.Windows.Forms.RadioButton();
            this.BlueRadio = new System.Windows.Forms.RadioButton();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.UserChoice = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.UserNameOut = new System.Windows.Forms.Label();
            this.ImageEvent = new System.Windows.Forms.Label();
            this.UserNameIn = new System.Windows.Forms.TextBox();
            this.PicBox2 = new System.Windows.Forms.PictureBox();
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipColourBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPictureChange = new System.Windows.Forms.ToolTip(this.components);
            this.ColourBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.UserChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(32, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(111, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Your Name:";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ColourBox
            // 
            this.ColourBox.Controls.Add(this.OrangeRadio);
            this.ColourBox.Controls.Add(this.GreenRadio);
            this.ColourBox.Controls.Add(this.PurpleRadio);
            this.ColourBox.Controls.Add(this.BlueRadio);
            this.ColourBox.Location = new System.Drawing.Point(770, 264);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(156, 223);
            this.ColourBox.TabIndex = 3;
            this.ColourBox.TabStop = false;
            this.ColourBox.Text = "Choose a Colour:";
            this.toolTipColourBox.SetToolTip(this.ColourBox, "Must enter name, Then you can change colour.");
            this.ColourBox.Enter += new System.EventHandler(this.ColourBox_Enter);
            // 
            // OrangeRadio
            // 
            this.OrangeRadio.AutoSize = true;
            this.OrangeRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OrangeRadio.Location = new System.Drawing.Point(18, 181);
            this.OrangeRadio.Name = "OrangeRadio";
            this.OrangeRadio.Size = new System.Drawing.Size(90, 27);
            this.OrangeRadio.TabIndex = 8;
            this.OrangeRadio.TabStop = true;
            this.OrangeRadio.Text = "Orange";
            this.OrangeRadio.UseVisualStyleBackColor = true;
            this.OrangeRadio.CheckedChanged += new System.EventHandler(this.OrangeRadio_CheckedChanged);
            // 
            // GreenRadio
            // 
            this.GreenRadio.AutoSize = true;
            this.GreenRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GreenRadio.Location = new System.Drawing.Point(18, 134);
            this.GreenRadio.Name = "GreenRadio";
            this.GreenRadio.Size = new System.Drawing.Size(78, 27);
            this.GreenRadio.TabIndex = 7;
            this.GreenRadio.TabStop = true;
            this.GreenRadio.Text = "Green";
            this.GreenRadio.UseVisualStyleBackColor = true;
            this.GreenRadio.CheckedChanged += new System.EventHandler(this.GreenRadio_CheckedChanged);
            // 
            // PurpleRadio
            // 
            this.PurpleRadio.AutoSize = true;
            this.PurpleRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PurpleRadio.Location = new System.Drawing.Point(18, 87);
            this.PurpleRadio.Name = "PurpleRadio";
            this.PurpleRadio.Size = new System.Drawing.Size(83, 27);
            this.PurpleRadio.TabIndex = 6;
            this.PurpleRadio.TabStop = true;
            this.PurpleRadio.Text = "Purple";
            this.PurpleRadio.UseVisualStyleBackColor = true;
            this.PurpleRadio.CheckedChanged += new System.EventHandler(this.PurpleRadio_CheckedChanged);
            // 
            // BlueRadio
            // 
            this.BlueRadio.AutoSize = true;
            this.BlueRadio.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BlueRadio.Location = new System.Drawing.Point(18, 40);
            this.BlueRadio.Name = "BlueRadio";
            this.BlueRadio.Size = new System.Drawing.Size(66, 27);
            this.BlueRadio.TabIndex = 5;
            this.BlueRadio.TabStop = true;
            this.BlueRadio.Text = "Blue";
            this.BlueRadio.UseVisualStyleBackColor = true;
            this.BlueRadio.CheckedChanged += new System.EventHandler(this.BlueRadio_CheckedChanged);
            // 
            // PicBox
            // 
            this.PicBox.Image = global::Assignment1P2.Properties.Resources.NUI_Galway;
            this.PicBox.Location = new System.Drawing.Point(158, 202);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(414, 223);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.toolTipPictureChange.SetToolTip(this.PicBox, "Click me to change image");
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // UserChoice
            // 
            this.UserChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserChoice.Controls.Add(this.ExitButton);
            this.UserChoice.Controls.Add(this.ClearButton);
            this.UserChoice.Controls.Add(this.DisplayButton);
            this.UserChoice.Location = new System.Drawing.Point(770, 38);
            this.UserChoice.Name = "UserChoice";
            this.UserChoice.Size = new System.Drawing.Size(156, 186);
            this.UserChoice.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(14, 127);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 38);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "&Exit";
            this.toolTipExit.SetToolTip(this.ExitButton, "Press to exit application.");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(15, 73);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 38);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "&Clear";
            this.toolTipClear.SetToolTip(this.ClearButton, "Reset application");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DisplayButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DisplayButton.Location = new System.Drawing.Point(14, 17);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(125, 38);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "&Display";
            this.toolTipDisplay.SetToolTip(this.DisplayButton, "To display username and allow colour change.");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // UserNameOut
            // 
            this.UserNameOut.AutoSize = true;
            this.UserNameOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameOut.Location = new System.Drawing.Point(139, 89);
            this.UserNameOut.Name = "UserNameOut";
            this.UserNameOut.Size = new System.Drawing.Size(0, 41);
            this.UserNameOut.TabIndex = 5;
            this.UserNameOut.Click += new System.EventHandler(this.UserNameOut_Click);
            // 
            // ImageEvent
            // 
            this.ImageEvent.AutoSize = true;
            this.ImageEvent.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ImageEvent.Location = new System.Drawing.Point(305, 445);
            this.ImageEvent.Name = "ImageEvent";
            this.ImageEvent.Size = new System.Drawing.Size(84, 23);
            this.ImageEvent.TabIndex = 6;
            this.ImageEvent.Text = "Click Me!";
            this.ImageEvent.Click += new System.EventHandler(this.ImageEvent_Click);
            // 
            // UserNameIn
            // 
            this.UserNameIn.Location = new System.Drawing.Point(139, 40);
            this.UserNameIn.Name = "UserNameIn";
            this.UserNameIn.Size = new System.Drawing.Size(275, 27);
            this.UserNameIn.TabIndex = 7;
            this.UserNameIn.TextChanged += new System.EventHandler(this.UserNameIn_TextChanged);
            // 
            // PicBox2
            // 
            this.PicBox2.Image = global::Assignment1P2.Properties.Resources.Nuig2;
            this.PicBox2.Location = new System.Drawing.Point(158, 202);
            this.PicBox2.Name = "PicBox2";
            this.PicBox2.Size = new System.Drawing.Size(414, 223);
            this.PicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox2.TabIndex = 8;
            this.PicBox2.TabStop = false;
            this.toolTipPictureChange.SetToolTip(this.PicBox2, "Click me to change image");
            this.PicBox2.Click += new System.EventHandler(this.PicBox2_Click);
            // 
            // toolTipExit
            // 
            this.toolTipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipExit.ToolTipTitle = "Info";
            // 
            // toolTipClear
            // 
            this.toolTipClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipClear.ToolTipTitle = "Info";
            // 
            // toolTipDisplay
            // 
            this.toolTipDisplay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDisplay.ToolTipTitle = "Info";
            // 
            // toolTipColourBox
            // 
            this.toolTipColourBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipColourBox.ToolTipTitle = "Info";
            // 
            // toolTipPictureChange
            // 
            this.toolTipPictureChange.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPictureChange.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(941, 490);
            this.Controls.Add(this.PicBox2);
            this.Controls.Add(this.UserNameIn);
            this.Controls.Add(this.ImageEvent);
            this.Controls.Add(this.UserNameOut);
            this.Controls.Add(this.UserChoice);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "MainForm";
            this.Text = "Message of the Day";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ColourBox.ResumeLayout(false);
            this.ColourBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.UserChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private GroupBox ColourBox;
        private PictureBox PicBox;
        private Panel UserChoice;
        private RadioButton BlueRadio;
        private RadioButton OrangeRadio;
        private RadioButton GreenRadio;
        private RadioButton PurpleRadio;
        private Label UserNameOut;
        private Label ImageEvent;
        private Button DisplayButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox UserNameIn;
        private PictureBox PicBox2;
        private ToolTip toolTipExit;
        private ToolTip toolTipDisplay;
        private ToolTip toolTipClear;
        private ToolTip toolTipColourBox;
        private ToolTip toolTipPictureChange;
    }
}