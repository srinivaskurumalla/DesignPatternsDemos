using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemos.SingletonDemo
{
    class Program
    {
        static CabService Customer1cabService = CabService.GetDriver(); // new CabService();
        static CabService Customer2cabService = CabService.GetDriver(); //new CabService();
        public static void Customer1NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 1 :{Customer1cabService.GetNextAvailableDriver()}");
        }

        public static void Customer2NextDriver()
        {
            Console.WriteLine($"Next Available Driver for Customer 2 :{Customer2cabService.GetNextAvailableDriver()}");
        }

        static void Main(string[] args)
        {

            CabService cabService = CabService.GetDriver();
            //Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");

            for (int i = 0; i < 4; i++)
            {
                // Console.WriteLine($"Next Available Driver :{cabService.GetNextAvailableDriver()}");
                Customer1NextDriver();
                Customer2NextDriver();
            }
        }
    }

}
