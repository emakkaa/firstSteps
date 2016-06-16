namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Call
    {
        
        public const decimal PricePerMinute = 0.37M;

        public Call(DateTime Date,string DialledNumber,double Duration)
        {
            this.Date = Date;
            this.DialledNumber = DialledNumber;
            this.Duration = Duration;
        }
        
        public DateTime Date { get; set; }
        public string DialledNumber { get; set; }
        public double Duration { get; set; }

        public override string ToString()
        {
            return string.Format($"Dialed phone {this.DialledNumber} Date: {this.Date} Call duration: {this.Duration}");
        }

    }
}
