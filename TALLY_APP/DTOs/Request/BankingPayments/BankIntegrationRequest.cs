using System;

namespace POS_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: BankIntegration
     *
     * Purpose:
     * Used for Create/Update operations of BankIntegration
     */
    public class BankIntegrationRequest
    {
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
