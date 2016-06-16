namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using MobilePhone;

    public class GsmTestClass
    {
        public static void Main(string[] args)
        {
            GSMTEST();
            CallTest();
        }

        public static void GSMTEST()
        {
            Console.WriteLine("--------->GSM TEST<---------");
            Console.WriteLine();

            var lion = new Battery("Lion", BatteryType.LiIon, 10, 10);
            var gorilla = new Display(5, 600000);

            var samsung = new GSM("galaxy s5","samsung",400,"Emakkaa",lion,gorilla);
            var htc = new GSM("Desire 820", "htc", 700, "Emakkaa", lion, gorilla);
            var sony = new GSM("Xperia Aqua", "sony", 1500, "Emakkaa", lion, gorilla);

            var gsmList = new List<GSM> {samsung,htc,sony };

            foreach (var gsm  in gsmList)
            {
                Console.WriteLine(gsm.ToString());
            }

        }

        public static void CallTest()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var lion = new Battery("Lion", BatteryType.LiIon, 10, 10);
            var gorilla = new Display(5, 600000);

            var samsung = new GSM("galaxy s5", "samsung", 400, "Emakkaa", lion, gorilla);

            var call1 = new Call(DateTime.Now, "0895 000 000", 1290);
            var call2 = new Call(new DateTime(2016, 12, 12), "0895 000 000", 20);
            var call3 = new Call(new DateTime(2016, 02, 12), "0895 000 000", 433);


            samsung.AddCall(call1);
            samsung.AddCall(call2);
            samsung.AddCall(call3);


            List<Call> listOfCalls = samsung.CallList;

            
            Console.WriteLine(string.Join(Environment.NewLine, listOfCalls));

            
            double price = samsung.TotalPriceOfCalls();
            Console.WriteLine(price);
            Console.WriteLine();

            //remove longest call
            samsung.DeleteCall(samsung.CallList.OrderByDescending(c => c.Duration).First());
            Console.WriteLine(string.Join(Environment.NewLine, samsung.CallList));

            double priceWhenLongestCallIsRemoved = samsung.TotalPriceOfCalls();
            Console.WriteLine(priceWhenLongestCallIsRemoved);

            
            samsung.ClearCallHistory();
            Console.WriteLine("History has been cleared!!!");
        }
    }
}
