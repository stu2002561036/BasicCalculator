
namespace BasicCalculator
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bmc = new System.Windows.Forms.Button();
            this.bmr = new System.Windows.Forms.Button();
            this.bmplus = new System.Windows.Forms.Button();
            this.bmmin = new System.Windows.Forms.Button();
            this.bce = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bsqrt = new System.Windows.Forms.Button();
            this.bback = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.bpercent = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.brecip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(254, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bmc
            // 
            this.bmc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bmc.Location = new System.Drawing.Point(14, 105);
            this.bmc.Name = "bmc";
            this.bmc.Size = new System.Drawing.Size(57, 35);
            this.bmc.TabIndex = 1;
            this.bmc.Text = "MC";
            this.bmc.UseVisualStyleBackColor = false;
            this.bmc.Click += new System.EventHandler(this.bmc_Click);
            // 
            // bmr
            // 
            this.bmr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bmr.Location = new System.Drawing.Point(77, 105);
            this.bmr.Name = "bmr";
            this.bmr.Size = new System.Drawing.Size(57, 35);
            this.bmr.TabIndex = 2;
            this.bmr.Text = "MR";
            this.bmr.UseVisualStyleBackColor = false;
            this.bmr.Click += new System.EventHandler(this.bmr_Click);
            // 
            // bmplus
            // 
            this.bmplus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bmplus.Location = new System.Drawing.Point(140, 105);
            this.bmplus.Name = "bmplus";
            this.bmplus.Size = new System.Drawing.Size(57, 35);
            this.bmplus.TabIndex = 3;
            this.bmplus.Text = "M+";
            this.bmplus.UseVisualStyleBackColor = false;
            this.bmplus.Click += new System.EventHandler(this.bmplus_Click);
            // 
            // bmmin
            // 
            this.bmmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bmmin.Location = new System.Drawing.Point(203, 105);
            this.bmmin.Name = "bmmin";
            this.bmmin.Size = new System.Drawing.Size(63, 35);
            this.bmmin.TabIndex = 4;
            this.bmmin.Text = "M-";
            this.bmmin.UseVisualStyleBackColor = false;
            this.bmmin.Click += new System.EventHandler(this.bmmin_Click);
            // 
            // bce
            // 
            this.bce.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bce.Location = new System.Drawing.Point(116, 147);
            this.bce.Name = "bce";
            this.bce.Size = new System.Drawing.Size(46, 35);
            this.bce.TabIndex = 7;
            this.bce.Text = "CE";
            this.bce.UseVisualStyleBackColor = false;
            this.bce.Click += new System.EventHandler(this.bce_Click);
            // 
            // bc
            // 
            this.bc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bc.Location = new System.Drawing.Point(168, 147);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(46, 35);
            this.bc.TabIndex = 8;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = false;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bsqrt
            // 
            this.bsqrt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bsqrt.Location = new System.Drawing.Point(220, 147);
            this.bsqrt.Name = "bsqrt";
            this.bsqrt.Size = new System.Drawing.Size(46, 35);
            this.bsqrt.TabIndex = 9;
            this.bsqrt.Text = "Sqrt";
            this.bsqrt.UseVisualStyleBackColor = false;
            this.bsqrt.Click += new System.EventHandler(this.bsqrt_Click);
            // 
            // bback
            // 
            this.bback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bback.Location = new System.Drawing.Point(14, 147);
            this.bback.Name = "bback";
            this.bback.Size = new System.Drawing.Size(98, 35);
            this.bback.TabIndex = 10;
            this.bback.Text = "<--";
            this.bback.UseVisualStyleBackColor = false;
            this.bback.Click += new System.EventHandler(this.bback_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n7.Location = new System.Drawing.Point(14, 188);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(46, 35);
            this.n7.TabIndex = 11;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // bsub
            // 
            this.bsub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bsub.Location = new System.Drawing.Point(168, 270);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(46, 35);
            this.bsub.TabIndex = 12;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = false;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bad.Location = new System.Drawing.Point(168, 311);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(46, 35);
            this.bad.TabIndex = 13;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = false;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n9.Location = new System.Drawing.Point(116, 188);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(46, 35);
            this.n9.TabIndex = 14;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n8.Location = new System.Drawing.Point(66, 188);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(46, 35);
            this.n8.TabIndex = 15;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n6.Location = new System.Drawing.Point(116, 229);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(46, 35);
            this.n6.TabIndex = 16;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n5.Location = new System.Drawing.Point(66, 229);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(46, 35);
            this.n5.TabIndex = 17;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n3.Location = new System.Drawing.Point(116, 270);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(46, 35);
            this.n3.TabIndex = 18;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n2.Location = new System.Drawing.Point(66, 270);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(46, 35);
            this.n2.TabIndex = 19;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n1.Location = new System.Drawing.Point(14, 270);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(46, 35);
            this.n1.TabIndex = 20;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n4.Location = new System.Drawing.Point(14, 229);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(46, 35);
            this.n4.TabIndex = 21;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.n0.Location = new System.Drawing.Point(12, 311);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(100, 35);
            this.n0.TabIndex = 22;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // bequal
            // 
            this.bequal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bequal.Location = new System.Drawing.Point(220, 270);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(46, 76);
            this.bequal.TabIndex = 23;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = false;
            this.bequal.Click += new System.EventHandler(this.bequal_Click);
            // 
            // ndot
            // 
            this.ndot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ndot.Location = new System.Drawing.Point(116, 311);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(46, 35);
            this.ndot.TabIndex = 24;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = false;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // bpercent
            // 
            this.bpercent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bpercent.Location = new System.Drawing.Point(220, 188);
            this.bpercent.Name = "bpercent";
            this.bpercent.Size = new System.Drawing.Size(46, 35);
            this.bpercent.TabIndex = 25;
            this.bpercent.Text = "%";
            this.bpercent.UseVisualStyleBackColor = false;
            this.bpercent.Click += new System.EventHandler(this.bpercent_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bdiv.Location = new System.Drawing.Point(168, 188);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(46, 35);
            this.bdiv.TabIndex = 26;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = false;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bmult
            // 
            this.bmult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bmult.Location = new System.Drawing.Point(168, 229);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(46, 35);
            this.bmult.TabIndex = 30;
            this.bmult.Text = "*";
            this.bmult.UseVisualStyleBackColor = false;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // brecip
            // 
            this.brecip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brecip.Location = new System.Drawing.Point(220, 229);
            this.brecip.Name = "brecip";
            this.brecip.Size = new System.Drawing.Size(46, 35);
            this.brecip.TabIndex = 31;
            this.brecip.Text = "1/x";
            this.brecip.UseVisualStyleBackColor = false;
            this.brecip.Click += new System.EventHandler(this.brecip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(278, 358);
            this.Controls.Add(this.brecip);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bpercent);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.bback);
            this.Controls.Add(this.bsqrt);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bce);
            this.Controls.Add(this.bmmin);
            this.Controls.Add(this.bmplus);
            this.Controls.Add(this.bmr);
            this.Controls.Add(this.bmc);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bmc;
        private System.Windows.Forms.Button bmr;
        private System.Windows.Forms.Button bmplus;
        private System.Windows.Forms.Button bmmin;
        private System.Windows.Forms.Button bce;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button bsqrt;
        private System.Windows.Forms.Button bback;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button bpercent;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button brecip;
    }
}

