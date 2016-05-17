using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses2
{
    public class Notebook
    {
        public const int HOURS_IN_TRAINING = 500;

        private byte ramSize;
        public byte RamSize
        {
            get
            {
                return this.ramSize;
            }
            set
            {
                if (value >= 4)
                {
                    if (this.CPU.ArchitectureBit < 64)
                    {
                        this.ramSize = 3;
                    }
                    else
                    {
                        this.ramSize = value;
                    }
                }
            }
        }

        //Properties
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public CPU CPU { get; set; }
        public ushort HddSize { get; set; }
        public Display Display { get; set; }
        public Battery Battery { get; set; }
        public ushort Price { get; set; }

        //Constructors
        public Notebook()
        {
            this.CPU = new CPU();
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public Notebook(string manufacturer, string model, CPU CPU, byte RamSize, ushort HddSize, Display Display, Battery Battery, ushort Price)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.CPU = CPU;
            this.RamSize = RamSize;
            this.HddSize = HddSize;
            this.Display = Display;
            this.Battery = Battery;
            this.Price = Price;
        }

        public Notebook(string Manufacturer, string Model, ushort Price)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Price = Price;
        }

        //Methods
        /// <summary>
        ///     Returns all properties in a string separated by an empty space
        /// </summary>
        public string Stringify()
        {
            string information = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.Manufacturer, this.Model, this.CPU, this.RamSize,
            this.HddSize, this.Display, this.Battery, this.Price);
            return information;
        }

        public string NotebookInformation2()
        {
            string information = string.Format("{0} {1} {2}", this.Manufacturer, this.Model, this.Price);
            return information;
        }
    }

    public class CPU
    {
        //fields
        //private string cpuManufacturer;
        //private byte numberOfCores;
        //private ushort clockSpeed;

        //properties
        public string CpuManufacturer { get; set; }
        public byte NumberOfCores { get; set; }
        public ushort ClockSpeed { get; set; }
        public uint ArchitectureBit { get; set; }

        //constructors
        public CPU()
        {
            this.ArchitectureBit = 32;
        }

        public CPU(string CpuManufacturer, byte NumberOfCores, ushort ClockSpeed)
            : this()
        {
            this.CpuManufacturer = CpuManufacturer;
            this.NumberOfCores = NumberOfCores;
            this.ClockSpeed = ClockSpeed;
        }
    }

    public class Display
    {
        public enum DisplayType { IPS, LCD, LED, TN };

        //fields 
        //private byte displaySize;
        //private uint numberOfColors;
        //private string technologyUsed;

        //properties
        public byte DisplaySize { get; set; }
        public uint NumberOfColors { get; set; }
        public ushort TechnologyUsed { get; set; }

        //constructors
        public Display()
        {

        }

        public Display(byte DisplaySize, uint NumberOfColors, ushort TechnologyUsed)
        {
            this.DisplaySize = DisplaySize;
            this.NumberOfColors = NumberOfColors;
            this.TechnologyUsed = TechnologyUsed;
        }
    }

    public class Battery
    {
        public enum BatteryType { LiIon, NiMH };

        //fields
        //private ushort batteryCapacity;
        //private float batteryLifeHours;
        //private string batteryManufacturer;

        //properties
        public ushort BatteryCapacity { get; set; }
        public float BatteryLifeHours { get; set; }
        public string BatteryManufacturer { get; set; }

        //constructors
        public Battery()
        {

        }

        public Battery(ushort BatteryCapacity, float BatteryLifeHours, string BatteryManufacturer)
        {
            this.BatteryCapacity = BatteryCapacity;
            this.BatteryLifeHours = BatteryLifeHours;
            this.BatteryManufacturer = BatteryManufacturer;
        }
    }
}
