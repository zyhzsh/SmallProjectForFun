using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGameBinarySearch
{
    public partial class Form1 : Form
    {
        uint minNumber;
        uint maxNumber;
        uint guessnumber;
        public Form1()
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Big";
            MessageBoxManager.No = "Small";
            MessageBoxManager.Register();
        }

        private void btnStartGuess_Click(object sender, EventArgs e)
        {
            int counter = 0;
            minNumber = 0;
            maxNumber = 4000000000;
            guessnumber = (maxNumber + minNumber) / 2;
            while (AskUserGuessResult()) {
                counter++;
                if (counter == 31) { break; }
            }
            MessageBox.Show("The number on you paper is: "+ guessnumber);
        }

        private bool AskUserGuessResult() {

            DialogResult dr = MessageBox.Show("Is Your Result: " + guessnumber + "? Or it's too",
          "Guessing...", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    maxNumber = guessnumber;
                    guessnumber = (minNumber + guessnumber) / 2;                
                    break;
                case DialogResult.No:
                    minNumber = guessnumber;
                    guessnumber = (maxNumber + maxNumber) / 2;
                    break;
            }
            return true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
