
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
            this.y_Text = new System.Windows.Forms.TextBox();
            this.CircleText = new System.Windows.Forms.Label();
            this.CircleCheck = new System.Windows.Forms.CheckBox();
            this.LineCheck = new System.Windows.Forms.CheckBox();
            this.LineLabel = new System.Windows.Forms.Label();
            this.LineX = new System.Windows.Forms.TextBox();
            this.LineY = new System.Windows.Forms.TextBox();
            this.LineXText = new System.Windows.Forms.TextBox();
            this.LineYText = new System.Windows.Forms.TextBox();
            this.LineX2 = new System.Windows.Forms.TextBox();
            this.LineY2 = new System.Windows.Forms.TextBox();
            this.LineX2Text = new System.Windows.Forms.TextBox();
            this.LineY2Text = new System.Windows.Forms.TextBox();
            this.lineDrawButton = new System.Windows.Forms.Button();
            this.triangleX = new System.Windows.Forms.TextBox();
            this.triangleX2 = new System.Windows.Forms.TextBox();
            this.triangleY = new System.Windows.Forms.TextBox();
            this.triangleY2 = new System.Windows.Forms.TextBox();
            this.trianglXText = new System.Windows.Forms.TextBox();
            this.trianglX2Text = new System.Windows.Forms.TextBox();
            this.trianglYText = new System.Windows.Forms.TextBox();
            this.trianglY2Text = new System.Windows.Forms.TextBox();
            this.TriangleText = new System.Windows.Forms.Label();
            this.TriangleCheck = new System.Windows.Forms.CheckBox();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.triangleX3 = new System.Windows.Forms.TextBox();
            this.triangleY3 = new System.Windows.Forms.TextBox();
            this.trianglX3Text = new System.Windows.Forms.TextBox();
            this.trianglY3Text = new System.Windows.Forms.TextBox();
            this.rectangleX = new System.Windows.Forms.TextBox();
            this.rectangleY = new System.Windows.Forms.TextBox();
            this.rectangleXText = new System.Windows.Forms.TextBox();
            this.rectangleYText = new System.Windows.Forms.TextBox();
            this.rectangleWidth = new System.Windows.Forms.TextBox();
            this.rectangleWidthText = new System.Windows.Forms.TextBox();
            this.rectangleHeight = new System.Windows.Forms.TextBox();
            this.rectangleHeightText = new System.Windows.Forms.TextBox();
            this.rectangleCheck = new System.Windows.Forms.CheckBox();
            this.rectangleText = new System.Windows.Forms.Label();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(705, 170);
            this.circleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(67, 32);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Draw";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 544);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(705, 38);
            this.circleRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(67, 22);
            this.circleRadius.TabIndex = 2;
            this.circleRadius.Text = "20";
            // 
            // circleX
            // 
            this.circleX.Location = new System.Drawing.Point(705, 91);
            this.circleX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleX.Name = "circleX";
            this.circleX.Size = new System.Drawing.Size(67, 22);
            this.circleX.TabIndex = 3;
            this.circleX.Text = "50";
            // 
            // circleY
            // 
            this.circleY.Location = new System.Drawing.Point(705, 144);
            this.circleY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleY.Name = "circleY";
            this.circleY.Size = new System.Drawing.Size(67, 22);
            this.circleY.TabIndex = 4;
            this.circleY.Text = "50";
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(705, 11);
            this.circleR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(67, 22);
            this.circleR.TabIndex = 6;
            this.circleR.Text = "Radius";
            // 
            // XCircle
            // 
            this.XCircle.Location = new System.Drawing.Point(705, 64);
            this.XCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XCircle.Name = "XCircle";
            this.XCircle.Size = new System.Drawing.Size(67, 22);
            this.XCircle.TabIndex = 6;
            this.XCircle.Text = "X";
            // 
            // y_Text
            // 
            this.y_Text.Location = new System.Drawing.Point(705, 117);
            this.y_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y_Text.Name = "y_Text";
            this.y_Text.Size = new System.Drawing.Size(67, 22);
            this.y_Text.TabIndex = 6;
            this.y_Text.Text = "Y";
            // 
            // CircleText
            // 
            this.CircleText.AutoSize = true;
            this.CircleText.Location = new System.Drawing.Point(729, 360);
            this.CircleText.Name = "CircleText";
            this.CircleText.Size = new System.Drawing.Size(43, 17);
            this.CircleText.TabIndex = 7;
            this.CircleText.Text = "Circle";
            // 
            // CircleCheck
            // 
            this.CircleCheck.AutoSize = true;
            this.CircleCheck.Checked = true;
            this.CircleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CircleCheck.Location = new System.Drawing.Point(741, 381);
            this.CircleCheck.Name = "CircleCheck";
            this.CircleCheck.Size = new System.Drawing.Size(18, 17);
            this.CircleCheck.TabIndex = 8;
            this.CircleCheck.UseVisualStyleBackColor = true;
            this.CircleCheck.CheckedChanged += new System.EventHandler(this.CircleCheck_CheckedChanged);
            // 
            // LineCheck
            // 
            this.LineCheck.AutoSize = true;
            this.LineCheck.Location = new System.Drawing.Point(800, 382);
            this.LineCheck.Name = "LineCheck";
            this.LineCheck.Size = new System.Drawing.Size(18, 17);
            this.LineCheck.TabIndex = 9;
            this.LineCheck.UseVisualStyleBackColor = true;
            this.LineCheck.CheckedChanged += new System.EventHandler(this.LineCheck_CheckedChanged);
            // 
            // LineLabel
            // 
            this.LineLabel.AutoSize = true;
            this.LineLabel.Location = new System.Drawing.Point(797, 360);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(35, 17);
            this.LineLabel.TabIndex = 10;
            this.LineLabel.Text = "Line";
            // 
            // LineX
            // 
            this.LineX.Location = new System.Drawing.Point(778, 38);
            this.LineX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineX.Name = "LineX";
            this.LineX.Size = new System.Drawing.Size(67, 22);
            this.LineX.TabIndex = 3;
            this.LineX.Text = "50";
            // 
            // LineY
            // 
            this.LineY.Location = new System.Drawing.Point(778, 91);
            this.LineY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineY.Name = "LineY";
            this.LineY.Size = new System.Drawing.Size(67, 22);
            this.LineY.TabIndex = 4;
            this.LineY.Text = "50";
            // 
            // LineXText
            // 
            this.LineXText.Location = new System.Drawing.Point(778, 11);
            this.LineXText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineXText.Name = "LineXText";
            this.LineXText.Size = new System.Drawing.Size(67, 22);
            this.LineXText.TabIndex = 6;
            this.LineXText.Text = "X";
            // 
            // LineYText
            // 
            this.LineYText.Location = new System.Drawing.Point(778, 64);
            this.LineYText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineYText.Name = "LineYText";
            this.LineYText.Size = new System.Drawing.Size(67, 22);
            this.LineYText.TabIndex = 6;
            this.LineYText.Text = "Y";
            // 
            // LineX2
            // 
            this.LineX2.Location = new System.Drawing.Point(778, 144);
            this.LineX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineX2.Name = "LineX2";
            this.LineX2.Size = new System.Drawing.Size(67, 22);
            this.LineX2.TabIndex = 3;
            this.LineX2.Text = "100";
            // 
            // LineY2
            // 
            this.LineY2.Location = new System.Drawing.Point(778, 197);
            this.LineY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineY2.Name = "LineY2";
            this.LineY2.Size = new System.Drawing.Size(67, 22);
            this.LineY2.TabIndex = 4;
            this.LineY2.Text = "50";
            // 
            // LineX2Text
            // 
            this.LineX2Text.Location = new System.Drawing.Point(778, 117);
            this.LineX2Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineX2Text.Name = "LineX2Text";
            this.LineX2Text.Size = new System.Drawing.Size(67, 22);
            this.LineX2Text.TabIndex = 6;
            this.LineX2Text.Text = "X2";
            // 
            // LineY2Text
            // 
            this.LineY2Text.Location = new System.Drawing.Point(778, 170);
            this.LineY2Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LineY2Text.Name = "LineY2Text";
            this.LineY2Text.Size = new System.Drawing.Size(67, 22);
            this.LineY2Text.TabIndex = 6;
            this.LineY2Text.Text = "Y2";
            // 
            // lineDrawButton
            // 
            this.lineDrawButton.Location = new System.Drawing.Point(778, 224);
            this.lineDrawButton.Name = "lineDrawButton";
            this.lineDrawButton.Size = new System.Drawing.Size(67, 23);
            this.lineDrawButton.TabIndex = 11;
            this.lineDrawButton.Text = "Draw";
            this.lineDrawButton.UseVisualStyleBackColor = true;
            this.lineDrawButton.Click += new System.EventHandler(this.lineDrawButton_Click);
            // 
            // triangleX
            // 
            this.triangleX.Location = new System.Drawing.Point(851, 38);
            this.triangleX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleX.Name = "triangleX";
            this.triangleX.Size = new System.Drawing.Size(67, 22);
            this.triangleX.TabIndex = 3;
            this.triangleX.Text = "50";
            // 
            // triangleX2
            // 
            this.triangleX2.Location = new System.Drawing.Point(851, 144);
            this.triangleX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleX2.Name = "triangleX2";
            this.triangleX2.Size = new System.Drawing.Size(67, 22);
            this.triangleX2.TabIndex = 3;
            this.triangleX2.Text = "100";
            // 
            // triangleY
            // 
            this.triangleY.Location = new System.Drawing.Point(851, 91);
            this.triangleY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleY.Name = "triangleY";
            this.triangleY.Size = new System.Drawing.Size(67, 22);
            this.triangleY.TabIndex = 4;
            this.triangleY.Text = "50";
            // 
            // triangleY2
            // 
            this.triangleY2.Location = new System.Drawing.Point(851, 197);
            this.triangleY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleY2.Name = "triangleY2";
            this.triangleY2.Size = new System.Drawing.Size(67, 22);
            this.triangleY2.TabIndex = 4;
            this.triangleY2.Text = "100";
            // 
            // trianglXText
            // 
            this.trianglXText.Location = new System.Drawing.Point(851, 11);
            this.trianglXText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglXText.Name = "trianglXText";
            this.trianglXText.Size = new System.Drawing.Size(67, 22);
            this.trianglXText.TabIndex = 6;
            this.trianglXText.Text = "X";
            // 
            // trianglX2Text
            // 
            this.trianglX2Text.Location = new System.Drawing.Point(851, 117);
            this.trianglX2Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglX2Text.Name = "trianglX2Text";
            this.trianglX2Text.Size = new System.Drawing.Size(67, 22);
            this.trianglX2Text.TabIndex = 6;
            this.trianglX2Text.Text = "X2";
            // 
            // trianglYText
            // 
            this.trianglYText.Location = new System.Drawing.Point(851, 64);
            this.trianglYText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglYText.Name = "trianglYText";
            this.trianglYText.Size = new System.Drawing.Size(67, 22);
            this.trianglYText.TabIndex = 6;
            this.trianglYText.Text = "Y";
            // 
            // trianglY2Text
            // 
            this.trianglY2Text.Location = new System.Drawing.Point(851, 170);
            this.trianglY2Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglY2Text.Name = "trianglY2Text";
            this.trianglY2Text.Size = new System.Drawing.Size(67, 22);
            this.trianglY2Text.TabIndex = 6;
            this.trianglY2Text.Text = "Y2";
            // 
            // TriangleText
            // 
            this.TriangleText.AutoSize = true;
            this.TriangleText.Location = new System.Drawing.Point(858, 360);
            this.TriangleText.Name = "TriangleText";
            this.TriangleText.Size = new System.Drawing.Size(60, 17);
            this.TriangleText.TabIndex = 12;
            this.TriangleText.Text = "Triangle";
            // 
            // TriangleCheck
            // 
            this.TriangleCheck.AutoSize = true;
            this.TriangleCheck.Location = new System.Drawing.Point(870, 382);
            this.TriangleCheck.Name = "TriangleCheck";
            this.TriangleCheck.Size = new System.Drawing.Size(18, 17);
            this.TriangleCheck.TabIndex = 13;
            this.TriangleCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TriangleCheck.UseVisualStyleBackColor = true;
            this.TriangleCheck.CheckedChanged += new System.EventHandler(this.TriangleCheck_CheckedChanged);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(851, 329);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(67, 23);
            this.TriangleButton.TabIndex = 14;
            this.TriangleButton.Text = "Draw";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // triangleX3
            // 
            this.triangleX3.Location = new System.Drawing.Point(851, 250);
            this.triangleX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleX3.Name = "triangleX3";
            this.triangleX3.Size = new System.Drawing.Size(67, 22);
            this.triangleX3.TabIndex = 3;
            this.triangleX3.Text = "300";
            // 
            // triangleY3
            // 
            this.triangleY3.Location = new System.Drawing.Point(851, 302);
            this.triangleY3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangleY3.Name = "triangleY3";
            this.triangleY3.Size = new System.Drawing.Size(67, 22);
            this.triangleY3.TabIndex = 4;
            this.triangleY3.Text = "100";
            // 
            // trianglX3Text
            // 
            this.trianglX3Text.Location = new System.Drawing.Point(851, 223);
            this.trianglX3Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglX3Text.Name = "trianglX3Text";
            this.trianglX3Text.Size = new System.Drawing.Size(67, 22);
            this.trianglX3Text.TabIndex = 6;
            this.trianglX3Text.Text = "X3";
            // 
            // trianglY3Text
            // 
            this.trianglY3Text.Location = new System.Drawing.Point(851, 276);
            this.trianglY3Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trianglY3Text.Name = "trianglY3Text";
            this.trianglY3Text.Size = new System.Drawing.Size(67, 22);
            this.trianglY3Text.TabIndex = 6;
            this.trianglY3Text.Text = "Y3";
            // 
            // rectangleX
            // 
            this.rectangleX.Location = new System.Drawing.Point(924, 38);
            this.rectangleX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleX.Name = "rectangleX";
            this.rectangleX.Size = new System.Drawing.Size(67, 22);
            this.rectangleX.TabIndex = 3;
            this.rectangleX.Text = "50";
            // 
            // rectangleY
            // 
            this.rectangleY.Location = new System.Drawing.Point(924, 91);
            this.rectangleY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleY.Name = "rectangleY";
            this.rectangleY.Size = new System.Drawing.Size(67, 22);
            this.rectangleY.TabIndex = 4;
            this.rectangleY.Text = "50";
            // 
            // rectangleXText
            // 
            this.rectangleXText.Location = new System.Drawing.Point(924, 11);
            this.rectangleXText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleXText.Name = "rectangleXText";
            this.rectangleXText.Size = new System.Drawing.Size(67, 22);
            this.rectangleXText.TabIndex = 6;
            this.rectangleXText.Text = "X";
            // 
            // rectangleYText
            // 
            this.rectangleYText.Location = new System.Drawing.Point(924, 64);
            this.rectangleYText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleYText.Name = "rectangleYText";
            this.rectangleYText.Size = new System.Drawing.Size(67, 22);
            this.rectangleYText.TabIndex = 6;
            this.rectangleYText.Text = "Y";
            // 
            // rectangleWidth
            // 
            this.rectangleWidth.Location = new System.Drawing.Point(924, 144);
            this.rectangleWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleWidth.Name = "rectangleWidth";
            this.rectangleWidth.Size = new System.Drawing.Size(67, 22);
            this.rectangleWidth.TabIndex = 2;
            this.rectangleWidth.Text = "20";
            // 
            // rectangleWidthText
            // 
            this.rectangleWidthText.Location = new System.Drawing.Point(924, 117);
            this.rectangleWidthText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleWidthText.Name = "rectangleWidthText";
            this.rectangleWidthText.Size = new System.Drawing.Size(67, 22);
            this.rectangleWidthText.TabIndex = 6;
            this.rectangleWidthText.Text = "Width";
            // 
            // rectangleHeight
            // 
            this.rectangleHeight.Location = new System.Drawing.Point(924, 197);
            this.rectangleHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleHeight.Name = "rectangleHeight";
            this.rectangleHeight.Size = new System.Drawing.Size(67, 22);
            this.rectangleHeight.TabIndex = 2;
            this.rectangleHeight.Text = "20";
            // 
            // rectangleHeightText
            // 
            this.rectangleHeightText.Location = new System.Drawing.Point(924, 170);
            this.rectangleHeightText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleHeightText.Name = "rectangleHeightText";
            this.rectangleHeightText.Size = new System.Drawing.Size(67, 22);
            this.rectangleHeightText.TabIndex = 6;
            this.rectangleHeightText.Text = "Height";
            // 
            // rectangleCheck
            // 
            this.rectangleCheck.AutoSize = true;
            this.rectangleCheck.Location = new System.Drawing.Point(953, 382);
            this.rectangleCheck.Name = "rectangleCheck";
            this.rectangleCheck.Size = new System.Drawing.Size(18, 17);
            this.rectangleCheck.TabIndex = 15;
            this.rectangleCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangleCheck.UseVisualStyleBackColor = true;
            this.rectangleCheck.CheckedChanged += new System.EventHandler(this.rectangleCheck_CheckedChanged);
            // 
            // rectangleText
            // 
            this.rectangleText.AutoSize = true;
            this.rectangleText.Location = new System.Drawing.Point(926, 360);
            this.rectangleText.Name = "rectangleText";
            this.rectangleText.Size = new System.Drawing.Size(72, 17);
            this.rectangleText.TabIndex = 16;
            this.rectangleText.Text = "Rectangle";
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(924, 224);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(67, 23);
            this.rectangleButton.TabIndex = 17;
            this.rectangleButton.Text = "Draw";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 539);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.rectangleText);
            this.Controls.Add(this.rectangleCheck);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.TriangleCheck);
            this.Controls.Add(this.TriangleText);
            this.Controls.Add(this.lineDrawButton);
            this.Controls.Add(this.LineLabel);
            this.Controls.Add(this.LineCheck);
            this.Controls.Add(this.CircleCheck);
            this.Controls.Add(this.CircleText);
            this.Controls.Add(this.trianglY3Text);
            this.Controls.Add(this.trianglY2Text);
            this.Controls.Add(this.LineY2Text);
            this.Controls.Add(this.rectangleYText);
            this.Controls.Add(this.trianglYText);
            this.Controls.Add(this.LineYText);
            this.Controls.Add(this.y_Text);
            this.Controls.Add(this.trianglX3Text);
            this.Controls.Add(this.trianglX2Text);
            this.Controls.Add(this.LineX2Text);
            this.Controls.Add(this.triangleY3);
            this.Controls.Add(this.rectangleXText);
            this.Controls.Add(this.trianglXText);
            this.Controls.Add(this.triangleY2);
            this.Controls.Add(this.LineXText);
            this.Controls.Add(this.rectangleY);
            this.Controls.Add(this.LineY2);
            this.Controls.Add(this.triangleY);
            this.Controls.Add(this.triangleX3);
            this.Controls.Add(this.XCircle);
            this.Controls.Add(this.triangleX2);
            this.Controls.Add(this.LineY);
            this.Controls.Add(this.rectangleX);
            this.Controls.Add(this.LineX2);
            this.Controls.Add(this.triangleX);
            this.Controls.Add(this.rectangleHeightText);
            this.Controls.Add(this.rectangleWidthText);
            this.Controls.Add(this.circleR);
            this.Controls.Add(this.LineX);
            this.Controls.Add(this.rectangleHeight);
            this.Controls.Add(this.circleY);
            this.Controls.Add(this.rectangleWidth);
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
        private System.Windows.Forms.TextBox y_Text;
        private System.Windows.Forms.Label CircleText;
        private System.Windows.Forms.CheckBox CircleCheck;
        private System.Windows.Forms.CheckBox LineCheck;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.TextBox LineX;
        private System.Windows.Forms.TextBox LineY;
        private System.Windows.Forms.TextBox LineXText;
        private System.Windows.Forms.TextBox LineYText;
        private System.Windows.Forms.TextBox LineX2;
        private System.Windows.Forms.TextBox LineY2;
        private System.Windows.Forms.TextBox LineX2Text;
        private System.Windows.Forms.TextBox LineY2Text;
        private System.Windows.Forms.Button lineDrawButton;
        private System.Windows.Forms.TextBox triangleX;
        private System.Windows.Forms.TextBox triangleX2;
        private System.Windows.Forms.TextBox triangleY;
        private System.Windows.Forms.TextBox triangleY2;
        private System.Windows.Forms.TextBox trianglXText;
        private System.Windows.Forms.TextBox trianglX2Text;
        private System.Windows.Forms.TextBox trianglYText;
        private System.Windows.Forms.TextBox trianglY2Text;
        private System.Windows.Forms.Label TriangleText;
        private System.Windows.Forms.CheckBox TriangleCheck;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.TextBox triangleX3;
        private System.Windows.Forms.TextBox triangleY3;
        private System.Windows.Forms.TextBox trianglX3Text;
        private System.Windows.Forms.TextBox trianglY3Text;
        private System.Windows.Forms.TextBox rectangleX;
        private System.Windows.Forms.TextBox rectangleY;
        private System.Windows.Forms.TextBox rectangleXText;
        private System.Windows.Forms.TextBox rectangleYText;
        private System.Windows.Forms.TextBox rectangleWidth;
        private System.Windows.Forms.TextBox rectangleWidthText;
        private System.Windows.Forms.TextBox rectangleHeight;
        private System.Windows.Forms.TextBox rectangleHeightText;
        private System.Windows.Forms.CheckBox rectangleCheck;
        private System.Windows.Forms.Label rectangleText;
        private System.Windows.Forms.Button rectangleButton;
    }
}

