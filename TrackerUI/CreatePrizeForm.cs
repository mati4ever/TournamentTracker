﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel( 
                    placeNameValueTextBox.Text,
                    placeNumberValueTextBox.Text,
                    prizeAmountValueTextBox.Text,
                    prizePercentageValueTextBox.Text);

               
                    GlobalConfig.Connection.CreatePrize(model);



                placeNumberValueTextBox.Text = "";
                placeNameValueTextBox.Text = "";
                prizeAmountValueTextBox.Text = "0";
                prizePercentageValueTextBox.Text = "0";


            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");

            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 0)
            {
                output = false;
            }

            if (placeNameValueTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValueTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
             
            return output;
        }
    }
}
