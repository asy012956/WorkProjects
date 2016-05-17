using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Laptop
    {
        //fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private float screen;
        private decimal price;
        private Battery battery;
        private float batteryLife;

        //properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Model name cannot be empty!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Manufacturer name cannot be empty!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Processor name cannot be empty!");
                }
                this.processor = value;
            }
        }

        public int RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("RAM size cannot be less than zero!");
                }
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Graphics card name cannot be empty!");
                }

                this.graphicsCard = value;
            }
        }

        public int HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Hard drive capacity cannot be negative!");
                }
                this.hdd = value;
            }
        }

        public float Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Screen size cannot be negative!");
                }
                this.screen = value;
            }
        }

        //public string Battery
        //{
        //    get
        //    {
        //        return this.battery;
        //    }
        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException("Battery type cannot be empty");
        //        }
        //        this.battery = value;
        //    }
        //}

        public float BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Battery life cannot be a negative number!");
                }
                this.batteryLife = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be a negative number!");
                }
                this.price = value;
            }
        }

        //constructors
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, decimal price, Battery battery)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.battery = battery;
        }

        public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard,
            int hdd, float screen, Battery battery, float batteryLife, decimal price)
                : this(model, manufacturer, price, battery)
        {
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.BatteryLife = batteryLife;
        }

        public Laptop(string model, string manufacturer, string processor, int ram = 0, string graphicsCard = null,
            int hdd = 0, float screen = 0.0f, decimal price = 0.00m, Battery battery = null, float batteryLife = 0.0f)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Price = price;
            this.battery = battery;
            this.BatteryLife = batteryLife;
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Model: {0}, Manufacturer: {1}, Processor: {2}, RAM: {3}, Price: {4}", 
                this.model, this.manufacturer, this.processor, this.ram, this.price);
        }
    }

    public class Battery
    {
        //fields
        private string batteryType;
        private float batteryLife;

        //properties
        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Battery type cannot be empty");
                }
                this.batteryType = value;
            }
        }

        public float BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Battery life cannot be a negative number!");
                }
                this.batteryLife = value;
            }
        }

        //constructors
        public Battery(string batteryType, float batteryLife)
        {
            this.BatteryType = batteryType;
            this.batteryLife = batteryLife;
        }
    }
}

