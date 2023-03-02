namespace LSM.Calc2.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(4, 60);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 38);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(58, 60);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 38);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.digit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(108, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(216, 173);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(44, 81);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "=";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(216, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 47);
            this.button7.TabIndex = 6;
            this.button7.Text = "1/x";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.op_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(216, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 54);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sqrt";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.op_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(162, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 48);
            this.button9.TabIndex = 8;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.op_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(162, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 48);
            this.button10.TabIndex = 9;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.op_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(162, 104);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 42);
            this.button11.TabIndex = 10;
            this.button11.Text = "*";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.op_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(162, 60);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(48, 38);
            this.button12.TabIndex = 11;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.op_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(108, 206);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(48, 48);
            this.button13.TabIndex = 12;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(108, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(48, 48);
            this.button14.TabIndex = 13;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.digit_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(108, 104);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 42);
            this.button15.TabIndex = 14;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.digit_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(108, 60);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 38);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.digit_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(58, 206);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(48, 48);
            this.button17.TabIndex = 16;
            this.button17.Text = "(+/-)";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.op_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 206);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 48);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.digit_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(58, 152);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(48, 48);
            this.button19.TabIndex = 18;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.digit_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 152);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(48, 48);
            this.button20.TabIndex = 19;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.digit_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(58, 104);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(48, 42);
            this.button21.TabIndex = 20;
            this.button21.Text = "5";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.digit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(4, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(244, 23);
            this.txtResult.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 264);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button button3;
        private Button btnClear;
        private Button btnBack;
        private Button btnCalc;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button btn9;
        private Button button17;
        private Button btn0;
        private Button button19;
        private Button button20;
        private Button button21;
        private TextBox txtResult;
    }
}