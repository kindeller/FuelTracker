using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTracker
{
    public delegate void OnVehicleRented_EventHandler(object sender, EventArgs e);

    class Vehicle
    {
        public event OnVehicleRented_EventHandler Rented;
        public int VehicleID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Registration { get; set; }
        public int FuelEconomy { get; set; }
        public int DistanceTravelled { get; set; }
        public int fuelPurchased { get; set; }
        public double averageCost { get; set; }
        public int Services { get; set; }
        public int TimesRented { get; set; }
        private bool rented = false;
        public int rentedCustomerID { get; set; }

        protected virtual void OnRented(EventArgs e)
        {
            Rented?.Invoke(this, e);
        }

        public Vehicle() { }
        public Vehicle(int vehicleID, Manufacturer manufacturer, string model, string registration, int year, int fuelEconomy, int distance, int services)
        {
            VehicleID = vehicleID;
            Manufacturer = manufacturer;
            Model = model;
            Registration = registration;
            Year = year;
            FuelEconomy = fuelEconomy;
            DistanceTravelled = distance;
            Services = services;

        }

        public bool isRented()
        {
            return rented;
        }

        public void rentVehicle(int customerID)
        {
            rentedCustomerID = customerID;
            rented = true;
            OnRented(EventArgs.Empty);

        }

        public void returnVehicle()
        {
            rented = false;
            TimesRented++;
            OnRented(EventArgs.Empty);
        }



        



        public void newJourney(Journey j, FuelPurchase[] purchases)
        {
            //if valid
            
            //update record of car to show new data
            updateDistanceTravelled(j.distanceTravelled);
            returnVehicle();
        }


        private void updateDistanceTravelled(int distance)
        {

            DistanceTravelled += distance;
        }

        private void updateFuelCosts(FuelPurchase purchase)
        {
            double averageCostsPerRenta = 0;

        }
    }
}
