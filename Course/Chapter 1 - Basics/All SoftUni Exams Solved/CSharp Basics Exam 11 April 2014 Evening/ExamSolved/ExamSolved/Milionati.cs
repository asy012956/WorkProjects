using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved
{
    public class Milionati
    {
        LetterMap[] map = new LetterMap[]
                {
                    new LetterMap() { Letter = 'B', Value = 123 },
                    new LetterMap() { Letter = 'C', Value = 33 },
                    new LetterMap() { Letter = 'D', Value = 545 },
                    new LetterMap() { Letter = 'F', Value = 356 },
                    new LetterMap() { Letter = 'G', Value = 345 },
                    new LetterMap() { Letter = 'H', Value = 188 },
                    new LetterMap() { Letter = 'J', Value = 87 },
                    new LetterMap() { Letter = 'K', Value = 12 },
                    new LetterMap() { Letter = 'L', Value = 998 },
                    new LetterMap() { Letter = 'M', Value = 345 },
                    new LetterMap() { Letter = 'N', Value = 133 },
                    new LetterMap() { Letter = 'P', Value = 165 },
                    new LetterMap() { Letter = 'Q', Value = 76 },
                    new LetterMap() { Letter = 'R', Value = 121 },
                    new LetterMap() { Letter = 'S', Value = 333 },
                    new LetterMap() { Letter = 'T', Value = 909 },
                    new LetterMap() { Letter = 'V', Value = 878 },
                    new LetterMap() { Letter = 'W', Value = 776 },
                    new LetterMap() { Letter = 'X', Value = 665 },
                    new LetterMap() { Letter = 'Y', Value = 545 },
                    new LetterMap() { Letter = 'Z', Value = 333 }
                };

        public IlluminatiAddOn Calculate(string input)
        {
            IlluminatiAddOn result = new IlluminatiAddOn();

            foreach (var character in input)
            {
                if (map.Any(m => m.Letter == character))
                {
                    var mapItem = map.First(m => m.Letter == character);
                    result.NumberOfVowels++;
                    result.SumOfVowels += mapItem.Value;
                }
            }

            return result;
        }
    }

    public class LetterMap
    {
        public int Value { get; set; }
        public char Letter { get; set; }
    }
}
