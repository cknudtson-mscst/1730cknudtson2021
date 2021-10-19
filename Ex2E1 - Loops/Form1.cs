using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2E1___Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //01
            decimal subtotal = Convert.ToDecimal(txt01Input.Text);
            txt01Result.Text = (subtotal >= 250 && subtotal < 500).ToString();

            //02
            int timeInService = Convert.ToInt32(txt02Input.Text);
            txt02Result.Text = (timeInService <= 4 || timeInService >= 12).ToString();

            //03 and beyond variables
            //03 - 06 uses these exact variables
            bool isValid = Convert.ToBoolean(txt03Input1.Text);
            int counter = Convert.ToInt32(txt03Input2.Text);
            int years = Convert.ToInt32(txt03Input3.Text);

            //03
            txt03Result.Text = (isValid == true && counter++ < years).ToString();
            txt03Effect.Text = counter.ToString();

            //04
            txt04Result.Text = (isValid == true & counter++ < years).ToString();
            txt04Effect.Text = counter.ToString();

            //05
            txt05Result.Text = (isValid == true || counter++ < years).ToString();
            txt05Effect.Text = counter.ToString();

            //06
            txt06Result.Text = (isValid == true | counter++ < years).ToString();
            txt06Effect.Text = counter.ToString();

            //07
            //07 uses isValid from 03
            DateTime startDate = Convert.ToDateTime(txt07Input1.Text);
            DateTime expirationtDate = Convert.ToDateTime(txt07Input2.Text);
            DateTime date = Convert.ToDateTime(txt07Input3.Text);
            txt07Result.Text = (date > startDate && date < expirationtDate || isValid == true).ToString();

            //08
            decimal thisYTD = Convert.ToDecimal(txt08Input1.Text);
            decimal lastYTD = Convert.ToDecimal(txt08Input2.Text);
            string empType = txt08Input3.Text;
            int startYear = Convert.ToInt32(txt08Input4.Text);
            int currentYear = Convert.ToInt32(txt08Input5.Text);
            txt08Result.Text = ((thisYTD > lastYTD || empType == "Part Time") && startYear < currentYear).ToString();

            //09
            int Counter = Convert.ToInt32(txt09Input1.Text);
            int Years = Convert.ToInt32(txt09Input2.Text);
            txt09Result.Text = (!(Counter++ >= Years)).ToString();
            txt09Effect.Text = Counter.ToString();

            //10
            int a = Convert.ToInt32(txt10Input1.Text);
            int b = Convert.ToInt32(txt10Input2.Text);
            int c = Convert.ToInt32(txt10Input3.Text);
            int d = Convert.ToInt32(txt10Input4.Text);
            txt10Result.Text = (a + b * c - d).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
