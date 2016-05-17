using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsGraduation
{
    public class Women
    {
        private DateTime graduationDate;

        public DateTime GraduationDate
        {
            get
            {
                return this.graduationDate;
            }
            set
            {
                this.graduationDate = value;
            }
        }

        public string GraduationDateString
        {
            get
            {
                return this.graduationDate.ToString("dd-MM-yyyy");
            }
            set
            {
                this.graduationDate = DateTime.Parse(value);
            }
        }

        public int Something { get; set; }


        private int age;
        private bool isAlive;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;

                if (age > 100)
                {
                    this.isAlive = false;
                }
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
        }



        public Women()
        {
            this.isAlive = true;
        }
    }
}
