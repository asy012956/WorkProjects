using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uprajnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog unnamed = new Dog();
            Dog Sharo = new Dog("Sharo", "Melez");
            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            Sharo.Bark();
        }
    }
}
