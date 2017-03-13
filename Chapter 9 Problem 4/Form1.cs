using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_Problem_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xCoord = 0;
            int yCoord = 0;
            string inraw1 = textBox1.Text;
            string inraw2 = textBox2.Text;
            bool valid = int.TryParse(inraw1, out xCoord);
            bool check = int.TryParse(inraw2, out yCoord);

            if (valid && check && (xCoord > 0) && (yCoord > 0))
            {
                Location = new Point(xCoord, yCoord); 
            }
            else
            {
                label3.Text = "Please enter a valid value";
            }
        }
    }
}
