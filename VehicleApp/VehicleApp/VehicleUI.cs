using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        public VehicleUI()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = vehicleNameTextBox.Text;
            string regNo = regNoTextBox.Text;
            aVehicle = new Vehicle(name, regNo);
            vehicleNameTextBox.ReadOnly = true;
            regNoTextBox.ReadOnly = true;
            createButton.Enabled = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.InputSpeed = Convert.ToDouble(inputSpeedTextBox.Text);
            aVehicle.CalculateMinSpeed();
            aVehicle.CalculateMaxSpeed();
            aVehicle.CalculateAverageSpeed();
            MessageBox.Show("Speed added.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.MinSpeed.ToString();
            maxSpeedTextBox.Text = aVehicle.MaxSpeed.ToString();
            averageSpeedTextBox.Text = aVehicle.AverageSpeed.ToString();
        }
    }
}
