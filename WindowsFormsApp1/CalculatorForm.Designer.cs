﻿namespace WindowsFormsApp1
{
    partial class CalculatorForm
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
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(35, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(350, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(50, 280);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 75);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(50, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(130, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(210, 40);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(290, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 75);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(290, 120);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 75);
            this.buttonSub.TabIndex = 12;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(290, 200);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 75);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(290, 280);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 75);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(50, 360);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(230, 75);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.Divisiones_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(290, 360);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 75);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
    }
}