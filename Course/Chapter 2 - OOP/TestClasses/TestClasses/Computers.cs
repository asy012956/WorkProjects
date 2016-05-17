using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Computers
    {
        //fields
        private string cpuType;
        private byte ramSize;
        private ushort hardDriveSize;
        private string psuOutput;
        private string osUsed;

        //properties
        public string CpuType
        {
            get
            {
                return this.cpuType;
            }

            set
            {
                this.cpuType = value;
            }
        }

        public byte RamSize
        {
            get
            {
                return this.ramSize;
            }

            set
            {
                this.ramSize = value;
            }
        }

        public ushort HardDriveSize
        {
            get
            {
                return this.hardDriveSize;
            }

            set
            {
                this.hardDriveSize = value;
            }
        }

        public string PsuOutput
        {
            get
            {
                return this.psuOutput;
            }

            set
            {
                this.psuOutput = value;
            }
        }

        public string OsUsed
        {
            get
            {
                return this.osUsed;
            }

            set
            {
                this.osUsed = value;
            }
        }

        //default constructor
        public Computers()
        {
            this.cpuType = "Intel Core i3-2100";
            this.ramSize = 8;
            this.hardDriveSize = 500;
            this.psuOutput = "500 W";
            this.osUsed = "Windows 7 Professional";
        }

        //constructor with parameters
        public Computers(string cpuType, byte ramSize, ushort hardDriveSize, string psuOutput, string osUsed)
        {
            this.cpuType = cpuType;
            this.ramSize = ramSize;
            this.hardDriveSize = hardDriveSize;
            this.psuOutput = psuOutput;
            this.osUsed = osUsed;
        }

        //methods
        public void MyComputer()
        {
            Console.WriteLine("My computer has a {0} processor with {1} GB RAM, a {2} GB hard drive, {3} PSU and uses {4}.", cpuType, ramSize, hardDriveSize, psuOutput, osUsed);
        }

        public void MyComputer(string cpuType, byte ramSize, ushort hardDriveSize, string psuOutput, string osUsed)
        {
            Console.WriteLine("My computer has an {0} processor with {1} GB RAM, a {2} GB hard drive, {3} PSU and uses {4}.", cpuType, ramSize, hardDriveSize, psuOutput, osUsed);
        }
    }
}
