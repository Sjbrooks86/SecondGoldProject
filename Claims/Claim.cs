using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
/*The Claim has the following properties:
ClaimID
ClaimType
Description
ClaimAmount
DateOfIncident
DateOfClaim
IsValid

Komodo allows an insurance claim to be made up to 30 days after an incident took place. If the claim is not in the proper time limit, it is not valid.

A ClaimType could be the following:
Car
Home
Theft
*/
{
    public enum TypeOfClaim
    {
        Car = 1,
        Home =2,
        Theft =3,
    }
    public class Claim //this one?
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateofIncident { get; set; }
        public DateTime DateofClaim { get; set; }

        //   //  insurance claim to be made up to 30 days after an incident took   place. If the claim is not in the proper time limit, it is not valid.
    public bool IsValid
        {
            get
            {
                TimeSpan timeSpan = DateofClaim - DateofIncident;
                return (Convert.ToInt32(timeSpan.TotalDays) <= 30);

            }
        }

        public Claim() { }

        public Claim(int claimID, string claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateofIncident = dateOfIncident;
            DateofClaim = dateOfClaim;
        }
    }
}
