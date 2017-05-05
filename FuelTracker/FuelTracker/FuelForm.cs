using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelTracker
{
    public partial class FuelForm : Form
    {
        PsudoDataLayer DataLayer;
        Vehicle[] vehicleList;

        Vehicle currrentVehicle;
        

        public FuelForm()
        {
            InitializeComponent();
            DialogResult result = MessageBox.Show("Would you like to initialise some data?", "Add Data?", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                DataLayer = new PsudoDataLayer(true);
                UpdateVehicles();
                UIUpdateMenuItems();
            }
            else
            {
                DataLayer = new PsudoDataLayer(false);
            }
            subscribeToVehicles();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subscribeToVehicles()
        {
            foreach (var vehicles in vehicleList)
            {
                vehicles.Rented += new OnVehicleRented_EventHandler(vehicleRented);
            }

        }

        private void UpdateVehicles()
        {
            vehicleList = DataLayer.Vehicles;

            for (int i = 0; i < vehicleList.Length; i++)
            {
                //listVehicles.Items.Add($"{vehicleList[i].VehicleID}: MANUFACTURER: {vehicleList[i].Manufacturer.Name} - MODEL: {vehicleList[i].Model} - REGISTRATION: {vehicleList[i].Registration} - FUEL ECONOMY: {vehicleList[i].FuelEconomy} - TRAVELED: {vehicleList[i].DistanceTravelled}");
                DataGridViewRow row = (DataGridViewRow)vehicleDataGrid.Rows[0].Clone();
                row.Cells[0].Value = vehicleList[i].VehicleID;
                row.Cells[1].Value = vehicleList[i].Manufacturer.Name;
                row.Cells[2].Value = vehicleList[i].Model;
                row.Cells[3].Value = vehicleList[i].Year;
                row.Cells[4].Value = vehicleList[i].Registration;
                row.Cells[5].Value = vehicleList[i].FuelEconomy;
                row.Cells[6].Value = vehicleList[i].DistanceTravelled;
                row.Cells[7].Value = vehicleList[i].Services;
                row.Cells[8].Value = "Show";
                vehicleDataGrid.Rows.Add(row);
                
            }
            vehicleDataGrid.AutoResizeColumns();
            UIUpdateData();
        }
        
        private void UIUpdateVehicleInfo()
        {
            if (currrentVehicle != null)
            {

            }
        }

        private void UIUpdateData()
        {
            
        }

        private void UIUpdateNewRentalVehicle(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                textRentalManufacturer.Text = vehicle.Manufacturer.Name;
                textRentalModel.Text = vehicle.Model;
                textRentalReg.Text = vehicle.Registration;
            }
        }

        private void UIUpdateMenuItems()
        {
            foreach (var manufacturer in DataLayer.ManufacturersList)
            {
                //add Manufacturers to list
                ToolStripMenuItem menuItemManufacturer = new ToolStripMenuItem($"{manufacturer.Name} model");
                menuItemManufacturer.Click += new EventHandler(ONMenuItem_Click);

                foreach (var model in manufacturer.Models)
                {
                    ToolStripMenuItem menuItemModel = new ToolStripMenuItem(model);
                    menuItemModel.Click += new EventHandler(ONMenuItem_Click);
                    menuItemManufacturer.DropDownItems.Add(menuItemModel);
                }
                newVehicleToolStripMenuItem.DropDownItems.Add(menuItemManufacturer);
            }
        }

        protected void ONMenuItem_Click(object Sender, EventArgs e)
        {
            MessageBox.Show("clicked " + Sender.ToString());
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                updateRentalVehiclesCombo();
            }else if(tabControl1.SelectedIndex == 3)
            {
                UIUpdateRentedList();
            }
        }

        private void UIUpdateRentedTab()
        {
            updateRentalVehiclesCombo();
            comboCustomerID.Text = "";

        }
        private void UIUpdateRentedList()
        {
            dataGridViewRented.Rows.Clear();
            Vehicle[] vehiclesList = DataLayer.Vehicles;

            for (int i = 0; i < vehicleList.Length; i++)
            {
                if (vehicleList[i].isRented())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewRented.Rows[0].Clone();
                    row.Cells[0].Value = vehicleList[i].VehicleID;
                    row.Cells[1].Value = vehicleList[i].Manufacturer.Name;
                    row.Cells[2].Value = vehicleList[i].Model;
                    row.Cells[3].Value = vehicleList[i].Year;
                    row.Cells[4].Value = vehicleList[i].Registration;
                    row.Cells[5].Value = vehicleList[i].FuelEconomy;
                    row.Cells[6].Value = vehicleList[i].DistanceTravelled;
                    row.Cells[7].Value = vehicleList[i].Services;
                    row.Cells[8].Value = vehicleList[i].rentedCustomerID;
                    row.Cells[9].Value = "Show";
                    dataGridViewRented.Rows.Add(row);
                }
            }
        }

        private void updateRentalVehiclesCombo()
        {
            comboRentalVehicleID.Text = "";
            comboRentalVehicleID.Items.Clear();
            Vehicle[] vehicles = DataLayer.Vehicles;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (!vehicles[i].isRented())
                {
                    comboRentalVehicleID.Items.Add($"{vehicles[i].VehicleID}: {vehicles[i].Manufacturer.Name} {vehicles[i].Model} {vehicles[i].Registration}");
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            //parse vehicle ID
            int vID;
            string[] splitVehicleString = comboRentalVehicleID.SelectedItem.ToString().Split(':');
            if(Int32.TryParse(splitVehicleString[0], out vID))
            {
                //get vehicle and set as current
                Vehicle V = DataLayer.GetVehicleByID(vID);
                //update UI to new information
                UIUpdateNewRentalVehicle(V);
            }
            else
            {
                throw new InvalidCastException();
            }


        }

        private void btnRentVehicle_Click(object sender, EventArgs e)
        {
            if (comboCustomerID.Text != "")
            {
                //parse vehicle ID
                int vID;
                string[] splitVehicleString = comboRentalVehicleID.SelectedItem.ToString().Split(':');
                if (Int32.TryParse(splitVehicleString[0], out vID))
                {
                    //get vehicle and set as current
                    Vehicle V = DataLayer.GetVehicleByID(vID);
                    //rent vehicle
                    DataLayer.Vehicles[vID].rentVehicle(Int32.Parse(comboCustomerID.SelectedItem.ToString()));

                }
                else
                {
                    throw new InvalidCastException();
                }
            }
            else
            {
                MessageBox.Show("No customer choosen!");
            }

        }

        private void vehicleRented(object sender, EventArgs e)
        {
            updateRentalVehiclesCombo();
            //cast object to vehicle
            Vehicle v = (Vehicle)sender;
            //display what was rented

            //if (v != null)
            //{
            //    MessageBox.Show($"Rented Vehicle! {v.VehicleID} {v.Registration} {v.Manufacturer.Name} {v.Model}");
            //}
            
        }
    }
}
