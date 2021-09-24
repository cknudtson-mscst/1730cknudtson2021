using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableCurrency
{
    public partial class varibleCurrency : Form
    {
        public varibleCurrency()
        {
            InitializeComponent();
        }

        private void calcuate(object sender, EventArgs e)
        {
            //Austrailia Varibles
            decimal austrailiaDollar = Convert.ToDecimal(txtAustrailianDollar.Text);
            decimal austrailiaRate = Convert.ToDecimal(txtAustrailianRate.Text);

            //Bhutan Varibles
            decimal bhutanCurrency = Convert.ToDecimal(txtBhutanCurrency.Text);
            decimal bhutanRate = Convert.ToDecimal(txtBhutanRate.Text);

            //Costa Rica Varibles
            decimal costaRicanColon = Convert.ToDecimal(txtCostaRicanColon.Text);
            decimal costaRicanRate = Convert.ToDecimal(txtCostanRicanRate.Text);

            //Euro Varibles
            decimal euro = Convert.ToDecimal(txtEuro.Text);
            decimal euroRate = Convert.ToDecimal(txtEuroRate.Text);

            //To USD
            txtAustrailianUSD.Text = (austrailiaDollar * austrailiaRate).ToString("0.00");
            txtBhutanUSD.Text = (bhutanCurrency * bhutanRate).ToString("0.00");
            txtCostaRicanUSD.Text = (costaRicanColon * costaRicanRate).ToString("0.00");
            txtEuroUSD.Text = (euro * euroRate).ToString("0.00");
        }

        private void totalUSD(object sender, EventArgs e)
        {
            //All converted to USD
            decimal austrailiaUSD = Convert.ToDecimal(txtAustrailianUSD.Text);
            decimal bhutanUSD = Convert.ToDecimal(txtBhutanUSD.Text);
            decimal costaRicanUSD = Convert.ToDecimal(txtCostaRicanUSD.Text);
            decimal euroUSD = Convert.ToDecimal(txtEuroUSD.Text);

            txtUSD.Text = (austrailiaUSD +
                           bhutanUSD +
                           costaRicanUSD +
                           euroUSD).ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAustrailianDollar.Text = "0.00";
            txtAustrailianRate.Text = "0.717976";
            txtBhutanCurrency.Text = "0.00";
            txtBhutanRate.Text = "0.0139831";
            txtCostaRicanColon.Text = "0.00";
            txtCostanRicanRate.Text = "0.00176122";
            txtEuro.Text = "0.00";
            txtEuroRate.Text = "1.15528";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
