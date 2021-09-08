using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCurrencyConverter
{
    public partial class CurrencyConvertEx1D : Form
    {
        public CurrencyConvertEx1D()
        {
            InitializeComponent();
        }
        private void austrailiaTextChanged(object sender, EventArgs e)
        {
            txtAustrailianUSD.Text = (Convert.ToDecimal(txtAustrailianDollar.Text) *
                Convert.ToDecimal(txtAustrailianRate.Text)).ToString("0.00");
        }

        private void bhutanTextChange(object sender, EventArgs e)
        {
            txtBhutanUSD.Text = (Convert.ToDecimal(txtBhutanCurrency.Text) *
                Convert.ToDecimal(txtBhutanRate.Text)).ToString("0.00");
        }

        private void colonTextChange(object sender, EventArgs e)
        {
            txtCostaRicanUSD.Text = (Convert.ToDecimal(txtCostaRicanColon.Text) *
                Convert.ToDecimal(txtCostanRicanRate.Text)).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtEuroUSD.Text = (Convert.ToDecimal(txtEuro.Text) *
                Convert.ToDecimal(txtEuroRate.Text)).ToString("0.00");
        }

        private void usdTotal(object sender, EventArgs e)
        {
                txtUSD.Text = (Convert.ToDecimal(txtAustrailianUSD.Text) +
                Convert.ToDecimal(txtBhutanUSD.Text) +
                Convert.ToDecimal(txtCostaRicanUSD.Text) +
                Convert.ToDecimal(txtEuroUSD.Text)).ToString("0.00");
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
