using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2D_If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            //All Pass
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "False";
            textBox5InputA.Text = "5";
            textBox5InputB.Text = "5";
            textBox6Input.Text = "James";
            textBox7Input.Text = "50";
            textBox8InputA.Text = "5";
            textBox8InputB.Text = "10";
            textBox9Input.Text = "575";
            textBox10InputA.Text = "3";
            textBox10InputB.Text = "4";
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            //All Fail
            textBox1Input.Text = "Fred";
            textBox2Input.Text = "Hello World";
            textBox3Input.Text = "1.7";
            textBox4Input.Text = "True";
            textBox5InputA.Text = "3";
            textBox5InputB.Text = "9";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "-10";
            textBox8InputA.Text = "15";
            textBox8InputB.Text = "7";
            textBox9Input.Text = "382";
            textBox10InputA.Text = "6";
            textBox10InputB.Text = "5";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Any Varibles Needed Here
            decimal input3 = Convert.ToDecimal(textBox3Input.Text);
            int input7 = Convert.ToInt32(textBox7Input.Text);
            int input8A = Convert.ToInt32(textBox8InputA.Text);
            int input8B = Convert.ToInt32(textBox8InputB.Text);
            int input9 = Convert.ToInt32(textBox9Input.Text);
            int input10A = Convert.ToInt32(textBox10InputA.Text);
            int input10B = Convert.ToInt32(textBox10InputB.Text);

            //Result A set to fail first
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            //Result A Tests ---- Tests for and gives success if met
            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";

            if (input3 == 2.3m)
                textBox3ResultA.Text = "Success";

            //Kept as string to avoid blow up
            if (textBox4Input.Text == "False")
                textBox4ResultA.Text = "Success";

            if (textBox5InputA.Text == textBox5InputB.Text)
                textBox5ResultA.Text = "Success";

            if (textBox6Input.Text != "Jones")
                textBox6ResultA.Text = "Success";

            if (input7 > 0)
                textBox7ResultA.Text = "Success";

            if (input8A < input8B)
                textBox8ResultA.Text = "Success";

            if (input9 >= 500)
                textBox9ResultA.Text = "Success";

            if (input10A <= input10B)
                textBox10ResultA.Text = "Success";

            //Result B set to success first
            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            //Result B Tests ---- Tests for and gives fail if met
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";

            if (input3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            //Kept as string to avoid blow up
            if (textBox4Input.Text != "False")
                textBox4ResultB.Text = "Fail";

            if (textBox5InputA.Text != textBox5InputB.Text)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text == "Jones")
                textBox6ResultB.Text = "Fail";

            if (input7 < 0)
                textBox7ResultB.Text = "Fail";

            if (input8A > input8B)
                textBox8ResultB.Text = "Fail";

            if (input9 <= 500)
                textBox9ResultB.Text = "Fail";

            if (input10A >= input10B)
                textBox10ResultB.Text = "Fail";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
