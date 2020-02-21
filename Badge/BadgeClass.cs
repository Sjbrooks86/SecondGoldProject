using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge_Class
/* badge class that has the following properties:
BadgeID
List of door names for access*/
{
    public class BadgeClass
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoorName { get; set; }
        public BadgeClass() { }
        public BadgeClass(int badgeID, List<string> listOfDoorName)
        {
            BadgeID = badgeID;
            ListOfDoorName = listOfDoorName;
        }
        public override string ToString()
        {
            return $"{BadgeID}";
        }
    }
}
