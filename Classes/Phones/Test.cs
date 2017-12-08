using System;
using System.Linq;

namespace Phones
{
    class Test
    {
        static void Main()
        {
            Battery b = new Battery("ch23", BatteryType.LiIon);
            Display d = new Display(5);

            Console.WriteLine(GSM.IPhone4S);

            GSM g = new GSM("s9", "apple", 1, "pesho", b, d);

            Console.WriteLine(GSM.IPhone4S.Model);

            Call testCall = new Call("535324", DateTime.Now, 4);
            g.CallHistory.Add(new Call("0881213", DateTime.Now, 10));
            g.CallHistory.Add(testCall);
            g.CallHistory.Add(new Call("0881234324213", DateTime.Now, 3));

            var bill = Call.CalculateCallsPrice(g.CallHistory);
            Console.WriteLine(bill);

            var bill2 = g.CalculateCallsPrice();
            Console.WriteLine(bill2);

            
        }
    }
}