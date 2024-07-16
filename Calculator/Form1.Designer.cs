namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            text_Total = new TextBox();
            button_ac = new Button();
            button_pc = new Button();
            button_per = new Button();
            button_divide = new Button();
            button_multiply = new Button();
            button_9 = new Button();
            button_8 = new Button();
            button_7 = new Button();
            button_plus = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            button_minus = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_equal = new Button();
            button_comma = new Button();
            button_0 = new Button();
            SuspendLayout();
            // 
            // text_Total
            // 
            text_Total.BackColor = Color.Black;
            text_Total.BorderStyle = BorderStyle.None;
            text_Total.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Total.ForeColor = Color.White;
            text_Total.Location = new Point(21, 23);
            text_Total.Multiline = true;
            text_Total.Name = "text_Total";
            text_Total.RightToLeft = RightToLeft.No;
            text_Total.Size = new Size(360, 124);
            text_Total.TabIndex = 0;
            text_Total.TextAlign = HorizontalAlignment.Right;
            // 
            // button_ac
            // 
            button_ac.BackColor = Color.FromArgb(165, 165, 165);
            button_ac.FlatStyle = FlatStyle.Flat;
            button_ac.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ac.Location = new Point(21, 169);
            button_ac.Name = "button_ac";
            button_ac.Size = new Size(75, 69);
            button_ac.TabIndex = 1;
            button_ac.Text = "AC";
            button_ac.UseVisualStyleBackColor = false;
            button_ac.Click += button_ac_Click;
            // 
            // button_pc
            // 
            button_pc.BackColor = Color.FromArgb(165, 165, 165);
            button_pc.FlatStyle = FlatStyle.Flat;
            button_pc.Font = new Font("Segoe UI", 18F);
            button_pc.Location = new Point(118, 169);
            button_pc.Name = "button_pc";
            button_pc.Size = new Size(75, 69);
            button_pc.TabIndex = 2;
            button_pc.Text = "+/-";
            button_pc.UseVisualStyleBackColor = false;
            // 
            // button_per
            // 
            button_per.BackColor = Color.FromArgb(165, 165, 165);
            button_per.FlatStyle = FlatStyle.Flat;
            button_per.Font = new Font("Segoe UI", 18F);
            button_per.Location = new Point(213, 169);
            button_per.Name = "button_per";
            button_per.Size = new Size(75, 69);
            button_per.TabIndex = 3;
            button_per.Text = "%";
            button_per.UseVisualStyleBackColor = false;
            button_per.Click += button_per_Click;
            // 
            // button_divide
            // 
            button_divide.BackColor = Color.FromArgb(255, 159, 10);
            button_divide.FlatStyle = FlatStyle.Popup;
            button_divide.Font = new Font("Segoe UI", 18F);
            button_divide.ForeColor = Color.White;
            button_divide.Location = new Point(306, 169);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(75, 69);
            button_divide.TabIndex = 4;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = false;
            button_divide.Click += button_divide_Click;
            // 
            // button_multiply
            // 
            button_multiply.BackColor = Color.FromArgb(255, 159, 10);
            button_multiply.FlatStyle = FlatStyle.Popup;
            button_multiply.Font = new Font("Segoe UI", 18F);
            button_multiply.ForeColor = Color.White;
            button_multiply.Location = new Point(306, 259);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(75, 69);
            button_multiply.TabIndex = 8;
            button_multiply.Text = "X";
            button_multiply.UseVisualStyleBackColor = false;
            button_multiply.Click += button_multiply_Click;
            // 
            // button_9
            // 
            button_9.BackColor = Color.FromArgb(51, 51, 51);
            button_9.FlatStyle = FlatStyle.Popup;
            button_9.Font = new Font("Segoe UI", 18F);
            button_9.ForeColor = Color.White;
            button_9.Location = new Point(213, 259);
            button_9.Name = "button_9";
            button_9.Size = new Size(75, 69);
            button_9.TabIndex = 7;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = false;
            button_9.Click += button_9_Click;
            // 
            // button_8
            // 
            button_8.BackColor = Color.FromArgb(51, 51, 51);
            button_8.FlatStyle = FlatStyle.Popup;
            button_8.Font = new Font("Segoe UI", 18F);
            button_8.ForeColor = Color.White;
            button_8.Location = new Point(118, 259);
            button_8.Name = "button_8";
            button_8.Size = new Size(75, 69);
            button_8.TabIndex = 6;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = false;
            button_8.Click += button_8_Click;
            // 
            // button_7
            // 
            button_7.BackColor = Color.FromArgb(51, 51, 51);
            button_7.FlatStyle = FlatStyle.Popup;
            button_7.Font = new Font("Segoe UI", 18F);
            button_7.ForeColor = Color.White;
            button_7.Location = new Point(21, 259);
            button_7.Name = "button_7";
            button_7.Size = new Size(75, 69);
            button_7.TabIndex = 5;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = false;
            button_7.Click += button_7_Click;
            // 
            // button_plus
            // 
            button_plus.BackColor = Color.FromArgb(255, 159, 10);
            button_plus.FlatStyle = FlatStyle.Popup;
            button_plus.Font = new Font("Segoe UI", 18F);
            button_plus.ForeColor = Color.White;
            button_plus.Location = new Point(306, 439);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(75, 69);
            button_plus.TabIndex = 16;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = false;
            button_plus.Click += button_plus_Click;
            // 
            // button_3
            // 
            button_3.BackColor = Color.FromArgb(51, 51, 51);
            button_3.FlatStyle = FlatStyle.Popup;
            button_3.Font = new Font("Segoe UI", 18F);
            button_3.ForeColor = Color.White;
            button_3.Location = new Point(213, 439);
            button_3.Name = "button_3";
            button_3.Size = new Size(75, 69);
            button_3.TabIndex = 15;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = false;
            button_3.Click += button_3_Click;
            // 
            // button_2
            // 
            button_2.BackColor = Color.FromArgb(51, 51, 51);
            button_2.FlatStyle = FlatStyle.Popup;
            button_2.Font = new Font("Segoe UI", 18F);
            button_2.ForeColor = Color.White;
            button_2.Location = new Point(118, 439);
            button_2.Name = "button_2";
            button_2.Size = new Size(75, 69);
            button_2.TabIndex = 14;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = false;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.BackColor = Color.FromArgb(51, 51, 51);
            button_1.FlatStyle = FlatStyle.Popup;
            button_1.Font = new Font("Segoe UI", 18F);
            button_1.ForeColor = Color.White;
            button_1.Location = new Point(21, 439);
            button_1.Name = "button_1";
            button_1.Size = new Size(75, 69);
            button_1.TabIndex = 13;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // button_minus
            // 
            button_minus.BackColor = Color.FromArgb(255, 159, 10);
            button_minus.FlatStyle = FlatStyle.Popup;
            button_minus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_minus.ForeColor = Color.White;
            button_minus.Location = new Point(306, 349);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(75, 69);
            button_minus.TabIndex = 12;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = false;
            button_minus.Click += button_minus_Click;
            // 
            // button_6
            // 
            button_6.BackColor = Color.FromArgb(51, 51, 51);
            button_6.FlatStyle = FlatStyle.Popup;
            button_6.Font = new Font("Segoe UI", 18F);
            button_6.ForeColor = Color.White;
            button_6.Location = new Point(213, 349);
            button_6.Name = "button_6";
            button_6.Size = new Size(75, 69);
            button_6.TabIndex = 11;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = false;
            button_6.Click += button_6_Click;
            // 
            // button_5
            // 
            button_5.BackColor = Color.FromArgb(51, 51, 51);
            button_5.FlatStyle = FlatStyle.Popup;
            button_5.Font = new Font("Segoe UI", 18F);
            button_5.ForeColor = Color.White;
            button_5.Location = new Point(118, 349);
            button_5.Name = "button_5";
            button_5.Size = new Size(75, 69);
            button_5.TabIndex = 10;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = false;
            button_5.Click += button_5_Click;
            // 
            // button_4
            // 
            button_4.BackColor = Color.FromArgb(51, 51, 51);
            button_4.FlatStyle = FlatStyle.Popup;
            button_4.Font = new Font("Segoe UI", 18F);
            button_4.ForeColor = Color.White;
            button_4.Location = new Point(21, 349);
            button_4.Name = "button_4";
            button_4.Size = new Size(75, 69);
            button_4.TabIndex = 9;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = false;
            button_4.Click += button_4_Click;
            // 
            // button_equal
            // 
            button_equal.BackColor = Color.FromArgb(255, 159, 10);
            button_equal.FlatStyle = FlatStyle.Popup;
            button_equal.Font = new Font("Segoe UI", 18F);
            button_equal.ForeColor = Color.White;
            button_equal.Location = new Point(306, 529);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(75, 69);
            button_equal.TabIndex = 20;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = false;
            button_equal.Click += button_equal_Click;
            // 
            // button_comma
            // 
            button_comma.BackColor = Color.FromArgb(51, 51, 51);
            button_comma.FlatStyle = FlatStyle.Popup;
            button_comma.Font = new Font("Segoe UI", 18F);
            button_comma.ForeColor = Color.White;
            button_comma.Location = new Point(213, 529);
            button_comma.Name = "button_comma";
            button_comma.Size = new Size(75, 69);
            button_comma.TabIndex = 19;
            button_comma.Text = ",";
            button_comma.UseVisualStyleBackColor = false;
            button_comma.Click += button_comma_Click;
            // 
            // button_0
            // 
            button_0.BackColor = Color.FromArgb(51, 51, 51);
            button_0.FlatStyle = FlatStyle.Popup;
            button_0.Font = new Font("Segoe UI", 18F);
            button_0.ForeColor = Color.White;
            button_0.Location = new Point(21, 529);
            button_0.Name = "button_0";
            button_0.Size = new Size(172, 69);
            button_0.TabIndex = 17;
            button_0.Text = "0";
            button_0.TextAlign = ContentAlignment.MiddleLeft;
            button_0.UseVisualStyleBackColor = false;
            button_0.Click += button_0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(404, 636);
            Controls.Add(button_equal);
            Controls.Add(button_comma);
            Controls.Add(button_0);
            Controls.Add(button_plus);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(button_minus);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_multiply);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_divide);
            Controls.Add(button_per);
            Controls.Add(button_pc);
            Controls.Add(button_ac);
            Controls.Add(text_Total);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_Total;
        private Button button_ac;
        private Button button_pc;
        private Button button_per;
        private Button button_divide;
        private Button button_multiply;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private Button button_plus;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button button_minus;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_equal;
        private Button button_comma;
        private Button button_0;
    }
}
