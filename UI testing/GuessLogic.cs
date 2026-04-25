using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UI_testing
{
    public class GuessLogic
    {
        Random rand = new Random();
        public int get_new_guess(int lower_bound, int upper_bound)
        {
            int computer_guess = rand.Next(lower_bound, upper_bound);
            return computer_guess;
        }
    }
}
