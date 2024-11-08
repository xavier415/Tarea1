namespace Tarea1P2
{
    partial class MainForm
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
            this.Editor = new System.Windows.Forms.Button();
            this.Paint = new System.Windows.Forms.Button();
            this.Calculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(21, 69);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(162, 50);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // Paint
            // 
            this.Paint.Location = new System.Drawing.Point(287, 69);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(162, 50);
            this.Paint.TabIndex = 1;
            this.Paint.Text = "Paint";
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // Calculadora
            // 
            this.Calculadora.Location = new System.Drawing.Point(581, 69);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(162, 50);
            this.Calculadora.TabIndex = 2;
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.UseVisualStyleBackColor = true;
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.Editor);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Editor;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Button Calculadora;
    }
}

