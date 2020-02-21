using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
{
    //  CRUD
    //  Create
    //  Read
    //  Delete

    //  Show a claims agent a menu:
    //  Choose a menu item:
    
       
    public class ClaimRepository
    {
        //  1. See all claims
        public Queue<Claim> claimQueue = new Queue<Claim>();
        
        private bool matchFound;

        public Queue<Claim> GetListfAllclaims()
        {
            return claimQueue;
        }

        //  2. Take care of next claim
        public void AddNewClaimtoQueue(Claim newClaim)
        {
            claimQueue.Enqueue(newClaim);
        }

        //  3. Enter a new claim
        public Claim GetClaimbyClaimID(int claimID)

        {
            foreach (Claim ClaimID in claimQueue)
            {
                if (ClaimID.ClaimID == claimID)
                {
                    return ClaimID;
                }
            }
            return null;
        }
        public void DeleteExistingClaim()
        {
            claimQueue.Dequeue();

        }
    }
}
/*
 * public bool RemoveMealItem(int existingMeal)
        {
            Menu removeMeal = GetMealbyMealNumber(existingMeal);
            bool deletedResult = _menu.Remove(removeMeal);
            return deletedResult;
        }
*/