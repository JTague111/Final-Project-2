using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimsRepository
    {
        private List<Claims> _listOfClaims = new List<Claims>();
        public List<Claims> ListOfClaims { get; set; }

        //Create
        public void AddClaim(Claims claim)
        {
            _listOfClaims.Add(claim);
        }

        //Read
        public List<Claims> GetClaims()
        {
            return _listOfClaims;
        }
        //Update
        public void UpdateExistingClaim(int originalClaimID, Claims newclaim)
        {
            //Find the content
            Claims oldclaim = GetClaimByClaimID(originalClaimID);

            //Update the content
            if (oldclaim != null)
            {
                //A
                oldclaim.ClaimID = newclaim.ClaimID;
                //B
                oldclaim.ClaimType = newclaim.ClaimType;
                //C
                oldclaim.Description = newclaim.Description;
                //D
                oldclaim.ClaimAmount= newclaim.ClaimAmount;
                //E
                oldclaim.DateOfIncident = newclaim.DateOfIncident;
                //F
                oldclaim.DateOfClaim = newclaim.DateOfClaim;
                //G
                oldclaim.DateOfClaim = newclaim.DateOfClaim;
            }
        }

        //Delete
        public bool RemoveClaimfromList(int claimID)
        {
            Claims claim = GetClaimByClaimID(claimID);

            if (claim == null)
            {
                return false;
            }

            int initialCount = _listOfClaims.Count;
            _listOfClaims.Remove(claim);

            if (initialCount > _listOfClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper method
        public Claims GetClaimByClaimID(int claimID)
        {
            foreach (Claims claim in _listOfClaims)
            {
                if (claim.ClaimID == claimID)
                {
                    return claim;
                }
            }

            return null;
        }
    }
}
