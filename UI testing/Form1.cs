using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_testing
{
    public partial class Form1 : Form
    {
        GuessLogic guess = new GuessLogic();
        private int computer_guess;
        private int lower_bound = 0;
        private int upper_bound = 100;

        private void updateGuess(int guess)
        {
            resultLabel.Text = guess.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            computer_guess = guess.get_new_guess(lower_bound, upper_bound);
            updateGuess(computer_guess);
        }

        private void tooLowButton_Click(object sender, EventArgs e)
        {             
            lower_bound = computer_guess;
            computer_guess = guess.get_new_guess(lower_bound + 1, upper_bound);
            updateGuess(computer_guess);
        }

        private void tooHighButton_Click(object sender, EventArgs e)
        {
            upper_bound = computer_guess;
            computer_guess = guess.get_new_guess(lower_bound, upper_bound);
            updateGuess(computer_guess);
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            string correct_guess_message = "Your number was " + computer_guess.ToString() + "!";
            correctGuessLabel.Text = correct_guess_message;
        }
    }
}
