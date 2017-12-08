using System;

namespace Phones
{
    internal class Battery
    {
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType batteryType)
            : this(model)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, BatteryType batteryType, int hoursIdle, int hoursTalk)
            : this(model, batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model { get; set; }

        public int HoursIdle
        {
            get => this.hoursIdle;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Battery hours idle shoud be positive number.");
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get => this.hoursTalk;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Battery hours talk shoud be positive number.");
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            var result = $@"Battery:
         Model: {this.Model}
         Battery type: {this.BatteryType}
         Hours idle: {this.HoursIdle}
         Hours talk: {this.HoursTalk}";

            return result;
        }
    }
}