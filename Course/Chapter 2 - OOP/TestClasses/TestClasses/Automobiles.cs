using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Automobiles
    {
        //fields
        private string brand;
        private string model;
        private ushort year;
        private float engineSize;
        private float fuelConsumption;

        //properties
        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                this.brand = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public ushort Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }
        }
        
        public float EngineSize
        {
            get
            {
                return this.EngineSize;
            }

            set
            {
                this.engineSize = value;
            }
        } 

        public float FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                this.fuelConsumption = value;
            }
        }

        //default constructor
        public Automobiles()
        {
            this.brand = "Opel";
            this.model = "Astra";
            this.year = 2001;
            this.engineSize = 1.6f;
            this.fuelConsumption = 6.5f;
        }

        //constructor with parameters
        public Automobiles(string brand, string model, ushort year, float engineSize, float fuelConsumption)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.engineSize = engineSize;
            this.fuelConsumption = fuelConsumption;
        }

        //methods
        public void MyCar()
        {
            Console.WriteLine("My car is {0} {1}, it was made in {2} with an engine size of {3} liters and needs {4} liters of gasoline per 100 km.", brand, model, year, engineSize, fuelConsumption);
        }
    }
}
