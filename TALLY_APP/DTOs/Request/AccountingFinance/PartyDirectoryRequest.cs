using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: PartyDirectory
     *
     * Purpose:
     * Used for Create/Update operations of PartyDirectory
     */
    public class PartyDirectoryRequest
    {
        public string PartyName { get; set; }
        public string PartyType { get; set; }
        public string Gstin { get; set; }
        public string PanNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditPeriod { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
