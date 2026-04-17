using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: BankReconciliation
     *
     * Purpose:
     * Used for Create/Update operations of BankReconciliation
     */
    public class BankReconciliationRequest
    {
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
