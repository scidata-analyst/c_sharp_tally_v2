using System;

namespace POS_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: BankIntegration
     *
     * Purpose:
     * Used for API responses of BankIntegration
     */
    public class BankIntegrationResponse
    {
        public long Id { get; set; }
        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public DateTime LastSync { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
