using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemos.SingletonDemo
{
    public class CabService
    {
        private List<string> cabDrivers = new List<string>();
        private int count = 0;

        private CabService()
        {
            cabDrivers.AddRange(new string[] { "Rajini", "Kamal", "Vijay", "Ajith" });
        }

        private static CabService cabService = new CabService();
        public static CabService GetDriver()
        {
            return cabService;
        }

        public string GetNextAvailableDriver()
        {
            string result = cabDrivers[count];
            count++;
            if (count >= cabDrivers.Count)
            {
                count = 0;
            }
            return result;
        }
    }

}