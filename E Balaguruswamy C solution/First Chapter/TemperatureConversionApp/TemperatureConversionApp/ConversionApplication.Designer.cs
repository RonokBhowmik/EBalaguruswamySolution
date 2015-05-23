namespace TemperatureConversionApp
{
    partial class ConversionApplication
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
            this.conversionTwoButton = new System.Windows.Forms.Button();
            this.conversionOnebutton = new System.Windows.Forms.Button();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculate1Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius to Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit to Celsius";
            // 
            // conversionTwoButton
            // 
            this.conversionTwoButton.Location = new System.Drawing.Point(176, 64);
            this.conversionTwoButton.Name = "conversionTwoButton";
            this.conversionTwoButton.Size = new System.Drawing.Size(75, 23);
            this.conversionTwoButton.TabIndex = 1;
            this.conversionTwoButton.Text = "Option 2";
            this.conversionTwoButton.UseVisualStyleBackColor = true;
            this.conversionTwoButton.Click += new System.EventHandler(this.conversionTwoButton_Click);
            // 
            // conversionOnebutton
            // 
            this.conversionOnebutton.Location = new System.Drawing.Point(176, 20);
            this.conversionOnebutton.Name = "conversionOnebutton";
            this.conversionOnebutton.Size = new System.Drawing.Size(75, 23);
            this.conversionOnebutton.TabIndex = 0;
            this.conversionOnebutton.Text = "Option 1";
            this.conversionOnebutton.UseVisualStyleBackColor = true;
            this.conversionOnebutton.Click += new System.EventHandler(this.conversionOnebutton_Click);
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Enabled = false;
            this.celsiusTextBox.Location = new System.Drawing.Point(381, 20);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(75, 20);
            this.celsiusTextBox.TabIndex = 2;
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Enabled = false;
            this.fahrenheitTextBox.Location = new System.Drawing.Point(381, 67);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(75, 20);
            this.fahrenheitTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input for Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input for Fahrenheit ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(487, 69);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculate1Button
            // 
            this.calculate1Button.Location = new System.Drawing.Point(487, 14);
            this.calculate1Button.Name = "calculate1Button";
            this.calculate1Button.Size = new System.Drawing.Size(75, 23);
            this.calculate1Button.TabIndex = 5;
            this.calculate1Button.Text = "Calculate";
            this.calculate1Button.UseVisualStyleBackColor = true;
            this.calculate1Button.Click += new System.EventHandler(this.calculate1Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(535, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ConversionApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 171);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculate1Button);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.conversionOnebutton);
            this.Controls.Add(this.conversionTwoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConversionApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button conversionTwoButton;
        private System.Windows.Forms.Button conversionOnebutton;
        private System.Windows.Forms.TextBox celsiusTextBox;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button calculate1Button;
        private System.Windows.Forms.Button exitButton;
    }
}

