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
        double slicePrice;
        double sliceCount;
        double totalPrice;

        public Form1()
        {
            InitializeComponent();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            slicePrice = 3.25;
            sliceCount = inputBox.Text;
            totalPrice = sliceCount * slicePrice;
            outputLabel.Text = $"{totalPrice}";
            
        }
    }
}
