using System;

namespace Phones
{
    internal class Display
    {
        private int numberOfColors;
        private decimal size;

        public Display(decimal size)
        {
            this.Size = size;
        }

        public Display(decimal size, int numberOfColors)
            : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }

        public decimal Size
        {
            get => this.size;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Display size shoud be positive number.");
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get => this.numberOfColors;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Display colors shoud be positive number.");
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var result = $@"Display:
         Size: {this.Size}
         Number of colors: {this.NumberOfColors}";

            return result;
        }
    }
}