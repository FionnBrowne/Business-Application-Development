using System;
using System.Windows.Forms;

/*
 * Student Name: Fionn Browne
 * Date 30/11/2022
 * Module Business Application Development
 * Assignment: 3
 * Assignment: Create a well-designed application for Mild Atlantic Bus Tours (MABT), a company that
 * provides bus excursions to well-known landmarks on the west coast of Ireland. 
 */

namespace Assignment3
{
    public partial class MainForm : Form
    {
        //list box items
        const string LOCATION1 = "Cliffs of Moher", LOCATION2 = "Kylemore Abbey", LOCATION3 = "Bunratty Castle",
            LOCATION4 = "The Burren", LOCATION5 = "Connemara", LOCATION6 = "Belmullet";
        const decimal LOCATION1COST = 55m, LOCATION2COST = 50m, LOCATION3COST = 75m, LOCATION4COST = 45m,
            LOCATION5COST = 75m, LOCATION6COST = 99m;
        //times list box
        const string TIME1 = "07.00", TIME2 = "08.00", TIME3 = "09.00",
            TIME4 = "10.00", TIME5 = "11.00", TIME6 = "13.00";
        const decimal DISCOUNT1TIME = .20m, DISCOUNT2TIME = .10m, DISCOUNT3TIME = .05m,
            DISCOUNT4TIME = 0m, DISCOUNT5TIME = 0m, DISCOUNT6TIME = .25m;
        //hotel group box
        const decimal THREESTAR = 55m, FOURSTAR = 75m, FIVESTAR = 100m, NOHOTEL = 0m;
        //Field Variales
        const decimal PACKEDLUNCH = 11.5m, THREEPEOPLEDISCOUNT = .05m;
        decimal TotalValueBookings, TotalPackedLunch, TotalTravelFees, TotalHotelCostSummary,
            AverageTransactionValue, TotalLocationCost;
        int  TotalTransactions, NumberOfDiscounts;
        //display use
        decimal TravelFees, hotelCost, BookingCost = 0m,
             DiscountedBookingCost, LunchBox, DisplayTotal, DisplayTravelFees;
        string Location, Time, HotelRating;
        int Attendees;




