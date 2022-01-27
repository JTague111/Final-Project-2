using System;

namespace Challenge_2
{
    public class Claims
    {
        public int ClaimID;
        public string ClaimType;
        public string Description;
        public int ClaimAmount;
        public DateTime DateOfIncident;
        public DateTime DateOfClaim;
        public bool IsValid;

        public Claims(int claimID, string claimType, string description, int claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            this.ClaimID = claimID;
            this.ClaimType = claimType;
            this.Description = description;
            this.ClaimAmount = claimAmount;
            this.DateOfIncident = dateOfIncident;
            this.DateOfClaim = dateOfClaim;
            this.IsValid = isValid;
        }

        public Claims()
        {

        }
    }
}
