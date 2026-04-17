using System;

namespace POS_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: LedgerAccount
     *
     * Purpose:
     * Used for API responses of LedgerAccount
     */
    public class LedgerAccountResponse
    {
        public long Id { get; set; }
        public string LedgerName { get; set; }
        public string LedgerCode { get; set; }
        public string GroupName { get; set; }
        public string AccountType { get; set; }
        public decimal OpeningBalance { get; set; }
        public string BalanceType { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
