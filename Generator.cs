using System.Runtime.InteropServices;
using System;

namespace Password_Generator
{
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }
        //created method to be used to generate random password
        private void RandomGenerator(int length)
        {
            //Defining variables of different combinations of letters, numbers and symbols
            string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()_+-=[]{}|;:,./<>?\\'" + '"';

            //Creates an instance of the random class
            Random rand = new Random();

            //Combines all the different characters into a single string
            string combination = string.Concat(caps + lower + numbers + symbols);

            //Ensures that the password contains one randomly selected character from each character set
            string randomPass = string.Concat(caps[rand.Next(caps.Length)]);
            randomPass += string.Concat(lower[rand.Next(lower.Length)]);
            randomPass += string.Concat(numbers[rand.Next(numbers.Length)]);
            randomPass += string.Concat(symbols[rand.Next(symbols.Length)]);

            //Generates the rest of the remaining characters of the password
            randomPass += string.Concat(Enumerable.Repeat(combination, length - 4)
              .Select(s => s[rand.Next(s.Length)]).ToArray());

            //Shuffles the characters on the password
            randomPass = new string(randomPass.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());

            tbPassword.Text = randomPass;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Grabs the value of the NumericUpDown, converts it to int and passes it as arguments for RandomGenerator method
            RandomGenerator((int)numericLength.Value);
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if ((tbPassword.Text == "Copied") || (tbPassword.Text == ""))
            {
                tbPassword.Text = "";
                MessageBox.Show("¡Please generate a new password!");
            }
            else
            {
                Clipboard.SetText(tbPassword.Text);
                tbPassword.Text = "Copied!";
            }
        }
    }
}