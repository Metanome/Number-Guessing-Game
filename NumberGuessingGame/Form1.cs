using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();

        int randnum = 0;
        int guesses = 0;
        int score = 0;

        string userName = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
            loadGenerator();
            lblWelcomeUser.Text = "Welcome " + userName;
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int input;
            // Parse and convert the input string to an integer.
            if (Int32.TryParse(txtBoxNumber.Text, out input))
            {
                // Add the parsed input and random number to list boxes, focus and clear the TextBox.
                lbYou.Items.Add(txtBoxNumber.Text);
                lbPC.Items.Add(randnum);
                txtBoxNumber.Focus();
                txtBoxNumber.Clear();

                // If input is equal to the generated number; increment the score count, throw a success message, generate a new random number, clear and focus on TextBox and reset the guess count.
                if (input == randnum)
                {
                    score += 10;
                    lblScore.Text = "Score: " + score;
                    guesses = 0;
                    lblGuessed.Text = "Guessed: " + guesses;
                    MessageBox.Show("Great, you guessed it right! Wanna try again?");
                    loadGenerator();
                    txtBoxNumber.Clear();
                    txtBoxNumber.Focus();
                }
                // If input is less than or greater than the generated number; generate a new random number, increment guess count and reset the score count.
                else if (input < randnum || input > randnum)
                {
                    loadGenerator();
                    guesses += 1;
                    lblGuessed.Text = "Guessed: " + guesses + " times";
                    score = 0;
                    lblScore.Text = "Score: " + score;
                }

                // When the input is greater than 10 or less than 1; Reset guess count, clear listbox items and throw an error.
                if (input > 10 || input < 1)
                {
                    guesses = 0;
                    lblGuessed.Text = "Guessed: " + guesses;
                    lbYou.Items.Clear();
                    lbPC.Items.Clear();
                    MessageBox.Show("That's an invalid number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Throw an error, focus on TextBox when there is no input from the user.
            else if (txtBoxNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a number between (1 - 10) to proceed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxNumber.Focus();
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Reset guess count, score count; Clear listbox items; Clear and focus on TextBox.
            guesses = 0;
            lblGuessed.Text = "Guessed: " + guesses;
            score = 0;
            lblScore.Text = "Score: " + score;
            lbYou.Items.Clear();
            lbPC.Items.Clear();
            txtBoxNumber.Clear();
            txtBoxNumber.Focus();
        }
        private void loadGenerator()
        {
            // Generate a random number between (1 - 10)
            randnum = randomNumber.Next(1, 10);
        }
    }
}
