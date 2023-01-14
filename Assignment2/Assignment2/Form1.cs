using System;
using System.Windows.Forms;

/*
 * Student Name: Fionn Browne
 * Date 09/11/2022
 * Module Business Application Development
 * Assignment: 2
 * Assignment: Create a well-designed application that allows “PizzaBothán” staff to take table orders from
customers
 */

namespace Assignment2
{
    public partial class MainForm : Form
    {
        //initialize einvorment properties for the user
        public MainForm()
        {
            InitializeComponent();

            FirstLogoPicBox.Visible = true;
            StartButton.Visible = true;
            //for key shortcuts must be disabled
            StartButton.Enabled = true;
            ServingPanel.Visible = false;
            ControlPanel.Visible = false;
            ControlPanel.Enabled = false;
            FoodTypeGroupBox.Visible = false;
            TableSummaryDataGroupBox.Visible = false;
            CompanySummaryGroupBox.Visible = false;
            SecondLogoPicBox.Visible = false;
        }

        //Field Variables.
        const decimal HAM_PIZZA_COST = 7.99m, PEPPERONI_PIZZA_COST = 8.99m,
            PINAPPLE_PIZZA_COST = 9.99m, CALZONI_COST = 11.99m;
        int NumOfTransactions = 0, NumOfPizzasOrdered = 0;
        decimal TotalCompanyReciepts = 0m;
        //clearing interface for the next user.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //for key shortcuts must be disabled
            ControlPanel.Enabled = false;
            StartButton.Enabled = true;

            FirstLogoPicBox.Visible = true;
            StartButton.Visible = true;
            ServingPanel.Visible = false;
            ControlPanel.Visible = false;
            FoodTypeGroupBox.Visible = false;
            TableSummaryDataGroupBox.Visible = false;
            CompanySummaryGroupBox.Visible = false;
            SecondLogoPicBox.Visible = false;

