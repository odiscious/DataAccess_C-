namespace DataDemo
{
    partial class DemoForm
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
            this.customerCombo1 = new System.Windows.Forms.GroupBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fillCountryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.customer2ComboBox = new System.Windows.Forms.ComboBox();
            this.customerCombo1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerCombo1
            // 
            this.customerCombo1.Controls.Add(this.customerComboBox);
            this.customerCombo1.Controls.Add(this.fillButton);
            this.customerCombo1.Location = new System.Drawing.Point(18, 13);
            this.customerCombo1.Margin = new System.Windows.Forms.Padding(4);
            this.customerCombo1.Name = "customerCombo1";
            this.customerCombo1.Padding = new System.Windows.Forms.Padding(4);
            this.customerCombo1.Size = new System.Drawing.Size(584, 137);
            this.customerCombo1.TabIndex = 0;
            this.customerCombo1.TabStop = false;
            this.customerCombo1.Text = "Demo 1";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(96, 75);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(288, 24);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(181, 22);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(115, 31);
            this.fillButton.TabIndex = 0;
            this.fillButton.Text = "Fill Combo";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fillCountryButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.countryTextBox);
            this.groupBox2.Controls.Add(this.customer2ComboBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 144);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demo 2";
            // 
            // fillCountryButton
            // 
            this.fillCountryButton.Location = new System.Drawing.Point(344, 40);
            this.fillCountryButton.Name = "fillCountryButton";
            this.fillCountryButton.Size = new System.Drawing.Size(104, 32);
            this.fillCountryButton.TabIndex = 3;
            this.fillCountryButton.Text = "Fill Combo";
            this.fillCountryButton.Click += new System.EventHandler(this.fillCountryButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(8, 88);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(168, 22);
            this.countryTextBox.TabIndex = 1;
            // 
            // customer2ComboBox
            // 
            this.customer2ComboBox.Location = new System.Drawing.Point(248, 88);
            this.customer2ComboBox.Name = "customer2ComboBox";
            this.customer2ComboBox.Size = new System.Drawing.Size(296, 24);
            this.customer2ComboBox.TabIndex = 0;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customerCombo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            this.customerCombo1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerCombo1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button fillButton;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button fillCountryButton;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox countryTextBox;
        internal System.Windows.Forms.ComboBox customer2ComboBox;

    }
}

