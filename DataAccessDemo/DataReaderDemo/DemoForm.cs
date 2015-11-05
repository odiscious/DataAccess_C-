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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method shows the use of the datareader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillButton_Click(object sender, EventArgs e)
        {
                    
            try
            {
                //set the cursor to the hour glass
                this.Cursor = Cursors.WaitCursor;
           
                customerComboBox.DataSource = NorthwindDataAccess.GetCustomers("");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
                //reset cursor
                this.Cursor = Cursors.Default;
            }


        }

        /// <summary>
        /// This method shows the use of the datareader and building SQL strings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillCountryButton_Click(object sender, EventArgs e)
        {
            //DEMO 2

            try
            {
                //set the cursor to the hour glass
                this.Cursor = Cursors.WaitCursor;

                customer2ComboBox.DataSource = NorthwindDataAccess.GetCustomers(countryTextBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                //reset cursor
                this.Cursor = Cursors.Default;
            }

        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

       
        }

        


    }
