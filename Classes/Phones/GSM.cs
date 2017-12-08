using System;
using System.Collections.Generic;

namespace Phones
{
    internal class GSM
    {
        private decimal price;

        static GSM()
        {
            var battery = new Battery("4S battery", BatteryType.LiIon, 100, 20);
            var display = new Display(5, 1000000000);
            IPhone4S = new GSM("4S", "Apple", 1000, "", battery, display);
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S { get; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price
        {
            get => this.price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price shoud be positive number.");
                this.price = value;
            }
        }

        public string Owner { get; set; }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public List<Call> CallHistory { get; set; }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.RemoveAll(c => c == call);
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateCallsPrice(decimal callPrice = 0.37m)
        {
            decimal result = 0;

            foreach (var call in this.CallHistory)
            {
                result += call.Duration * callPrice;
            }

            result = Math.Round(result, 2, MidpointRounding.ToEven);

            return result;
        }

        public override string ToString()
        {
            var result = $@"Model: {this.Model}
Manufacturer: {this.Manufacturer}
Price: {this.Price}
Owner: {this.Owner}
{this.Battery}
{this.Display}";

            return result;
        }
    }
}