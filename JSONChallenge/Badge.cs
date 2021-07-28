using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
//CHALLENGE #2
{

    public class Badge
    {
        public int Id { get; set; }
        public List<string> ListOfDoors { get; set; }
        public bool HasSecurityClearance { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Badge()
        {

        }
        public Badge(int id, List<string> listOfDoors, bool hasSecurityClearance, string employeeId, DateTime createdOn)
        {
            Id = id;
            ListOfDoors = listOfDoors;
            HasSecurityClearance = hasSecurityClearance;
            CreatedOn = createdOn; 

        }
    }
}
