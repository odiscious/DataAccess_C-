using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            new DemoForm().Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            new DataChangeDemoForm().Show();
        }
    }
}