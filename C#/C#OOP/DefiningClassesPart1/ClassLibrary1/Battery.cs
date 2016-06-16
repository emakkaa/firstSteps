namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Battery
    {
        private string model;
        private BatteryType type;
        private double hoursIdle;
        private double hoursTalk;

        public Battery()
        {

        }

        public Battery(string Model, BatteryType Type,double HoursIdle,double HoursTalk)
        {
            this.Model = Model;
            this.Type = Type;
            this.HoursIdle = HoursIdle;
            this.HoursTalk = HoursTalk;
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            info.AppendLine($"    1.BatteryInfo");
            info.AppendLine($"Battery Model: {this.model}");
            info.AppendLine($"Battery Type: {this.type}");
            info.AppendLine($"Battery HoursIdle: {this.hoursIdle}");
            info.Append($"Battery hours to talk: {this.hoursTalk} ");
            return info.ToString();
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }

        public double HoursIdle {
            get
            {
                return this.HoursIdle;
            }
            private set
            {
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.HoursTalk;
            }
            private set
            {
                this.hoursTalk = value;
            }
        }
    }
}
