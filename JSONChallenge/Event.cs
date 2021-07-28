using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
//CHALLENGE 1
{
    public class Event
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public int Capacity { get; set; }
        public decimal PriceOfAdmission { get; set; }
        public Event()
        {

        }
        public Event(DateTime startDate, DateTime endDate, string title, int capacity, decimal priceOfAdmission)
        {
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
            Capacity = capacity;
            PriceOfAdmission = priceOfAdmission;
             
                
        }
    }
}
