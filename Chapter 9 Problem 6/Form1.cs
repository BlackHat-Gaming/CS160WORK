using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_9_Problem_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password2.Hide();
            Check.Hide();
            Reset.Hide();
        }

        private void Password1_TextChanged(object sender, EventArgs e)
        {
            password1.PasswordChar = '*';
            password1.CharacterCasing = CharacterCasing.Lower;
        }
        private void Password2_TextChanged(object sender, EventArgs e)
        {
            password2.PasswordChar = '*';
            password2.CharacterCasing = CharacterCasing.Lower;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string pswrd1 = password1.Text;
            password2.Show();
            Check.Show();           
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string pswrd1 = password1.Text;
            string pswrd2 = password2.Text;
            Reset.Show();
            if (pswrd2 == pswrd1)
            {
                label1.Left = 40;
                label1.Text = "Congratulations, your passwords match.";
            }
            else
            {
                label1.Left = 40;
                label1.Text = "Your passwords do not match";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            password1.Text = "";
            password2.Text = "";
            password2.Hide();
            Check.Hide();
            Reset.Hide();
        }
    }
}
