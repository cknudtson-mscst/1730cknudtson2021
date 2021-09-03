
namespace FoodTruck
{
    partial class FoodTruck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCottonCandy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCottonCandySubtotal = new System.Windows.Forms.TextBox();
            this.txtCheeseCurdSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheeseCurd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHotDogSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHotDog = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHamburgerSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHamburger = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPretax = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotton Candy";
            // 
            // txtCottonCandy
            // 
            this.txtCottonCandy.Location = new System.Drawing.Point(136, 39);
            this.txtCottonCandy.Name = "txtCottonCandy";
            this.txtCottonCandy.Size = new System.Drawing.Size(100, 26);
            this.txtCottonCandy.TabIndex = 1;
            this.txtCottonCandy.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "x $3.00 =";
            // 
            // txtCottonCandySubtotal
            // 
            this.txtCottonCandySubtotal.Location = new System.Drawing.Point(321, 39);
            this.txtCottonCandySubtotal.Name = "txtCottonCandySubtotal";
            this.txtCottonCandySubtotal.ReadOnly = true;
            this.txtCottonCandySubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtCottonCandySubtotal.TabIndex = 4;
            this.txtCottonCandySubtotal.TabStop = false;
            // 
            // txtCheeseCurdSubtotal
            // 
            this.txtCheeseCurdSubtotal.Location = new System.Drawing.Point(321, 81);
            this.txtCheeseCurdSubtotal.Name = "txtCheeseCurdSubtotal";
            this.txtCheeseCurdSubtotal.ReadOnly = true;
            this.txtCheeseCurdSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtCheeseCurdSubtotal.TabIndex = 9;
            this.txtCheeseCurdSubtotal.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "x $4.00 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // txtCheeseCurd
            // 
            this.txtCheeseCurd.Location = new System.Drawing.Point(136, 81);
            this.txtCheeseCurd.Name = "txtCheeseCurd";
            this.txtCheeseCurd.Size = new System.Drawing.Size(100, 26);
            this.txtCheeseCurd.TabIndex = 2;
            this.txtCheeseCurd.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cheese Curds";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 31);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(321, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHotDogSubtotal
            // 
            this.txtHotDogSubtotal.Location = new System.Drawing.Point(321, 124);
            this.txtHotDogSubtotal.Name = "txtHotDogSubtotal";
            this.txtHotDogSubtotal.ReadOnly = true;
            this.txtHotDogSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtHotDogSubtotal.TabIndex = 15;
            this.txtHotDogSubtotal.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "x $4.75 =";
            // 
            // txtHotDog
            // 
            this.txtHotDog.Location = new System.Drawing.Point(136, 124);
            this.txtHotDog.Name = "txtHotDog";
            this.txtHotDog.Size = new System.Drawing.Size(100, 26);
            this.txtHotDog.TabIndex = 3;
            this.txtHotDog.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hot Dogs";
            // 
            // txtHamburgerSubtotal
            // 
            this.txtHamburgerSubtotal.Location = new System.Drawing.Point(321, 163);
            this.txtHamburgerSubtotal.Name = "txtHamburgerSubtotal";
            this.txtHamburgerSubtotal.ReadOnly = true;
            this.txtHamburgerSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtHamburgerSubtotal.TabIndex = 19;
            this.txtHamburgerSubtotal.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "x $5.50 =";
            // 
            // txtHamburger
            // 
            this.txtHamburger.Location = new System.Drawing.Point(136, 163);
            this.txtHamburger.Name = "txtHamburger";
            this.txtHamburger.Size = new System.Drawing.Size(100, 26);
            this.txtHamburger.TabIndex = 4;
            this.txtHamburger.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Hamburgers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Pretax";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 31);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total";
            // 
            // txtPretax
            // 
            this.txtPretax.Location = new System.Drawing.Point(321, 202);
            this.txtPretax.Name = "txtPretax";
            this.txtPretax.ReadOnly = true;
            this.txtPretax.Size = new System.Drawing.Size(100, 26);
            this.txtPretax.TabIndex = 24;
            this.txtPretax.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(321, 238);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 25;
            this.txtTax.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(321, 274);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHamburgerSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHamburger);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHotDogSubtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHotDog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCheeseCurdSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCheeseCurd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCottonCandySubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCottonCandy);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCottonCandy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCottonCandySubtotal;
        private System.Windows.Forms.TextBox txtCheeseCurdSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheeseCurd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHotDogSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHotDog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHamburgerSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHamburger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPretax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

