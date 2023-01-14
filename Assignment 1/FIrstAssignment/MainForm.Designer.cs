namespace Assignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RelationsButton = new System.Windows.Forms.Button();
            this.ShippingButton = new System.Windows.Forms.Button();
            this.MarketingButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DepContactLabel = new System.Windows.Forms.Label();
            this.DIsplayNumberLabel = new System.Windows.Forms.Label();
            this.ConNumberLabel = new System.Windows.Forms.Label();
            this.DisplayContactLabel = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RelationsButton
            // 
            this.RelationsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RelationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationsButton.Location = new System.Drawing.Point(63, 94);
            this.RelationsButton.Name = "RelationsButton";
            this.RelationsButton.Size = new System.Drawing.Size(254, 49);
            this.RelationsButton.TabIndex = 1;
            this.RelationsButton.Text = "&Customer Relations";
            this.RelationsButton.UseVisualStyleBackColor = false;
            this.RelationsButton.Click += new System.EventHandler(this.RelationsButton_Click);
            // 
            // ShippingButton
            // 
            this.ShippingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShippingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingButton.Location = new System.Drawing.Point(63, 268);
            this.ShippingButton.Name = "ShippingButton";
            this.ShippingButton.Size = new System.Drawing.Size(254, 49);
            this.ShippingButton.TabIndex = 4;
            this.ShippingButton.Text = "&Shipping";
            this.ShippingButton.UseVisualStyleBackColor = false;
            this.ShippingButton.Click += new System.EventHandler(this.ShippingButton_Click);
            // 
            // MarketingButton
            // 
            this.MarketingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MarketingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarketingButton.Location = new System.Drawing.Point(63, 152);
            this.MarketingButton.Name = "MarketingButton";
            this.MarketingButton.Size = new System.Drawing.Size(254, 49);
            this.MarketingButton.TabIndex = 5;
            this.MarketingButton.Text = "&Marketing";
            this.MarketingButton.UseVisualStyleBackColor = false;
            this.MarketingButton.Click += new System.EventHandler(this.MarketingButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(63, 210);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(254, 49);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "&Order Processing";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(656, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(254, 49);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DepContactLabel
            // 
            this.DepContactLabel.AutoSize = true;
            this.DepContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepContactLabel.Location = new System.Drawing.Point(620, 95);
            this.DepContactLabel.Name = "DepContactLabel";
            this.DepContactLabel.Size = new System.Drawing.Size(243, 29);
            this.DepContactLabel.TabIndex = 8;
            this.DepContactLabel.Text = "Department Contact";
            // 
            // DIsplayNumberLabel
            // 
            this.DIsplayNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DIsplayNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIsplayNumberLabel.Location = new System.Drawing.Point(619, 275);
            this.DIsplayNumberLabel.Name = "DIsplayNumberLabel";
            this.DIsplayNumberLabel.Size = new System.Drawing.Size(247, 42);
            this.DIsplayNumberLabel.TabIndex = 9;
            this.DIsplayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConNumberLabel
            // 
            this.ConNumberLabel.AutoSize = true;
            this.ConNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNumberLabel.Location = new System.Drawing.Point(620, 228);
            this.ConNumberLabel.Name = "ConNumberLabel";
            this.ConNumberLabel.Size = new System.Drawing.Size(188, 29);
            this.ConNumberLabel.TabIndex = 10;
            this.ConNumberLabel.Text = "Phone Number";
            // 
            // DisplayContactLabel
            // 
            this.DisplayContactLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayContactLabel.Location = new System.Drawing.Point(619, 139);
            this.DisplayContactLabel.Name = "DisplayContactLabel";
            this.DisplayContactLabel.Size = new System.Drawing.Size(247, 42);
            this.DisplayContactLabel.TabIndex = 11;
            this.DisplayContactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator.Location = new System.Drawing.Point(59, 391);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(284, 22);
            this.Creator.TabIndex = 12;
            this.Creator.Text = "Programmed by: Fionn Browne";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(919, 434);
            this.Controls.Add(this.Creator);
            this.Controls.Add(this.DisplayContactLabel);
            this.Controls.Add(this.ConNumberLabel);
            this.Controls.Add(this.DIsplayNumberLabel);
            this.Controls.Add(this.DepContactLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.MarketingButton);
            this.Controls.Add(this.ShippingButton);
            this.Controls.Add(this.RelationsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "C# Mail Ordering Firm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RelationsButton;
        private System.Windows.Forms.Button ShippingButton;
        private System.Windows.Forms.Button MarketingButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DepContactLabel;
        private System.Windows.Forms.Label DIsplayNumberLabel;
        private System.Windows.Forms.Label ConNumberLabel;
        private System.Windows.Forms.Label DisplayContactLabel;
        private System.Windows.Forms.Label Creator;
    }
}

