using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_Problem_5
{
    public partial class TripCalculator : Form
    {
        public TripCalculator()
        {
            InitializeComponent();
        }
        private void Accept_Click(object sender, EventArgs e)
        {
            string city;
            double miles = 0;
            double gallons = 0;
            city = Destination.Text;
            string enteredMiles = Miles.Text;
            string enteredGallons = Gallons.Text;
            //Parsing
            bool valid = double.TryParse(enteredMiles, out miles);
            bool check = double.TryParse(enteredGallons, out gallons);
            //check
            if(valid && check && miles >= 0 && gallons >= 0)
            {
                Result.Left = 25;
                Result.Text = city + " gave you an average miles/gallon of " + 
                    Convert.ToString(miles / gallons);
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Destination.Text = "";
            Miles.Text = "";
            Gallons.Text = "";
            Result.Text = "";
        }
    }
}
