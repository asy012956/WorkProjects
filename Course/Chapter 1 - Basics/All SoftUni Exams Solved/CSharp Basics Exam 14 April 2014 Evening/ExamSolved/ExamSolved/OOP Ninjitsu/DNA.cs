using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolved.OOP_Ninjitsu
{
    public class DNA
    {
        private int dotsIndex;
        private char seed;
        private int strainSize;
        private int direction = -1;

        public DNA(char seed, int strainSize)
        {
            this.seed = seed;
            this.strainSize = strainSize;
            this.dotsIndex = strainSize / 2;
        }

        public string GetDNASequence(int sequenceLength)
        {
            StringBuilder builder = new StringBuilder();

            for(int i = 0; i < sequenceLength; i++)
            {
                builder.AppendLine(NextRow());
            }

            return builder.ToString();
        }

        private string NextRow()
        {
            StringBuilder builder = new StringBuilder();

            int dotsCount = GetDotsCount();
            string dots = new string('.', dotsCount);
            builder.Append(dots);

            for (int i = 0; i < strainSize - (2 * dotsCount); i++)
            {
                builder.Append(GetNextStrain());
            }

            builder.Append(dots);

            return builder.ToString();
        }

        private char GetNextStrain()
        {
            char result = this.seed;
            this.seed++;

            if (this.seed > 'G')
            {
                this.seed = 'A';
            }

            return result;
        }

        private int GetDotsCount()
        {
            int result = Math.Abs(this.dotsIndex);
            this.dotsIndex += direction;

            if (Math.Abs(this.dotsIndex) == strainSize / 2 + 1)
            {
                this.direction = -1 * direction;
                this.dotsIndex += direction;
            }

            return result;
        }
    }
}
