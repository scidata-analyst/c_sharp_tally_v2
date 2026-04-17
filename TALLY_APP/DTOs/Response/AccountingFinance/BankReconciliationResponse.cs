using System;

namespace POS_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: BankReconciliation
     *
     * Purpose:
     * Used for API responses of BankReconciliation
     */
    public class BankReconciliationResponse
    {
        public long Id { get; set; }
        public long BankAccountId { get; set; }
        public DateTime StatementDate { get; set; }
        public decimal BankBalance { get; set; }
        public decimal BookBalance { get; set; }
        public decimal UnreconciledAmount { get; set; }
        public int PendingItems { get; set; }
        public string Status { get; set; }
        public DateTime ReconciledAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
