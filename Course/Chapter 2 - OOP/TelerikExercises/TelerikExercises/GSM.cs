using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikExercises
{
    public class GSM
    {
        //fields
        public static GSM iPhone4S;
        private List<Call> callHistory;

        //properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public GSM IPhone4S { get; set; }

        static GSM()
        {
            Battery battery = new Battery("AB-110", 189, 36);
            Display display = new Display(5.5f, 65536);
            iPhone4S = new GSM("IPhone 4S", "Apple", 1599f, "Ivan Ivanov", battery, display);
        }

        public GSM()
        {
            this.Battery = new Battery();
            this.Display = new Display();
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, float price, string owner,
            string batteryModel, float batteryHoursIdle, float batteryHoursTalk, float displaySize, uint displayColors)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = new Battery(batteryModel, batteryHoursIdle, batteryHoursTalk);
            this.Display = new Display(displaySize, displayColors);
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, float price, string owner,
            Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }

        //Methods
        public override string ToString()
        {
            string result = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", this.Model, this.Manufacturer,
            this.Price, this.Owner, this.Battery.Model, this.Battery.HoursIdle, this.Battery.HoursTalk,
            this.Display.Size, this.Display.Colors);

            return result;
        }

        public void AddCalls(DateTime dateAndTime, string dialledPhoneNumber, uint durationInSeconds)
        {
            Call newCall = new Call(dateAndTime, dialledPhoneNumber, durationInSeconds);
            callHistory.Add(newCall);
        }

        public void DeleteCalls(uint duration)
        {
            //for (int i = 0; i < callHistory.Count; i++)
            //{
            //    if (callHistory[i].DurationInSeconds == duration)
            //    {
            //        callHistory.RemoveAt(i);
            //    }
            //}

            callHistory.RemoveAll(c => c.DurationInSeconds == duration);
        }

        public void RemoveHistory()
        {
            callHistory.Clear();
        }

        public double CalculateCallPrice(double pricePerMinute)
        {
            //double totalPrice = 0;
            //uint totalTimeInSeconds = 0;
            //double totalMinutes = 0;
            //for (int i = 0; i < callHistory.Count; i++)
            //{
            //    totalTimeInSeconds = totalTimeInSeconds + callHistory[i].DurationInSeconds;
            //}

            //totalMinutes = totalTimeInSeconds / 60d;
            //totalPrice = totalMinutes * pricePerMinute;

            //return totalPrice;

            //long totalTimeInSeconds = callHistory.Sum(c => c.DurationInSeconds);
            //double totalPrice = Math.Round(((totalTimeInSeconds / 60d) * pricePerMinute),2);
            //return totalPrice;

            var result = callHistory.Sum(c => (c.DurationInSeconds / 60d) * pricePerMinute);
            result = Math.Round(result, 2);
            return result;
        }

        public void PrintCalls()
        {
            Console.WriteLine();
            for (int i = 0; i < callHistory.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", (callHistory[i].DateAndTime).ToString(), callHistory[i].DialledPhoneNumber, callHistory[i].DurationInSeconds);
            }
            Console.WriteLine();
        }

        public void RemoveLongestCall()
        {
            //uint longestCallDuration = 0;
            //uint currentCallDuration = 0;
            //uint index = 0;
            //for (int i = 0; i < callHistory.Count; i++)
            //{
            //    currentCallDuration = callHistory[i].DurationInSeconds;
            //    if (currentCallDuration > longestCallDuration)
            //    {
            //        longestCallDuration = currentCallDuration;
            //        index = (uint)i;
            //    }
            //}

            //callHistory.RemoveAt((int)index);

            var result = callHistory.Max(c => c.DurationInSeconds);
            var call = callHistory.First(c => c.DurationInSeconds == callHistory.Max(c1 => c1.DurationInSeconds));
            callHistory.Remove(call);
        }
    }

    public class Battery
    {
        public enum BatteryType { LiIon, NiMH, NiCd };

        //field

        public string Model { get; set; }
        public float HoursIdle { get; set; }
        public float HoursTalk { get; set; }
        public BatteryType Type { get; set; }

        public Battery()
        {
            this.Type = BatteryType.NiCd;
        }

        public Battery(string batteryModel, float batteryHoursIdle, float batteryHoursTalk)
            : this()
        {
            this.Model = batteryModel;
            this.HoursIdle = batteryHoursIdle;
            this.HoursTalk = batteryHoursTalk;
        }
    }

    public class Display
    {
        public float Size { get; set; }
        public uint Colors { get; set; }

        public Display()
        {

        }

        public Display(float displaySize, uint displayColors)
        {
            this.Size = displaySize;
            this.Colors = displayColors;
        }
    }
}