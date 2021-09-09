using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((Convert.ToDecimal(txtTestOne.Text) +
                Convert.ToDecimal(txtTestTwo.Text) +
                Convert.ToDecimal(txtTestThree.Text)) / 3).ToString("0.000");

            btnReset.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAverage.Text = "";
            txtTestOne.Text = "";
            txtTestTwo.Text = "";
            txtTestThree.Text = "";

            txtTestOne.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
