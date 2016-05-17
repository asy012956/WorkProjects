using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyRepairs
{
    class EmergencyRepairs
    {
        static void Main(string[] args)
        {
            //entry data
            ulong wall = ulong.Parse(Console.ReadLine());
            byte emergencyRepairKits = byte.Parse(Console.ReadLine()); //3
            byte numberOfAttacks = byte.Parse(Console.ReadLine());

            //break the wall
            for (int i = 0; i < numberOfAttacks; i++)
            {
                byte attackedBit = byte.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << attackedBit);
            }

            //Console.WriteLine(wall>>1);

            //fixing the wall
            for (int i = 1; i <= 64; i++)
            {
                ulong bitTested = (wall >> i) & 1;

                if (bitTested == 0 && emergencyRepairKits > 0)
                {
                    bool foundHole = false;
                    while (emergencyRepairKits > 0 && i + 1 < 65 && ((wall >> (i + 1) & 1) == 0))
                    {
                        wall = wall | ((ulong)1 << i);
                        i++;
                        emergencyRepairKits--;
                        foundHole = true;
                    }

                    if (foundHole && emergencyRepairKits > 0)
                    {
                        wall = wall | ((ulong)1 << i);
                        emergencyRepairKits--;
                    }

                }
            }

            //final output
            Console.WriteLine(wall);
        }
    }
}

