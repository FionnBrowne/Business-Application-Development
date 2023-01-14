namespace Assignment1P2
/*
* Student Name: Fionn Browne
* Date 19/10/2022
* Module Business Application Development
* Assignment: 1 Exercise 2
* Assignment: Create an application will take the input of a user’s name, and then display a message of your choosing
which includes the users name in a label when the Display button is pressed. Allow the user to change the colour of text, interact with the image and allow to reset/exit the application
*/
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        //On application launch, set default colour to blue and disable the colour box
        private void Form1_Load(object sender, EventArgs e)
        {
            ColourBox.Enabled = false;

            PicBox2.Visible = false; 
            // Default colour
            UserNameOut.ForeColor = Color.Blue;
            // FontStyle is a flag enum and therefore you can set multiple styles by:
            UserNameOut.Font = new Font(UserNameOut.Font, FontStyle.Bold | FontStyle.Italic);

        }
        //Cant remove event handler without crashing the form design.
        private void UserNameOut_Click(object sender, EventArgs e)
        {
            
        }
        //Cant remove event handler without crashing the form design.
        private void ColourBox_Enter(object sender, EventArgs e)
        {

        }
        //Change user welcome colour to Blue
        private void BlueRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserNameOut.ForeColor = Color.Blue;
        }
        //Change user welcome colour to Purple
        private void PurpleRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserNameOut.ForeColor = Color.Purple;
        }
        //Change user welcome colour Green
        private void GreenRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserNameOut.ForeColor = Color.Green;
        }
        //Change user welcome colour to orange
        private void OrangeRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserNameOut.ForeColor = Color.Orange;
        }
        //When user clicks image change the text & cycke images
        private void PicBox_Click(object sender, EventArgs e)
        {
            this.ImageEvent.Text = "This is NUIG";
            PicBox2.Visible = true;
            PicBox.Visible = false;
        }
        //Cant remove event handler without crashing the form design.
        private void ImageEvent_Click(object sender, EventArgs e)
        {

        }
        //Uses an if else statement to check if any input was left empty.
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (UserNameIn.Text.Length == 0)//if no input given by the user display message.
            {
                UserNameOut.Text = "TEXT BOX IS EMPTY";
            }
            else//if the imput isint empty and has a length greater then 0 then display text and disable the text box.
            {
                this.UserNameOut.Text = "Hello " + UserNameIn.Text + "\n" + "Welcome to MS111";
                ColourBox.Enabled = true;
                UserNameIn.Enabled = false;
            }
        }
        //On click event resets the application to where its initial state
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameOut.Text = "";
            UserNameIn.Text = "";
            ImageEvent.Text = "Click Me!";
            PicBox.Visible = true;
            PicBox2.Visible = false;
            BlueRadio.Checked = false;
            OrangeRadio.Checked = false;
            PurpleRadio.Checked = false;
            GreenRadio.Checked = false;
            ColourBox.Enabled = false;
            UserNameIn.Enabled = true;
        }
        //When button clicked close the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Cant remove event handler without crashing the form design.
        private void UserNameIn_TextChanged(object sender, EventArgs e)
        {

        }
        //Cant remove event handler without crashing the form design.
        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        //On click event chages image and display text 
        private void PicBox2_Click(object sender, EventArgs e)
        {
            this.ImageEvent.Text = "Keep up the Good Work!";
            PicBox.Visible = true;
            PicBox2.Visible = false;
        }
    }
}