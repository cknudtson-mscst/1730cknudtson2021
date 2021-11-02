using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //01
            decimal subtotal = Convert.ToDecimal(txt01Input1.Text);
            //txt01Result.Text = (subtotal >= 250 && subtotal < 500).ToString();
            txt01Result.Text = (LogicalOperations.q01(subtotal)).ToString();

            //02
            int timeInService = Convert.ToInt32(txt02Input1.Text);
            //txt02Result.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            txt02Result.Text = (LogicalOperations.q02(timeInService)).ToString();

            //03 - 06 Variables
            bool isValid = Convert.ToBoolean(txt03Input1.Text);
            int years = Convert.ToInt32(txt03Input2.Text);
            int counter = Convert.ToInt32(txt03Input3.Text);

            //03
            //txt03Result.Text = (isValid == true && counter++ < years).ToString();
            txt03Result.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            txt03Effect.Text = counter.ToString();

            //04
            counter = Convert.ToInt32(txt03Input3.Text);
            //txt04Result.Text = (isValid == true & counter++ < years).ToString();
            txt04Result.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            txt04Effect.Text = counter.ToString();

            //05
            counter = Convert.ToInt32(txt03Input3.Text);
            //txt05Result.Text = (isValid == true || counter++ < years).ToString();
            txt05Result.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            txt05Effect.Text = counter.ToString();

            //06
            counter = Convert.ToInt32(txt03Input3.Text);
            //txt06Result.Text = (isValid == true | counter++ < years).ToString();
            txt06Result.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            txt06Effect.Text = counter.ToString();

            //07 - Variables
            DateTime startDate = Convert.ToDateTime(txt07Input1.Text);
            DateTime expirationDate = Convert.ToDateTime(txt07Input2.Text);
            DateTime currentDate = Convert.ToDateTime(txt07Input3.Text);
            isValid = Convert.ToBoolean(txt07Input4.Text);

            //07
            //txt07Result.Text = (currentDate > startDate && currentDate < expirationDate || isValid == true).ToString();
            txt07Result.Text = (LogicalOperations.q07(startDate, expirationDate, currentDate, isValid)).ToString();

            //08 - Variables
            decimal thisYTD = Convert.ToDecimal(txt08Input1.Text);
            decimal lastYTD = Convert.ToDecimal(txt08Input2.Text);
            string emptype = txt08Input3.Text;
            int startYear = Convert.ToInt32(txt08Input4.Text);
            int currentYear = Convert.ToInt32(txt08Input5.Text);

            //08
            //txt08Result.Text = (((thisYTD > lastYTD) || emptype == "Part Time") && startYear < currentYear).ToString();
            txt08Result.Text = (LogicalOperations.q08(thisYTD, lastYTD, emptype, startYear, currentYear)).ToString();

            //09
            counter = Convert.ToInt32(txt09Input1.Text);
            years = Convert.ToInt32(txt09Input2.Text);
            //txt09Result.Text = (!(counter++ >= years)).ToString();
            txt09Result.Text = (LogicalOperations.q09(counter, years)).ToString();
            txt09Effect.Text = counter.ToString();

            //10 Variables
            int a = Convert.ToInt32(txt10Input1.Text);
            int b = Convert.ToInt32(txt10Input2.Text);
            int c = Convert.ToInt32(txt10Input3.Text);
            int d = Convert.ToInt32(txt10Input4.Text);

            //10
            txt10Result.Text = (a + b * c - d).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
