using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Student Name: Fionn Browne
* Date 19/10/2022
* Module Business Application Development
* Assignment: x
* Assignment: Create a form with a button. When the button is clicked it displays a   
* message in a message box
*/

namespace Assignment1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        //Test to write to console on start up
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome back!");
        }
        //ON click event button which Displays the contact name and number for the Orders
        private void OrderButton_Click(object sender, EventArgs e)
        {
            DisplayContactLabel.Text = "Ronan Browne";
            DIsplayNumberLabel.Text = "666-666-666";
        }
        //ON click event button which Displays the contact name and number for the Marketing
        private void MarketingButton_Click(object sender, EventArgs e)
        {
            DisplayContactLabel.Text = "Liam Smith";
            DIsplayNumberLabel.Text = "999-666-888";
        }
        //ON click event button which Displays the contact name and number for the customer Relations
        private void RelationsButton_Click(object sender, EventArgs e)
        {
            DisplayContactLabel.Text = "Robert Hynes";
            DIsplayNumberLabel.Text = "323-789-424";
        }
        //ON click event button which Displays the contact name and number for the shipping
        private void ShippingButton_Click(object sender, EventArgs e)
        {
            DisplayContactLabel.Text = "Nora Madius";
            DIsplayNumberLabel.Text = "323-545-345";
        }
        //ON click event button which closes the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
