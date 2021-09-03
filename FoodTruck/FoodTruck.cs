using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTruck
{
    public partial class FoodTruck : Form
    {
        public FoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)

        //Calculations for subtotals

        {
            txtCheeseCurdSubtotal.Text = (Convert.ToDecimal(txtCheeseCurd.Text) * 4.0m).ToString("0.00");
            txtCottonCandySubtotal.Text = (Convert.ToDecimal(txtCottonCandy.Text) * 3.0m).ToString("0.00");
            txtHamburgerSubtotal.Text = (Convert.ToDecimal(txtHamburger.Text) * 5.5m).ToString("0.00");
            txtHotDogSubtotal.Text = (Convert.ToDecimal(txtHotDog.Text) * 4.75m).ToString("0.00");

            //Pretax

            txtPretax.Text = (Convert.ToDecimal(txtHotDogSubtotal.Text) +
                Convert.ToDecimal(txtHamburgerSubtotal.Text) +
                Convert.ToDecimal(txtCottonCandySubtotal.Text) +
                Convert.ToDecimal(txtCheeseCurdSubtotal.Text)).ToString("0.00");

            //MN State Tax, which is 6.875% last I checked

            txtTax.Text = (Convert.ToDecimal(txtPretax.Text) * 0.06875m).ToString("0.00");

            //Total

            txtTotal.Text = (Convert.ToDecimal(txtPretax.Text) + Convert.ToDecimal(txtTax.Text)).ToString("0.00");

            //Clear Button Focus

            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)

            //Closes Windows Form

        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)

            //Clears to either 0 or (Blank),then focus on CottonCandy txt
        {
            txtCheeseCurd.Text = "0";
            txtCottonCandy.Text = "0";
            txtHamburger.Text = "0";
            txtHotDog.Text = "0";
            txtCottonCandySubtotal.Text = "";
            txtCheeseCurdSubtotal.Text = "";
            txtHamburgerSubtotal.Text = "";
            txtHotDogSubtotal.Text = "";
            txtPretax.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            //Focus on CottonCandy

            txtCottonCandy.Focus();
        }
    }
}
