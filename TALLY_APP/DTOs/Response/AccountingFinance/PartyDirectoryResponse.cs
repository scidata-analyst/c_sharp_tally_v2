using System;

namespace POS_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: PartyDirectory
     *
     * Purpose:
     * Used for API responses of PartyDirectory
     */
    public class PartyDirectoryResponse
    {
        public long Id { get; set; }
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