        //start state of project
        public MainForm()
        {
            InitializeComponent();
            //changing views
            SummaryGroupBox.Visible = false;
            SummaryButton.Enabled = false;
            //Disabling display text box so user cant change variables
            AttendeesDisplayTextBox.Enabled = false;
            LocationDisplayTextBox.Enabled = false;
            HotelRatingDisplayTextBox.Enabled = false;
            HotelCostDisplayTextBox.Enabled = false;
            TravelCostDisplayTextBox.Enabled = false;
            DisplayTotalCostTextBox.Enabled = false;
            SummaryTotalValueTextBox.Enabled = false;
            TotalTravelFeesTextBox.Enabled = false;
            TotalHotelCost.Enabled = false;
            AverageTransactionTextBox.Enabled = false;
            TotalPackedLunchTextBox.Enabled = false;
            TotalNumDiscountTextBox.Enabled = false;
            TotalTransactionsTextBox.Enabled = false;
        }
        private void DIsplayButton_Click(object sender, EventArgs e)
        {
            int LocationIndex, TravelIndex;
            decimal LocationCost= 0m, TimeDiscount = 0m;
            //check if antends is not empty
            if (AttendeesTextBox.Text != "")
            {
                //checking parsing
                if (int.TryParse(AttendeesTextBox.Text, out Attendees ))
                {
                    //require a posotive number of Attendees
                    if (Attendees > 0)
                    {
                        //checking if value was sleceted. starts at 0
                        if (LocationListBox.SelectedIndex != -1)
                        {
                            //checking if value was sleceted. starts at 0
                            if (DepartureListBox.SelectedIndex != -1)
                            {
                                //assigning values for checking which item was selceted 
                                LocationIndex = LocationListBox.SelectedIndex;
                                TravelIndex = DepartureListBox.SelectedIndex;
                                //checking which location user chose
                                switch (LocationIndex)
                                {
                                    case 0:
                                        Location = LOCATION1; LocationCost = LOCATION1COST;
                                        break;
                                    case 1:
                                        Location = LOCATION2; LocationCost = LOCATION2COST;
                                        break;
                                    case 2:
                                        Location = LOCATION3; LocationCost = LOCATION3COST;
                                        break;
                                    case 3:
                                        Location = LOCATION4; LocationCost = LOCATION4COST;
                                        break;
                                    case 4:
                                        Location = LOCATION5; LocationCost = LOCATION5COST;
                                        break;
                                    case 5:
                                        Location = LOCATION6; LocationCost = LOCATION6COST;
                                        break;
                                }
                                //checking what time user chose
                                switch (TravelIndex)
                                {
                                    case 0:
                                        Time = TIME1; TimeDiscount = DISCOUNT1TIME;
                                        break;
                                    case 1:
                                        Time = TIME2; TimeDiscount = DISCOUNT2TIME;
                                        break;
                                    case 2:
                                        Time = TIME3; TimeDiscount = DISCOUNT3TIME;
                                        break;
                                    case 3:
                                        Time = TIME4; TimeDiscount = DISCOUNT4TIME;
                                        break;
                                    case 4:
                                        Time = TIME5; TimeDiscount = DISCOUNT5TIME;
                                        break;
                                    case 5:
                                        Time = TIME6; TimeDiscount = DISCOUNT6TIME;
                                        break;
                                }

                                //checking input for accomadating radio buttons
                                if (ThreeStarRaido.Checked == true)
                                {
                                    hotelCost = Attendees * THREESTAR;
                                    HotelRating = "3 Stars";
                                }
                                else if (FourStarRadio.Checked == true)
                                {
                                    hotelCost = Attendees * FOURSTAR;
                                    HotelRating = "4 Stars";
                                }
                                else if (FiveStarRadio.Checked == true)
                                {
                                    hotelCost = Attendees * FIVESTAR;
                                    HotelRating = "5 Stars";
                                }
                                else if (NoHotelRadioButton.Checked == true)
                                {
                                    hotelCost = Attendees * NOHOTEL;
                                    HotelRating = "No Hotel";
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, please select you accomadation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    RatingGroupBox.Focus();
                                }
                                //checking if lunchbox was ticked
                                if (PackedLunchCheckBox.Checked == true)
                                {
                                    LunchBox = PACKEDLUNCH * Attendees;
                                }
                                else
                                {
                                    LunchBox = 0;
                                }
                                //discount for 3
                                if (Attendees >= 3 && PackedLunchCheckBox.Checked == true)
                                {
                                    TravelFees = LocationCost - (LocationCost * TimeDiscount);
                                    DisplayTravelFees = TravelFees * Attendees;
                                    BookingCost = (TravelFees * Attendees) + hotelCost + LunchBox;
                                    DiscountedBookingCost = BookingCost - (BookingCost * THREEPEOPLEDISCOUNT);
                                    //for popup as there are two outputs one with and one without discount value
                                    DisplayTotal = DiscountedBookingCost;
                                    //assigning global variables
                                    TotalValueBookings += DiscountedBookingCost;
                                    TotalLocationCost += LocationCost;
                                    TotalTravelFees += TravelFees;
                                    TotalPackedLunch += LunchBox;
                                    TotalHotelCostSummary += hotelCost;
                                    //output values
                                    AttendeesDisplayTextBox.Text = Attendees.ToString();
                                    LocationDisplayTextBox.Text = Location.ToString();
                                    HotelRatingDisplayTextBox.Text = HotelRating.ToString();
                                    HotelCostDisplayTextBox.Text = hotelCost.ToString();
                                    TravelCostDisplayTextBox.Text = TravelFees.ToString();
                                    DisplayTotalCostTextBox.Text = Math.Round(DiscountedBookingCost,2).ToString();
                                    //adding a discount tracker
                                    if (TimeDiscount > 0 || Attendees >= 3)
                                    {
                                        NumberOfDiscounts++;
                                    }
                                }
                                //no discount for 3 people
                                else
                                {
                                    TravelFees = LocationCost - (LocationCost * TimeDiscount);
                                    DisplayTravelFees = TravelFees * Attendees;
                                    BookingCost = (TravelFees * Attendees) + hotelCost + LunchBox;
                                    DisplayTotal = BookingCost;

                                    //assigning global variables
                                    TotalValueBookings += BookingCost;
                                    TotalLocationCost += LocationCost;
                                    TotalTravelFees += TravelFees;
                                    TotalPackedLunch += LunchBox;
                                    TotalHotelCostSummary += hotelCost;
                                    //display values to user
                                    AttendeesDisplayTextBox.Text = Attendees.ToString();
                                    LocationDisplayTextBox.Text = Location.ToString();
                                    HotelRatingDisplayTextBox.Text = HotelRating.ToString();
                                    HotelCostDisplayTextBox.Text = hotelCost.ToString();
                                    TravelCostDisplayTextBox.Text = TravelFees.ToString();
                                    DisplayTotalCostTextBox.Text = Math.Round(BookingCost, 2).ToString();

                                    if (TimeDiscount > 0)
                                    {
                                        NumberOfDiscounts++;
                                    }
                                }
                                //controlling ui available
                                BookButton.Enabled = Enabled;
                                TripDetailsGroupBox.Visible = true;
                                SummaryGroupBox.Visible = false;
                                SummaryButton.Enabled = false;
                            }
                            else//for departure time
                            {
                                MessageBox.Show("Please enter a desired time", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                DepartureListBox.Focus();
                            }
                        }
                        else//for location selection
                        {
                                MessageBox.Show("Please enter a desired location", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LocationListBox.Focus();
                        }
                        
                    }
                    else//for Attendees negative value
                    {
                        MessageBox.Show("Number of Attendees required", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AttendeesTextBox.Focus();
                    }
                }
                else//for parsing Attendees value
                {
                    MessageBox.Show("Number of Attendees required", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttendeesTextBox.Focus();
                }
            }
            else//for attendes check
            {
                MessageBox.Show("Number of Attendees required", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AttendeesTextBox.Focus();
            }
        }
        //when input correct display a popup
        private void BookButton_Click(object sender, EventArgs e)
        {
            //check if a booking has taken place
            if (BookingCost > 0)
            {
                DisplayTotal = Math.Round(DisplayTotal, 2);
                DialogResult Result;
                //display text for popup
                String trip = "\n You have selected " + Location + " for " + Attendees
                        + "\n\n The total cost is €" + DisplayTotal + " which includes €" + hotelCost + " hotel cost" +
                        "\n\n , €" + DisplayTravelFees + 
                        "\n\n travel fees and a total of €" + LunchBox + " packed lunches."
                        + "\n\n The departure time is " + Time
                        + "\n\n Do you wish to proceed?";
                //checking if user wants to purchase
                Result = MessageBox.Show(trip, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //checking user input on popup
                if (Result == DialogResult.Yes)
                {
                    TotalTransactions++;
                    SummaryButton.Enabled = true;
                    TripDetailsGroupBox.Visible = false;
                    BookButton.Enabled = false;
                    //call clear method
                    ClearButton_Click(sender, e);
                }
                else
                {
                    //call clear method
                    ClearButton_Click(sender, e);                
                }
            }
            //if display values are incorect or missing
            else
            {
                MessageBox.Show("Please fill out trip Details", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AttendeesTextBox.Focus();
                AttendeesLabel.Select();
            }
        }
        //display total history
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //if no transaction finished done display
            if (TotalTransactions > 0)
            {
                //change visible display
                SummaryGroupBox.Visible = true;
                TripDetailsGroupBox.Visible=false;
                TripPanel.Visible = false;
                AverageTransactionValue = TotalValueBookings / TotalTransactions;
                //display variables
                SummaryTotalValueTextBox.Text = Math.Round(TotalValueBookings, 2).ToString();
                TotalTravelFeesTextBox.Text = Math.Round(TotalTravelFees, 2).ToString();
                TotalHotelCost.Text = Math.Round(TotalHotelCostSummary, 2).ToString();
                AverageTransactionTextBox.Text = Math.Round(AverageTransactionValue, 2).ToString();
                TotalPackedLunchTextBox.Text = TotalPackedLunch.ToString();
                TotalNumDiscountTextBox.Text = NumberOfDiscounts.ToString();
                TotalTransactionsTextBox.Text = TotalTransactions.ToString();
            }
            //fail safe check
            else
            {
                MessageBox.Show("Please fill out trip Details", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AttendeesTextBox.Focus();
                AttendeesLabel.Select();
            }
        }
        //reset display but not summary values
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //set view
            TripDetailsGroupBox.Visible = true;
            SummaryGroupBox.Visible = false;
            TripPanel.Visible = true;
            
            //reset choices
            LocationListBox.SelectedIndex = LocationListBox.SelectedIndex = -1;
            DepartureListBox.SelectedIndex = LocationListBox.SelectedIndex = -1;
            PackedLunchCheckBox.Checked = false;
            AttendeesTextBox.Text = "";
            ThreeStarRaido.Checked = false;
            FourStarRadio.Checked = false;
            FiveStarRadio.Checked = false;
            NoHotelRadioButton.Checked = false;
            //reset order values
            TravelFees = 0;
            Attendees = 0;
            BookingCost = 0;
            DisplayTotal = 0;
            DiscountedBookingCost = 0;
            LunchBox = 0;
            hotelCost = 0;
            Location = "";
            Time = "";
            HotelRating = "";
            //reset display group box
            AttendeesDisplayTextBox.Text = "";
            LocationDisplayTextBox.Text = "";
            HotelRatingDisplayTextBox.Text = "";
            HotelCostDisplayTextBox.Text = "";
            TravelCostDisplayTextBox.Text = "";
            DisplayTotalCostTextBox.Text = "";
        }
        //exits the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}//end
