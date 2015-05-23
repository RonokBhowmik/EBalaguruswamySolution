namespace AreaCalculatorApp
{
    partial class AreaCalculatorApplication
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
            this.calculateRadiusButton = new System.Windows.Forms.Button();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Radius";
            // 
            // calculateRadiusButton
            // 
            this.calculateRadiusButton.Location = new System.Drawing.Point(91, 68);
            this.calculateRadiusButton.Name = "calculateRadiusButton";
            this.calculateRadiusButton.Size = new System.Drawing.Size(75, 23);
            this.calculateRadiusButton.TabIndex = 1;
            this.calculateRadiusButton.Text = "Calculate";
            this.calculateRadiusButton.UseVisualStyleBackColor = true;
            this.calculateRadiusButton.Click += new System.EventHandler(this.calculateRadiusButton_Click);
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(91, 26);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 135);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AreaCalculatorApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.calculateRadiusButton);
            this.Controls.Add(this.label1);
            this.Name = "AreaCalculatorApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Calculator Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateRadiusButton;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

