using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Newell
{
    public partial class AddQuote : Form
    {


        private Desk desk;
              
        private ErrorProvider widthError;
        private ErrorProvider depthError;


        public AddQuote()
        {
            InitializeComponent();


            // populate the desk materials options
            materialOptionBox.DataSource = Enum.GetValues(typeof(Desk.DeskMaterial));
            // populate the rush Order options
            List<int> rushOrder = new List<int> { 3, 5, 7, 14 };
            rushOrderBox.DataSource = (from numDays in rushOrder select numDays + " days").ToList();

            desk = new Desk(24, 12, 0, Desk.DeskMaterial.Laminate);
           
            widthError = new ErrorProvider();
            depthError = new ErrorProvider();
        }
        private void AddQuote_Load(object sender, EventArgs eventArgs)
        {
            TodaysDate.Text = DateTime.Now.ToLongDateString();

        }
        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu openMenu = new MainMenu();
            openMenu.Tag = this;
            openMenu.Show(this);
            Hide();
        }



        private void widthEntryBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidWidthEntry(widthEntryBox.Text, out errorMsg))
            {
                // cancel event and provide cue to identify where error is located
                e.Cancel = true;
                widthEntryBox.Select(0, widthEntryBox.Text.Length);

                // set error privider error with text to display
                this.widthError.SetError(widthEntryBox, errorMsg);
            }
           
            
        }
        private void widthEntryBox_Validated(object sender, EventArgs e)
        {
            // if all conditions have been met, clear errors
            widthError.SetError(widthEntryBox, "");
        }
        public bool ValidWidthEntry(string deskWidthString, out string errorMessage)
        {
            // confirm that box is not empty
            if (deskWidthString.Length == 0)
            {
                errorMessage = "Width is a required Value.";
                return false;

            }
            else
            {
                //if box is full ensure that it is an int
                int deskWidth = 0;
                try
                {
                  deskWidth = Int32.Parse(deskWidthString);
                    
                }
                catch (Exception e)
                {

                    throw new Exception("Value is not an Integer", e);
                    
                }
                // ensure box contains a value within parameters
                if(deskWidth >= 24 && deskWidth <= 96   )
                {
                    errorMessage = "";
                    return true;
                }
            }
            // call an error if value is not within parameters
            errorMessage = "Width must be greater than or equal to 24 and less than or equal to 96";
            return false;
        }


        // validate depth using keypress that checks for valid int input. 
        // use a compound statement and the char data type with IsControl and IsDigit methods
        private void depthEntryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // create key that stands for KeyChar event arguments
            char key = e.KeyChar;

            // ignore conrol char
            if (char.IsControl(key))
            {
                return;
            }
            // if key is  a digit allow entry
            if (char.IsDigit(key) == true)
            {
                depthError.SetError(this.depthEntryBox, String.Empty);
                try
                {

                    // if key is parsed, supply new depth
                    int depth = Int32.Parse(depthEntryBox.Text + key);

                    // supply depth only if it fits between 12 and 48;
                    if (depth >= 12 && depth <= 48)
                    {
                        desk.DeskDepth = depth;
                        return;
                    }
                    else
                    {
                        depthError.SetError(this.depthEntryBox, "Depth must be greater than or equal to 12, and less than or equal to 48.");
                    }

                }
                catch (Exception e2)
                {
                    throw new Exception("Value is not an integer", e2);
                }

            }
            else
            {
                // provide error message if not a digit
                depthError.SetError(this.depthEntryBox, "Please enter an Integer");
            }
           
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
           //todo

        }
    }
}
