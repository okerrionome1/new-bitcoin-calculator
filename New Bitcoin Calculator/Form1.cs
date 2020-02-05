using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Bitcoin_Calculator
{
    public partial class btcCalculator : Form
    {
        public btcCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal bitcoinValue = decimal.Parse(txtCurrent.Text);
            decimal predictedValue = decimal.Parse(txtPredicted.Text);
            decimal investedValue = decimal.Parse(txtInvested.Text);

            decimal usd2btc = investedValue / bitcoinValue;
            decimal profit = (usd2btc * predictedValue) - investedValue;

            label4.Text = $"Profit made is: {profit:C}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = " ";
            txtPredicted.Text = " ";
            txtInvested.Text = " ";
            label4.Text = " ";
        }
    }
}
