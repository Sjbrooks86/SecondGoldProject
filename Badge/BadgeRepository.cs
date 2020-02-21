using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge_Class
/* CRUD
 * CREATE
 * READ
 * DELETE
 * badge repository that will have methods that do the following:
Create a dictionary of badges.
The key for the dictionary will be the BadgeID.
The value for the dictionary will be the List of Door Names.
*/
{
    public class BadgeRepo
    {
        private readonly Dictionary<int, List<string>> _badgeList = new Dictionary<int, List<string>>();
        public bool AddNewBadgeToList(BadgeClass badge)
        {
            int intialCount = _badgeList.Count();
            _badgeList.Add(badge.BadgeID, badge.ListOfDoorName);
            bool wasAdded = intialCount + 1 == _badgeList.Count();
            return wasAdded;
        }
        public Dictionary<int, List<string>> DisplayAllBadges()
        {
            return _badgeList;
        }
        public void Update_AddNewDoor(int badgeID, string newDoor)
        {
            List<string> oldDoor = DisplayAllBadges()[badgeID];
            oldDoor.Add(newDoor);
        }
        //delete door from badge
        public void DeleteAllDoorsFromBadge(int badgeID, string oldDoor)
        {
            List<string> newDoor = DisplayAllBadges()[badgeID];
            newDoor.Add(oldDoor);
        }
    }
}
// add this to ui to add room numbers
// use 07 repoPattern_consoleUI/programUI.cs
/*      Badge.Add("12345", "A7);  
      Badge.Add("22345", "A1, A4, B1, B2");  
      Badge.Add("32345", "A4, A5");  
   */


