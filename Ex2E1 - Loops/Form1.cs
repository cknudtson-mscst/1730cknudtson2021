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
    public partial class LogicalOperations : Form
    {
        public LogicalOperations()
        {
            InitializeComponent();
        }

        public static bool q01(int v)
        {
            throw new NotImplementedException();
        }

        public void btnCalculate_Click(object sender, EventArgs e)
        {
            //01
            int subtotal = Convert.ToInt32(txt01Input.Text);
            txt01Result.Text = (LogicalOperations.q01(subtotal)).ToString();

            //02
            int timeInService = Convert.ToInt32(txt02Input.Text);
            txt02Result.Text = (LogicalOperations.q02(timeInService)).ToString();

            //03 and beyond variables
            //03 - 06 uses these exact variables
            bool isValid = Convert.ToBoolean(txt03Input1.Text);
            int counter = Convert.ToInt32(txt03Input2.Text);
            int years = Convert.ToInt32(txt03Input3.Text);

            //03
            txt03Result.Text = (LogicalOperations.q03(isValid, counter, years)).ToString();
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
            txt07Result.Text = (LogicalOperations.q07(startDate, expirationtDate, date, isValid)).ToString();

            //08
            int thisYTD = Convert.ToInt32(txt08Input1.Text);
            int lastYTD = Convert.ToInt32(txt08Input2.Text);
            string empType = txt08Input3.Text;
            int startYear = Convert.ToInt32(txt08Input4.Text);
            int currentYear = Convert.ToInt32(txt08Input5.Text);
            txt08Result.Text = (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)).ToString();

            //09
            int Counter = Convert.ToInt32(txt09Input1.Text);
            int Years = Convert.ToInt32(txt09Input2.Text);
            txt09Result.Text = (LogicalOperations.q09(Counter, Years)).ToString();
            txt09Effect.Text = Counter.ToString();

            //10
            int a = Convert.ToInt32(txt10Input1.Text);
            int b = Convert.ToInt32(txt10Input2.Text);
            int c = Convert.ToInt32(txt10Input3.Text);
            int d = Convert.ToInt32(txt10Input4.Text);
            txt10Result.Text = (a + b * c - d).ToString();
        }

        private static object q07(DateTime startDate, DateTime expirationtDate, DateTime date, bool isValid)
        {
            throw new NotImplementedException();
        }

        private static object q09(int counter, int years)
        {
            throw new NotImplementedException();
        }

        private static object q08(int thisYTD, int lastYTD, string empType, int startYear, int currentYear)
        {
            throw new NotImplementedException();
        }

        private static object Q07(DateTime startDate, DateTime expirationtDate, DateTime date, bool isValid)
        {
            throw new NotImplementedException();
        }

        private static object q03(bool isValid, int counter, int years)
        {
            throw new NotImplementedException();
        }

        private static object q02(int timeInService)
        {
            throw new NotImplementedException();
        }

        public static bool q06(bool v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static bool Q07(DateTime startDate,
        DateTime expirationDate, DateTime date, bool isValid);
        }

        public static bool Q05(bool v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static bool q04(bool v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static bool q03(bool v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static bool q02(int v)
        {
            throw new NotImplementedException();
        }

        //private void btnExit_Click(object sender, EventArgs e)
       // {
           //this.Close();
       // }

        public static bool q08(int v1, int v2, string v3, int v4, int v5)
        {
            throw new NotImplementedException();
        }

        public static bool q09(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
