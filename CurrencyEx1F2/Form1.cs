using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyEx1F2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            txtAmount.Text = "0.00";
            txtCountry.Text = btnAustrailia.Text + ": ";

        }

        private void btnAustrailia_Click(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            txtCountry.Text = btnAustrailia.Text + ": ";
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.0139831";
            txtCountry.Text = btnBhutan.Text + ": ";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.00176122";
            txtCountry.Text = btnCostaRica.Text + ": ";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustrailia.BackgroundImage = picAustrailiaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            txtRate.Text = "1.15528";
            txtCountry.Text = btnEuro.Text + ": ";
        }

        private void txtChange(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtAmount.Text) *
                Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void CurrencyEnter(object sender, EventArgs e)
        {
            txtAmount.SelectAll();
        }

        private void RateEnter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text + " + " + txtUSD.Text;
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(txtUSD.Text)).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAustrailia.BackgroundImage = picAustrailia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            txtAmount.Text = "0.00";
            txtCountry.Text = btnAustrailia.Text + ": ";
            txtCalc.Text = "0";
            txtTotal.Text = "0";
            txtAmount.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
