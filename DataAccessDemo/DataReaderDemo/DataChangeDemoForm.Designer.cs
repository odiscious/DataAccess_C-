namespace DataDemo
{
    partial class DataChangeDemoForm
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
            this.shipperCountLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.add1Button = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shipperCountLabel
            // 
            this.shipperCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipperCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipperCountLabel.Location = new System.Drawing.Point(209, 256);
            this.shipperCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shipperCountLabel.Name = "shipperCountLabel";
            this.shipperCountLabel.Size = new System.Drawing.Size(192, 25);
            this.shipperCountLabel.TabIndex = 34;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 260);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(240, 25);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Number of Shippers";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(19, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 25);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Company Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(212, 81);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(188, 20);
            this.phoneTextBox.TabIndex = 29;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(212, 31);
            this.companyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.companyNameTextBox.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(19, 81);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(156, 25);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Phone";
            // 
            // add1Button
            // 
            this.add1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1Button.Location = new System.Drawing.Point(432, 31);
            this.add1Button.Margin = new System.Windows.Forms.Padding(4);
            this.add1Button.Name = "add1Button";
            this.add1Button.Size = new System.Drawing.Size(170, 29);
            this.add1Button.TabIndex = 25;
            this.add1Button.Text = "Add Shipper ";
            this.add1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add1Button.Click += new System.EventHandler(this.add1Button_Click);
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countButton.Location = new System.Drawing.Point(432, 252);
            this.countButton.Margin = new System.Windows.Forms.Padding(4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(170, 29);
            this.countButton.TabIndex = 26;
            this.countButton.Text = "Show Shipper Count";
            this.countButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // DataChangeDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 467);
            this.Controls.Add(this.shipperCountLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.add1Button);
            this.Controls.Add(this.countButton);
            this.Name = "DataChangeDemoForm";
            this.Text = "DataChangeDemoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label shipperCountLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox phoneTextBox;
        internal System.Windows.Forms.TextBox companyNameTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button add1Button;
        internal System.Windows.Forms.Button countButton;
    }
}