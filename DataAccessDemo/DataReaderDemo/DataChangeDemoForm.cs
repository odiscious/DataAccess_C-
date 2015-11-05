using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLib;

namespace DataDemo
{
    public partial class DataChangeDemoForm : Form
    {
        public DataChangeDemoForm()
        {
            InitializeComponent();
        }

        private void add1Button_Click(object sender, EventArgs e)
        {
            int rowsInserted;

            try
            {
                rowsInserted = NorthwindDataAccess.AddShipper(companyNameTextBox.Text, phoneTextBox.Text);
                if (rowsInserted == 1)
                {
                    MessageBox.Show("You have successfully added a Shipper.");
                    //clear the text from the textboxes
                    companyNameTextBox.Clear();
                    phoneTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Your Shipper has NOT been added to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void countButton_Click(object sender, EventArgs e)
        {
            int count;

            try
            {
                count = NorthwindDataAccess.CountShippers();
               
                  shipperCountLabel.Text = count.ToString();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}