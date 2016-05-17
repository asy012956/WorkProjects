using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExercises
{
    public class Call
    {
        //fields
        private DateTime dateAndTime;
        private string dialledPhoneNumber;
        private uint durationInSeconds;

        //properties
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }

            set
            {
                this.dateAndTime = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }

            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public uint DurationInSeconds
        {
            get
            {
                return this.durationInSeconds;
            }

            set
            {
                this.durationInSeconds = value;
            }
        }

        //constructors
        public Call (DateTime dateAndTime, string dialledPhoneNumber, uint durationInSeconds)
        {
            this.dateAndTime = dateAndTime;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.durationInSeconds = durationInSeconds;
        }
    }
}
