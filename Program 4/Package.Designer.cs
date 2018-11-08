namespace Program_4
{
    partial class Package
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
            this.originZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.DestinationZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.originZipCodeLabel = new System.Windows.Forms.Label();
            this.destinationZipCodeLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.packageListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipCodeTextBox
            // 
            this.originZipCodeTextBox.Location = new System.Drawing.Point(120, 6);
            this.originZipCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.originZipCodeTextBox.Multiline = true;
            this.originZipCodeTextBox.Name = "originZipCodeTextBox";
            this.originZipCodeTextBox.Size = new System.Drawing.Size(107, 24);
            this.originZipCodeTextBox.TabIndex = 1;
            // 
            // DestinationZipCodeTextBox
            // 
            this.DestinationZipCodeTextBox.Location = new System.Drawing.Point(120, 33);
            this.DestinationZipCodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DestinationZipCodeTextBox.Multiline = true;
            this.DestinationZipCodeTextBox.Name = "DestinationZipCodeTextBox";
            this.DestinationZipCodeTextBox.Size = new System.Drawing.Size(107, 24);
            this.DestinationZipCodeTextBox.TabIndex = 3;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(120, 61);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lengthTextBox.Multiline = true;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(107, 24);
            this.lengthTextBox.TabIndex = 5;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(120, 89);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.widthTextBox.Multiline = true;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(107, 24);
            this.widthTextBox.TabIndex = 7;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(120, 117);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightTextBox.Multiline = true;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(107, 24);
            this.heightTextBox.TabIndex = 9;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(120, 145);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(107, 24);
            this.weightTextBox.TabIndex = 11;
            // 
            // originZipCodeLabel
            // 
            this.originZipCodeLabel.AutoSize = true;
            this.originZipCodeLabel.Location = new System.Drawing.Point(26, 9);
            this.originZipCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originZipCodeLabel.Name = "originZipCodeLabel";
            this.originZipCodeLabel.Size = new System.Drawing.Size(83, 13);
            this.originZipCodeLabel.TabIndex = 0;
            this.originZipCodeLabel.Text = "Origin Zip Code:";
            // 
            // destinationZipCodeLabel
            // 
            this.destinationZipCodeLabel.AutoSize = true;
            this.destinationZipCodeLabel.Location = new System.Drawing.Point(0, 36);
            this.destinationZipCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.destinationZipCodeLabel.Name = "destinationZipCodeLabel";
            this.destinationZipCodeLabel.Size = new System.Drawing.Size(109, 13);
            this.destinationZipCodeLabel.TabIndex = 2;
            this.destinationZipCodeLabel.Text = "Destination Zip Code:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(66, 64);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(71, 92);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(68, 120);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(65, 148);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "Weight:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(142, 173);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 21);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // packageListBox
            // 
            this.packageListBox.FormattingEnabled = true;
            this.packageListBox.Location = new System.Drawing.Point(242, 6);
            this.packageListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.packageListBox.Name = "packageListBox";
            this.packageListBox.Size = new System.Drawing.Size(116, 173);
            this.packageListBox.TabIndex = 13;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(376, 11);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(80, 24);
            this.detailsButton.TabIndex = 14;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(376, 69);
            this.sendToButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(80, 36);
            this.sendToButton.TabIndex = 15;
            this.sendToButton.Text = "Send To UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(376, 143);
            this.sendFromButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(80, 36);
            this.sendFromButton.TabIndex = 16;
            this.sendFromButton.Text = "Send From UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // Package
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 200);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.packageListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.destinationZipCodeLabel);
            this.Controls.Add(this.originZipCodeLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.DestinationZipCodeTextBox);
            this.Controls.Add(this.originZipCodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Package";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originZipCodeTextBox;
        private System.Windows.Forms.TextBox DestinationZipCodeTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label originZipCodeLabel;
        private System.Windows.Forms.Label destinationZipCodeLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox packageListBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
    }
}

