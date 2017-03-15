using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_Problem_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double distance = 0;
            double time = 0;
            double milesPerHour = 0;
            bool valid1 = double.TryParse(textBox1.Text, out distance);
            bool valid2 = double.TryParse(textBox2.Text, out time);
            if (valid1 && valid2)
            {
                milesPerHour = distance / time;
                result.Left = 75;
                result.Text = Convert.ToString(milesPerHour) + " Miles per hour";
            }
            else
                result.Text = "Please enter valid values.";
        }
    }
}
