using System;
using System.Collections.Generic;

namespace Phones
{
    public class Call
    {
        private int duration;

        public Call(string number, DateTime time, int duration)
        {
            this.Number = number;
            this.Time = time;
            this.duration = duration;
        }

        public DateTime Time { get; set; }

        private DateTime time2;

        public DateTime Time2
        {
            get { return this.time2; }
            set { this.time2 = value; }
        }


        public string Number { get; set; }

        public int Duration
        {
            get => this.duration;
            set
            {
                if (value < 0)
                    throw new Exception();
                this.duration = value;
            }
        }

        public static decimal CalculateCallsPrice(List<Call> calls, decimal price = 0.37m)
        {
            decimal result = 0;

            foreach (var call in calls)
            {
                result += call.Duration * price;
            }

            result = Math.Round(result, 2, MidpointRounding.ToEven);

            return result;
        }

        public override string ToString()
        {
            return $"Number: {this.Number}; Minutes: {this.Duration}; Date: {this.Time}";
        }
    }
}