using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_problem_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter;
        private int target;
        private void startBtn_Click(object sender, EventArgs e)
        {
            target = RandomInitializer();
            startBtn.Hide();
            resetBtn.Show();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            startBtn.Show();
            resetBtn.Hide();
            counter = 0;
            Cnt.Text = "Number of Guesses: " + counter;
            this.BackColor = System.Drawing.Color.SteelBlue;
        }
        private void guessBtn_Click(object sender, EventArgs e)
        {
            int guess;
            bool valid = int.TryParse(textBox1.Text, out guess);
            if (guess > target)
                this.BackColor = System.Drawing.Color.Green;
            else
                this.BackColor = System.Drawing.Color.Red;
            GuessCheck(guess, target);
            counter++;
            this.Cnt.TextAlign = ContentAlignment.BottomCenter;
            Cnt.Text = "Number of Guesses: " + counter;

        }
        //Sets random number
        private int RandomInitializer()
        {
            Random randomGenerator = new Random();
            int target = randomGenerator.Next(1, 101);
            return target;
        }
        //checks the users guess
        private void GuessCheck(int guess, int target)
        {
            if (guess == target)
            {
                result.Text = "Congratulations, you've guessed the number.";
                this.BackColor = System.Drawing.Color.Gold;
            }
            else
                result.Text = "Try Again";
        }

    }
}
