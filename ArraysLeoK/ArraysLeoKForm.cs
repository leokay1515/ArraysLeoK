using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysLeoK
{
    public partial class frmArraysLeoK : Form
    {
        //global variables
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArraysLeoK()
        {
            InitializeComponent();

            //disable the calculate button
            this.btnCalculate.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //local variables
            int randomNumbers;
            int counter;
            Random randomNumberGenerator = new Random();

            //clear the listbox
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //Generate a random number between 1 and the array size
                randomNumbers = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE);

                //assign randomNumber to the cell at the counter posistion in the array
                arrayOfNumbers[counter] = randomNumbers;

                //add the number to the listbox
                this.lstNumbers.Items.Add(randomNumbers);

                //refresh the form
                this.Refresh();
            }

            //enable the calculate button
            this.btnCalculate.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables
            double average = 0;
            double sum = 0;
            int counter;
            
            //calculate the sum of all the numbers in the array
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            //calculate the average
            average = sum / arrayOfNumbers.Length;

            //display the average
            MessageBox.Show("The average is " + average, "Average of Array");

            //disable the calculate button
            this.btnCalculate.Enabled = false;
        }
    }
}
