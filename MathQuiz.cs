using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_F2020_NewellBrycen
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer to generate random numbers.
        Random randomizer = new Random();

        // Two integer variables to store the numbers from randomizer for the addition problem.
        int addend1;
        int addend2;

        // integer variables to store the numbers for subtraction problem
        int minuend;
        int subtrahend;

        // integer for multiplication
        int multiplicand;
        int multiplier;

        // integer for division
        int dividend;
        int divisor;

        // integer responsible for keeping track of remaining time.
        int timeLeft;



        // Start the Quiz by filling in all of the problems and starting the timer 
        public void StartTheQuiz()
        {
            //Fill in Addition problems
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two ranom numbers int strings for display
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // set sum to 0 before calculations.
            sum.Value = 0;

            // subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // divsion problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            timeLabel.BackColor = Color.White;

        }

        // check answer to see if the user got everything right
        // <returns> True if answer's correct, false otherwise. </returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void currentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // if CheckTheAnswer() is true, then user got the answer right. Stop Time and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // if CheckTheAnswer() returns false, keep counting down
                // display the time remaining on Time Left Label
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft <= 5 && timeLeft > 0)
                {
                    // if timeLeft is less than or equal to 5 seconds, warn user by changing time Label color to red
                    timeLabel.BackColor = Color.Red;
                }
                

            }
            else
            {
                // if time runs out, stop timer, show message, fill in the answers
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void sum_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
