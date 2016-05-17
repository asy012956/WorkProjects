using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Notebook firstNotebook = new Notebook("Fujitsu", "LifeBook AH532", 899);
            Console.WriteLine(firstNotebook.NotebookInformation2());
            Console.WriteLine(firstNotebook.CPU.NumberOfCores);

            var secondNotebook = new Notebook();
            secondNotebook.HddSize = 12;
            secondNotebook.Manufacturer = "Marto";

            secondNotebook.Battery.BatteryCapacity = 12;
        }
    }
}