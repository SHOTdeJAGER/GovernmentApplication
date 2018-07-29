using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp_GovernmentAppWindows
{
    public partial class EmployeeTaxForm : Form
    {
        public EmployeeTaxForm()
        {
            InitializeComponent();
        }

        //Button click event handler for the calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hrsWorked;
            double hrlyRate;
            string[] name = new string[2];

            while (double.TryParse(txtBxHours.Text, out hrsWorked) == false)
            {
                MessageBox.Show("Number value should be " + "entered for hours");
                txtBxHours.Text = "0";
                txtBxHours.Focus();
            }

            if (double.TryParse(txtBxHrlyRate.Text, out hrlyRate ) == false)
            {
                MessageBox.Show("Hourly Rate default value of 0 " + "used for calculations");
                txtBxHrlyRate.Text = "0";
                txtBxHrlyRate.Focus();
            }

            name = txtBxName.Text.Split(' ');
            if (hrsWorked > 0)
            {
                Employee anEmployee = new Employee(name[0], name[1], hrsWorked, hrlyRate);
                txtBxGross.Text = anEmployee.DetermineGross().ToString("C");
                txtBxFica.Text = anEmployee.DetermineFicaTax().ToString("C");
                txtBxFed.Text = anEmployee.DetermineFederalTax().ToString("C");
                txtBxState.Text = anEmployee.DetermineStateTax().ToString("C");
                txtBxHealth.Text = anEmployee.DetermineHealthInsurance().ToString("C");
                txtBxNet.Text = anEmployee.DetermineNet().ToString("C");
                txtBxName.Enabled = false;
                txtBxHours.Visible = false;
                txtBxHrlyRate.Visible = false;
                lblHours.Visible = false;
                lblHrlyRate.Visible = false;
                setVisibility(true);
            }
        }

        //used by both the btnCalculate and btnReset to change the visibility on the objects below the buttons 
        private void setVisibility(bool visibilityValue)
        {
            lblGross.Visible = visibilityValue;
            lblFica.Visible = visibilityValue;
            lblFed.Visible = visibilityValue;
            lblState.Visible = visibilityValue;
            lblHealth.Visible = visibilityValue;
            lblNet.Visible = visibilityValue;
            txtBxGross.Visible = visibilityValue;
            txtBxFica.Visible = visibilityValue;
            txtBxFed.Visible = visibilityValue;
            txtBxState.Visible = visibilityValue;
            txtBxHealth.Visible = visibilityValue;
            txtBxNet.Visible = visibilityValue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxName.Clear();
            txtBxHours.Text = "0";
            txtBxHrlyRate.Text = "0";
            txtBxName.Enabled = true;
            txtBxHours.Visible = true;
            txtBxHrlyRate.Visible = true;
            lblHours.Visible = true;
            lblHrlyRate.Visible = true;
            setVisibility(false);
        }

    }
}
