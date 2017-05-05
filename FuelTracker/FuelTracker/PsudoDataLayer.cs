using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTracker
{
    class PsudoDataLayer
    {
        public Vehicle[] Vehicles { get; set; }
        public Manufacturer[] ManufacturersList { get; set; }

        public PsudoDataLayer(bool populateData)
        {
            if (populateData)
            {
                initData();
            }
        }
        
        private void initData()
        {

            ManufacturersList = new Manufacturer[8];
            ManufacturersList[0] = new Manufacturer(0, "Audi");
            ManufacturersList[0].Models = new string[2] {"A1", "A4" };
            ManufacturersList[1] = new Manufacturer(1, "BMW");
            ManufacturersList[1].Models = new string[1] {"1 Series"};
            ManufacturersList[2] = new Manufacturer(2, "Porsche");
            ManufacturersList[2].Models = new string[1] { "911 GT" };
            ManufacturersList[3] = new Manufacturer(3, "Volkswagen");
            ManufacturersList[3].Models = new string[2] { "Beetles", "Golf" };
            ManufacturersList[4] = new Manufacturer(4, "Ford");
            ManufacturersList[4].Models = new string[2] { "Anglia", "Escort"};
            ManufacturersList[5] = new Manufacturer(5, "Renault");
            ManufacturersList[5].Models = new string[1] { "Clio" };
            ManufacturersList[6] = new Manufacturer(6, "Crysler");
            ManufacturersList[6].Models = new string[1] { "Windsor" };
            ManufacturersList[7] = new Manufacturer(7, "Mini");
            ManufacturersList[7].Models = new string[1] { "Cooper" };


            Vehicles = new Vehicle[10];
            Vehicles[0] = new Vehicle(0, ManufacturersList[0], ManufacturersList[0].Models[0], "SHE1192", 2012, 10, 201, 2);
            Vehicles[1] = new Vehicle(1, ManufacturersList[0], ManufacturersList[0].Models[1], "YBA4815", 2016, 7, 187, 1);
            Vehicles[2] = new Vehicle(2, ManufacturersList[1], ManufacturersList[1].Models[0], "YXL1745", 2009, 15, 355, 2);
            Vehicles[3] = new Vehicle(3, ManufacturersList[2], ManufacturersList[2].Models[0], "POR0911", 1989, 4, 410, 5);
            Vehicles[4] = new Vehicle(4, ManufacturersList[3], ManufacturersList[3].Models[0], "BEE7130", 1958, 5, 1045, 10);
            Vehicles[5] = new Vehicle(5, ManufacturersList[3], ManufacturersList[3].Models[1], "Gol7000", 2010, 10, 714, 6);
            Vehicles[6] = new Vehicle(6, ManufacturersList[4], ManufacturersList[4].Models[0], "ANGE1959", 1959, 18, 2340, 23);
            Vehicles[7] = new Vehicle(7, ManufacturersList[5], ManufacturersList[5].Models[0], "REN3400", 2011, 14, 534, 5);
            Vehicles[8] = new Vehicle(8, ManufacturersList[6], ManufacturersList[6].Models[0], "WIN1960", 1960, 7, 899, 8);
            Vehicles[9] = new Vehicle(9, ManufacturersList[7], ManufacturersList[7].Models[0], "COP2019", 2017, 22, 40, 0);
        }

        public Vehicle GetVehicleByID(int id)
        {
            Vehicle v = new Vehicle();

            foreach (var vehicle in Vehicles)
            {
                if (vehicle.VehicleID == id)
                {
                    v = vehicle;
                }

            }

            return v;
        }

        public Manufacturer GetManufacturerByName(string name)
        {
            Manufacturer Manu = new Manufacturer();

            for (int i = 0; i < ManufacturersList.Length; i++)
            {
                if (ManufacturersList[i].Name == name)
                {
                    Manu = ManufacturersList[i];
                }

            }
                        
            return Manu;
        }

    }



    class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Models { get; set; }

        public Manufacturer() { }
        public Manufacturer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addToModels(string model)
        {
            //increase models array size
            
            //add to array
        }

        
    }

}
