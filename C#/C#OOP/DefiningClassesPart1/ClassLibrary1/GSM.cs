namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class GSM
    {
        public static GSM iPhone4S;


        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callList;
        
        

        public GSM(string Model, string Manufacturer, double Price, string Owner, Battery Battery, Display Display)
        {
            this.Model = Model;
            this.Manufacturer = Manufacturer;
            this.Price = Price;
            this.Owner = Owner;
            this.Battery = Battery;
            this.Display = Display;
        }

        static GSM()
        {
            iPhone4S = new GSM(
                "Iphone 4s",
                "Apple",
                9999999999,
                "Pesho",
                new Battery("AppleBat", BatteryType.LiIon, 10, 10),
                new Display(6, 2));
        }

        public string CallHistory()
        {
            var callHistory = new StringBuilder();

            foreach (var call in this.CallList)
            {
                callHistory.AppendLine(call.ToString());
            }
            return callHistory.ToString();
        }

        public void AddCall(Call call)
        {
            this.CallList.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallList.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallList.Clear();
        }

        public double TotalPriceOfCalls()
        {
            double result = 0;
            foreach (var call in this.CallList)
            {
                result += (call.Duration / 60) * (double)Call.PricePerMinute;
            }
            return result;
        }



        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("--->GSM info<---");
            result.AppendLine(string.Format($"Model: {this.Model}"));
            result.AppendLine(string.Format($"Manufacturer: {this.Manufacturer}"));
            result.AppendLine(string.Format($"Price: {this.Price}"));
            result.AppendLine(this.Battery.ToString());
            result.AppendLine(this.Display.ToString());

            return result.ToString();
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
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Call> CallList
        {
            get
            {
                if(this.callList== null)
                {
                    this.callList = new List<Call>();
                }
                return callList;
            }

            private set
            {
                this.callList = value;
            }
        }
    }
}
