namespace ProgramSolution1._15
{
    partial class ArithmeticApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.differenceTextBox = new System.Windows.Forms.TextBox();
            this.divisionTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "y=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Division";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Difference";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(102, 18);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 1;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(102, 96);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 1;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(102, 150);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTextBox.TabIndex = 1;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(329, 18);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // differenceTextBox
            // 
            this.differenceTextBox.Location = new System.Drawing.Point(329, 96);
            this.differenceTextBox.Name = "differenceTextBox";
            this.differenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.differenceTextBox.TabIndex = 1;
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.Location = new System.Drawing.Point(329, 150);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(100, 20);
            this.divisionTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(200, 53);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ArithmeticApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.divisionTextBox);
            this.Controls.Add(this.differenceTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArithmeticApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic Calculation Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox differenceTextBox;
        private System.Windows.Forms.TextBox divisionTextBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}

