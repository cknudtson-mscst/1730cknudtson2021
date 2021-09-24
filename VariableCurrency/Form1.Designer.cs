
namespace VariableCurrency
{
    partial class varibleCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(varibleCurrency));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtEuroUSD = new System.Windows.Forms.TextBox();
            this.txtCostaRicanUSD = new System.Windows.Forms.TextBox();
            this.txtBhutanUSD = new System.Windows.Forms.TextBox();
            this.txtAustrailianUSD = new System.Windows.Forms.TextBox();
            this.txtEuroRate = new System.Windows.Forms.TextBox();
            this.txtCostanRicanRate = new System.Windows.Forms.TextBox();
            this.txtAustrailianRate = new System.Windows.Forms.TextBox();
            this.txtBhutanRate = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtCostaRicanColon = new System.Windows.Forms.TextBox();
            this.txtBhutanCurrency = new System.Windows.Forms.TextBox();
            this.txtAustrailianDollar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 29);
            this.label9.TabIndex = 51;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Amount:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(406, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 32);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(246, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 32);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(809, 236);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.ReadOnly = true;
            this.txtUSD.Size = new System.Drawing.Size(152, 26);
            this.txtUSD.TabIndex = 52;
            this.txtUSD.TabStop = false;
            this.txtUSD.Text = "0.00";
            this.txtUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSD.TextChanged += new System.EventHandler(this.totalUSD);
            // 
            // txtEuroUSD
            // 
            this.txtEuroUSD.Location = new System.Drawing.Point(564, 236);
            this.txtEuroUSD.Name = "txtEuroUSD";
            this.txtEuroUSD.ReadOnly = true;
            this.txtEuroUSD.Size = new System.Drawing.Size(152, 26);
            this.txtEuroUSD.TabIndex = 50;
            this.txtEuroUSD.TabStop = false;
            this.txtEuroUSD.Text = "0.00";
            this.txtEuroUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuroUSD.TextChanged += new System.EventHandler(this.totalUSD);
            // 
            // txtCostaRicanUSD
            // 
            this.txtCostaRicanUSD.Location = new System.Drawing.Point(406, 236);
            this.txtCostaRicanUSD.Name = "txtCostaRicanUSD";
            this.txtCostaRicanUSD.ReadOnly = true;
            this.txtCostaRicanUSD.Size = new System.Drawing.Size(152, 26);
            this.txtCostaRicanUSD.TabIndex = 49;
            this.txtCostaRicanUSD.TabStop = false;
            this.txtCostaRicanUSD.Text = "0.00";
            this.txtCostaRicanUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostaRicanUSD.TextChanged += new System.EventHandler(this.totalUSD);
            // 
            // txtBhutanUSD
            // 
            this.txtBhutanUSD.Location = new System.Drawing.Point(246, 236);
            this.txtBhutanUSD.Name = "txtBhutanUSD";
            this.txtBhutanUSD.ReadOnly = true;
            this.txtBhutanUSD.Size = new System.Drawing.Size(152, 26);
            this.txtBhutanUSD.TabIndex = 48;
            this.txtBhutanUSD.TabStop = false;
            this.txtBhutanUSD.Text = "0.00";
            this.txtBhutanUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutanUSD.TextChanged += new System.EventHandler(this.totalUSD);
            // 
            // txtAustrailianUSD
            // 
            this.txtAustrailianUSD.Location = new System.Drawing.Point(88, 236);
            this.txtAustrailianUSD.Name = "txtAustrailianUSD";
            this.txtAustrailianUSD.ReadOnly = true;
            this.txtAustrailianUSD.Size = new System.Drawing.Size(152, 26);
            this.txtAustrailianUSD.TabIndex = 47;
            this.txtAustrailianUSD.TabStop = false;
            this.txtAustrailianUSD.Text = "0.00";
            this.txtAustrailianUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustrailianUSD.TextChanged += new System.EventHandler(this.totalUSD);
            // 
            // txtEuroRate
            // 
            this.txtEuroRate.Location = new System.Drawing.Point(564, 204);
            this.txtEuroRate.Name = "txtEuroRate";
            this.txtEuroRate.Size = new System.Drawing.Size(152, 26);
            this.txtEuroRate.TabIndex = 38;
            this.txtEuroRate.Text = "1.15528";
            this.txtEuroRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuroRate.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtCostanRicanRate
            // 
            this.txtCostanRicanRate.Location = new System.Drawing.Point(406, 204);
            this.txtCostanRicanRate.Name = "txtCostanRicanRate";
            this.txtCostanRicanRate.Size = new System.Drawing.Size(152, 26);
            this.txtCostanRicanRate.TabIndex = 36;
            this.txtCostanRicanRate.Text = "0.00176122";
            this.txtCostanRicanRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostanRicanRate.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtAustrailianRate
            // 
            this.txtAustrailianRate.Location = new System.Drawing.Point(88, 204);
            this.txtAustrailianRate.Name = "txtAustrailianRate";
            this.txtAustrailianRate.Size = new System.Drawing.Size(152, 26);
            this.txtAustrailianRate.TabIndex = 34;
            this.txtAustrailianRate.Text = "0.717976";
            this.txtAustrailianRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustrailianRate.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtBhutanRate
            // 
            this.txtBhutanRate.Location = new System.Drawing.Point(246, 204);
            this.txtBhutanRate.Name = "txtBhutanRate";
            this.txtBhutanRate.Size = new System.Drawing.Size(152, 26);
            this.txtBhutanRate.TabIndex = 35;
            this.txtBhutanRate.Text = "0.0139831";
            this.txtBhutanRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutanRate.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(564, 172);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(152, 26);
            this.txtEuro.TabIndex = 29;
            this.txtEuro.Text = "0.00";
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEuro.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtCostaRicanColon
            // 
            this.txtCostaRicanColon.Location = new System.Drawing.Point(406, 172);
            this.txtCostaRicanColon.Name = "txtCostaRicanColon";
            this.txtCostaRicanColon.Size = new System.Drawing.Size(152, 26);
            this.txtCostaRicanColon.TabIndex = 28;
            this.txtCostaRicanColon.Text = "0.00";
            this.txtCostaRicanColon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostaRicanColon.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtBhutanCurrency
            // 
            this.txtBhutanCurrency.Location = new System.Drawing.Point(246, 172);
            this.txtBhutanCurrency.Name = "txtBhutanCurrency";
            this.txtBhutanCurrency.Size = new System.Drawing.Size(152, 26);
            this.txtBhutanCurrency.TabIndex = 26;
            this.txtBhutanCurrency.Text = "0.00";
            this.txtBhutanCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBhutanCurrency.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // txtAustrailianDollar
            // 
            this.txtAustrailianDollar.Location = new System.Drawing.Point(88, 172);
            this.txtAustrailianDollar.Name = "txtAustrailianDollar";
            this.txtAustrailianDollar.Size = new System.Drawing.Size(152, 26);
            this.txtAustrailianDollar.TabIndex = 25;
            this.txtAustrailianDollar.Text = "0.00";
            this.txtAustrailianDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAustrailianDollar.TextChanged += new System.EventHandler(this.calcuate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "US Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(809, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(152, 128);
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Euro";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(564, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 128);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Costa Rican Colon";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(406, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 128);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Bhutanese Ngultrum";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(246, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 128);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Austrailian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(88, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 128);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // varibleCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 344);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtEuroUSD);
            this.Controls.Add(this.txtCostaRicanUSD);
            this.Controls.Add(this.txtBhutanUSD);
            this.Controls.Add(this.txtAustrailianUSD);
            this.Controls.Add(this.txtEuroRate);
            this.Controls.Add(this.txtCostanRicanRate);
            this.Controls.Add(this.txtAustrailianRate);
            this.Controls.Add(this.txtBhutanRate);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtCostaRicanColon);
            this.Controls.Add(this.txtBhutanCurrency);
            this.Controls.Add(this.txtAustrailianDollar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "varibleCurrency";
            this.Text = "Currency with Varibles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtEuroUSD;
        private System.Windows.Forms.TextBox txtCostaRicanUSD;
        private System.Windows.Forms.TextBox txtBhutanUSD;
        private System.Windows.Forms.TextBox txtAustrailianUSD;
        private System.Windows.Forms.TextBox txtEuroRate;
        private System.Windows.Forms.TextBox txtCostanRicanRate;
        private System.Windows.Forms.TextBox txtAustrailianRate;
        private System.Windows.Forms.TextBox txtBhutanRate;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtCostaRicanColon;
        private System.Windows.Forms.TextBox txtBhutanCurrency;
        private System.Windows.Forms.TextBox txtAustrailianDollar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

