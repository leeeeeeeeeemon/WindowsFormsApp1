
namespace WindowsFormsApp1
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
            this.circleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circleRadius = new System.Windows.Forms.TextBox();
            this.circleX = new System.Windows.Forms.TextBox();
            this.circleY = new System.Windows.Forms.TextBox();
            this.circleR = new System.Windows.Forms.TextBox();
            this.XCircle = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(494, 155);
            this.circleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(67, 32);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 443);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(494, 23);
            this.circleRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(67, 22);
            this.circleRadius.TabIndex = 2;
            this.circleRadius.Text = "20";
            // 
            // circleX
            // 
            this.circleX.Location = new System.Drawing.Point(494, 76);
            this.circleX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleX.Name = "circleX";
            this.circleX.Size = new System.Drawing.Size(67, 22);
            this.circleX.TabIndex = 3;
            this.circleX.Text = "50";
            this.circleX.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // circleY
            // 
            this.circleY.Location = new System.Drawing.Point(494, 129);
            this.circleY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleY.Name = "circleY";
            this.circleY.Size = new System.Drawing.Size(67, 22);
            this.circleY.TabIndex = 4;
            this.circleY.Text = "50";
            this.circleY.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(494, -4);
            this.circleR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(67, 22);
            this.circleR.TabIndex = 6;
            this.circleR.Text = "Radius";
            // 
            // XCircle
            // 
            this.XCircle.Location = new System.Drawing.Point(494, 49);
            this.XCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XCircle.Name = "XCircle";
            this.XCircle.Size = new System.Drawing.Size(67, 22);
            this.XCircle.TabIndex = 6;
            this.XCircle.Text = "X";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(494, 102);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(67, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.XCircle);
            this.Controls.Add(this.circleR);
            this.Controls.Add(this.circleY);
            this.Controls.Add(this.circleX);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.circleButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox circleRadius;
        private System.Windows.Forms.TextBox circleX;
        private System.Windows.Forms.TextBox circleY;
        private System.Windows.Forms.TextBox circleR;
        private System.Windows.Forms.TextBox XCircle;
        private System.Windows.Forms.TextBox textBox7;
    }
}

