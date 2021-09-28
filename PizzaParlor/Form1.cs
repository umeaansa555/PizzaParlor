using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlor
{
    public partial class Form1 : Form
    {

        double slicePrice = 3.25;
        double sliceCount;
        double totalPrice;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                sliceCount = Convert.ToInt32(inputBox.Text);
                totalPrice = sliceCount * slicePrice;

                outputLabel.Text = $"{totalPrice}";
                outputLabel.Text = $" The price of {sliceCount} slice(s) is {totalPrice.ToString("C")}.";
            }

            catch
            {
                outputLabel.Text = $"We can't serve {inputBox.Text} slices.";
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            //sliceCount = inputBox.Text;
        }
    }
}
