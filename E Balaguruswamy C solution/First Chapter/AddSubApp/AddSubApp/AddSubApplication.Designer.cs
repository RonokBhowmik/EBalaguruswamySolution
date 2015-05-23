namespace AddSubApp
{
    partial class AddSubApplication
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
            this.exitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.numberOneTextBox = new System.Windows.Forms.TextBox();
            this.numberTwoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number 2";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(53, 134);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(159, 134);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 3;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // numberOneTextBox
            // 
            this.numberOneTextBox.Location = new System.Drawing.Point(99, 28);
            this.numberOneTextBox.Name = "numberOneTextBox";
            this.numberOneTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOneTextBox.TabIndex = 0;
            // 
            // numberTwoTextBox
            // 
            this.numberTwoTextBox.Location = new System.Drawing.Point(99, 82);
            this.numberTwoTextBox.Name = "numberTwoTextBox";
            this.numberTwoTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTwoTextBox.TabIndex = 1;
            // 
            // AddSubApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numberTwoTextBox);
            this.Controls.Add(this.numberOneTextBox);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSubApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionSubstractionApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.TextBox numberOneTextBox;
        private System.Windows.Forms.TextBox numberTwoTextBox;
    }
}

