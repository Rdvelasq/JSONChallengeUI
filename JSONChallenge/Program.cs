using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate= new DateTime(2021,7,30);
            DateTime endDate = new DateTime(2021, 8, 1);
            Event _event = new Event(startDate, endDate, "Gen Con", 1000, 25.0m);
            string readEvent = JsonConvert.SerializeObject(_event);

            List<string> ListOfDoors = new List<string> { "A2", "B6'" };
            Badge badge = new Badge(12345, ListOfDoors, true, "FERPOVJER4545", DateTime.Now);
            string readBadge = JsonConvert.SerializeObject(badge);

            Console.WriteLine(readBadge);
            Console.WriteLine(readEvent);
            Console.ReadLine();
        }
    }
}
