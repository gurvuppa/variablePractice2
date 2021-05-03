/*
 * Gurvir Uppal
 * Variable Practice
 * May 3, 2021
 * Mr. T 
 * ISC3U
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablePractice2
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }

        private void buttonHockey_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";

            int playerNumber = 99;

            outputLabel.Text = $"{playerName} number is {playerNumber}";
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * pi;

            outputLabel.Text = $"The area of a circle with a radius of {radius}cm  is {area}^2";
        }

        private void buttonCarpet_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2";

            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per sqaure metre is ${totalCost}";
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            double shirtPrice = 12.49;
            double bill = 20;
            double tax = 0.13;
            double taxAmount = shirtPrice * tax;
            double total = shirtPrice + taxAmount;
            double change = bill - total;

            outputLabel.Text = "Bill of Sale";

            outputLabel.Text += $"\n\nShirt:         {shirtPrice}";

            outputLabel.Text += $"\n\nTax:           {taxAmount.ToString("#.##")}";
            outputLabel.Text += $"\nTotal:           {total.ToString("#.##")}";

            outputLabel.Text += $"\n\nTendered:      {bill}";
            outputLabel.Text += $"\nChange:          {change.ToString("#.##")}";
            outputLabel.Text += $"\nChange:          {change.ToString("#.##")}";
        }
    }
}