            //resetting pizza menu & server panel
            HamPizzaTextBox.Text = "0";
            PepperoniPizzaTextBox.Text = "0";
            PineapplePizzaTextBox.Text = "0";
            CalzoniTextBox.Text = "0";
            TableNumberTextBox.Text = "";
            ServerNameTextBox.Text = "";
        }
        //load the user ordering inteface on click
        private void StartButton_Click(object sender, EventArgs e)
        {
            //update form name on click event
            MainForm.ActiveForm.Text = "Table Order";
            //for key shortcuts must be disabled
            StartButton.Enabled = false;
            ServingPanel.Enabled = true;
            FoodTypeGroupBox.Enabled = true;
            ControlPanel.Enabled = true;
            OrderButton.Enabled = true;
            SummaryButton.Enabled = false;
            //visibility 
            FirstLogoPicBox.Visible = false;
            StartButton.Visible = false;
            ServingPanel.Visible = true;
            ControlPanel.Visible = true;
            FoodTypeGroupBox.Visible = true;
            SecondLogoPicBox.Visible = true;
            HamPizzaPriceLabel.Visible = true;
            PepperoniPizzaPriceLabel.Visible = true;
            PineapplePizzaPriceLabel.Visible = true;
            CalzoniPriceLabel.Visible = true;

            //Setting up user start
            ServerNameTextBox.Focus();
            ServerNameTextBox.SelectAll();
        }
        //Exit the application on click
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Handles calculations and retaining data on Quantity of transactions, food ordered & money spent
        private void OrderButton_Click(object sender, EventArgs e)
        {
            //local variables
            int TableTotalPizzas, PinapplePizza, PepperoniPizza, Ham, Calzoni;
            decimal TableTotalReciept, PinapplePizzaTotal, PepperoniPizzaTotal, HamTotal, CalzoniTotal;
            string WaiterName = string.Empty;
            //checking if server information was filled out else dont allow order
            if (string.IsNullOrEmpty(ServerNameTextBox.Text) || string.IsNullOrEmpty(TableNumberTextBox.Text))
            {
                //if user is incorect, a popup will appear and when they click ok, they will have selected the server name text box to edit(one of two places where the error could be)
                MessageBox.Show("Sorry, server name and table number must be given.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerNameTextBox.Focus();
                ServerNameTextBox.SelectAll();
            }
            else
            {
                //if user correctly filled out server form
                try
                {
                    // Bring in user input and store in declared variables
                    WaiterName = ServerNameTextBox.Text;
                    try//food quantity check
                    {
                        DisplayServerTextBox.Text = WaiterName;

                        //checking
                        Ham = int.Parse(HamPizzaTextBox.Text);
                        PinapplePizza = int.Parse(PineapplePizzaTextBox.Text);
                        PepperoniPizza = int.Parse(PepperoniPizzaTextBox.Text);
                        Calzoni = int.Parse(CalzoniTextBox.Text);

                        TableTotalPizzas = Ham + PinapplePizza + PepperoniPizza + Calzoni;
                        //prevent negative value input & null entry
                        if (TableTotalPizzas <= 0)
                        {
                            MessageBox.Show("Must enter food order.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HamPizzaTextBox.Focus();
                            HamPizzaTextBox.SelectAll();
                        }
                        else
                        {
                            //Quantity of food ordered
                            try
                            {
                                TableTotalPizzas = Ham + PinapplePizza + PepperoniPizza + Calzoni;
                                TablePizzasOrderedTextBox.Text = TableTotalPizzas.ToString();
                                NumOfPizzasOrdered += TableTotalPizzas;

                                //price for the table calculations, display and changing display
                                try
                                {
                                    //calculating the price
                                    HamTotal = Ham * HAM_PIZZA_COST;
                                    PepperoniPizzaTotal = PepperoniPizza * PEPPERONI_PIZZA_COST;
                                    PinapplePizzaTotal = PinapplePizza * PINAPPLE_PIZZA_COST;
                                    CalzoniTotal = Calzoni * CALZONI_COST;

                                    TableTotalReciept = PinapplePizzaTotal + PepperoniPizzaTotal + HamTotal + CalzoniTotal;
                                    TableTotalRecieptsTextBox.Text = "€" + TableTotalReciept.ToString();

                                    TotalCompanyReciepts += TableTotalReciept;
                                    NumOfTransactions++;
                                    //changing table display
                                    TableSummaryDataGroupBox.Visible = true;
                                    //disabling order details
                                    ServingPanel.Enabled = false;
                                    FoodTypeGroupBox.Enabled = false;
                                    OrderButton.Enabled = false;
                                    SummaryButton.Enabled = true;
                                    //update form name on click event
                                    MainForm.ActiveForm.Text = "Table Summary";
                                }
                                //price
                                catch
                                {
                                    MessageBox.Show("Sorry, please contact the developer with the price error.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            //quantity
                            catch
                            {
                                MessageBox.Show("Must enter food order.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                HamPizzaTextBox.Focus();
                                HamPizzaTextBox.SelectAll();
                            }
                            //end if else statement
                        }
                    }
                    //food quantity
                    catch
                    {
                        MessageBox.Show("Sorry, please enter digits 0 and up.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        HamPizzaTextBox.Focus();
                        HamPizzaTextBox.SelectAll();
                    }
                }
                //name issue
                catch
                {
                    MessageBox.Show("Sorry something went wrong, please inform the developer with the error.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //end else
            }
        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //update form name on click event
            MainForm.ActiveForm.Text = "Company Summary Data";

            //Visibility
            HamPizzaPriceLabel.Visible = false;
            PepperoniPizzaPriceLabel.Visible = false;
            PineapplePizzaPriceLabel.Visible = false;
            CalzoniPriceLabel.Visible = false;
            ServingPanel.Visible = false;
            TableSummaryDataGroupBox.Visible = false;//bug
            CompanySummaryGroupBox.Visible = true;


            //calculating average transaction
            decimal AverageTransaction = 0m;
            AverageTransaction = TotalCompanyReciepts / NumOfTransactions;
            //rounding result to two decimal places
            Math.Round((decimal)AverageTransaction, 2);
            //checks if any of the main cirecteria is empty and if so skip displaying redirect user to key area, food entry
            if (NumOfTransactions == 0 || NumOfPizzasOrdered == 0 || TotalCompanyReciepts == 0)
            {
                MessageBox.Show("Please enter a order first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HamPizzaTextBox.Focus();
                HamPizzaTextBox.SelectAll();
            }
            else
            {
                //total transactions
                try
                {
                    TotalTransactionsTextBox.Text = NumOfTransactions.ToString();
                    //Qantity of pizzas ordered
                    try
                    {
                        NumPizzaOrderedTextBox.Text = NumOfPizzasOrdered.ToString();
                        // total reciepts
                        try
                        {
                            TotalRecieptsTextBox.Text = "€" + TotalCompanyReciepts.ToString();
                            //average table transaction
                            try
                            {
                                AvgTransactionValueTextBox.Text = "€" + AverageTransaction.ToString();
                            }
                            //average table transaction
                            catch
                            {
                                MessageBox.Show("Sorry, were having an issue with the average costs.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        // total reciepts
                        catch
                        {
                            MessageBox.Show("Sorry, were having an issue with the total reciepts.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //Qantity of pizzas ordered
                    catch
                    {
                        MessageBox.Show("Sorry, were having an issue with the record of pizzas.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //total transactions
                catch
                {
                    MessageBox.Show("Sorry, were having an issue with the total transaction count.", "500 Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //end of if else statement
            }
        }
    }
}