namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        private double size;
        private ulong numberOfColours;

        Display()
        {

        }

        public Display(double Size,ulong NumberOfColours)
        {
            this.Size = Size;
            this.NumberOfColours = NumberOfColours;
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendLine("    2.Display info<---");
            info.AppendLine(string.Format($"Size: {this.Size}"));
            info.Append(string.Format($"Number of colors: {this.NumberOfColours}"));

            return info.ToString();
        }

        public double Size {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }
        public ulong NumberOfColours {
            get
            {
                return this.numberOfColours;
            }
            private set
            {
                this.numberOfColours = value;
            }
        }
    }
}
