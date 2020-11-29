namespace calculator
{
    partial class Form6
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
            this.button32 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.RichTextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button35 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button32.Location = new System.Drawing.Point(104, 362);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(40, 40);
            this.button32.TabIndex = 45;
            this.button32.Text = "=";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.PrintResult);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button28.Location = new System.Drawing.Point(196, 122);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(40, 40);
            this.button28.TabIndex = 44;
            this.button28.Text = "^";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button31
            // 
            this.button31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button31.Location = new System.Drawing.Point(196, 242);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(40, 40);
            this.button31.TabIndex = 39;
            this.button31.Text = ")";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button29
            // 
            this.button29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button29.Location = new System.Drawing.Point(150, 242);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(40, 40);
            this.button29.TabIndex = 37;
            this.button29.Text = "(";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(150, 122);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 40);
            this.button19.TabIndex = 25;
            this.button19.Text = "\'√(";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(58, 122);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 18;
            this.button12.Text = "DEL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Backspace);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(12, 122);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 17;
            this.button13.Text = "AC";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button14.Location = new System.Drawing.Point(196, 183);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 16;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button15.Location = new System.Drawing.Point(150, 183);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 40);
            this.button15.TabIndex = 15;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button16.Location = new System.Drawing.Point(242, 242);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 40);
            this.button16.TabIndex = 14;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button17.Location = new System.Drawing.Point(242, 182);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 40);
            this.button17.TabIndex = 13;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDot.Location = new System.Drawing.Point(58, 362);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(40, 40);
            this.buttonDot.TabIndex = 11;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(12, 26);
            this.Screen.Name = "Screen";
            this.Screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Screen.Size = new System.Drawing.Size(269, 74);
            this.Screen.TabIndex = 10;
            this.Screen.Text = "";
            this.Screen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintResult);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button0.Location = new System.Drawing.Point(12, 362);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 40);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(12, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(58, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(104, 182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(12, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(58, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(104, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(104, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(58, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(196, 302);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(85, 99);
            this.button35.TabIndex = 45;
            this.button35.Text = "Finish";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button18.Location = new System.Drawing.Point(104, 122);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 40);
            this.button18.TabIndex = 24;
            this.button18.Text = "√(";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(150, 362);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 46;
            this.button10.Text = ",";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(244, 123);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(38, 40);
            this.button11.TabIndex = 47;
            this.button11.Text = "x10^";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button20.Location = new System.Drawing.Point(150, 302);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 40);
            this.button20.TabIndex = 48;
            this.button20.Text = "%";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 428);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button14);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Screen;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button20;
    }
}