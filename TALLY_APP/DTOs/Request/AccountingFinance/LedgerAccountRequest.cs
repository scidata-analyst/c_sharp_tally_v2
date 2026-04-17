using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: LedgerAccount
     *
     * Purpose:
     * Used for Create/Update operations of LedgerAccount
     */
    public class LedgerAccountRequest
    {
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
