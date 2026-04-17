using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: TrialBalance
     *
     * Purpose:
     * Used for Create/Update operations of TrialBalance
     */
    public class TrialBalanceRequest
    {
        public string AccountName { get; set; }
        public string GroupName { get; set; }
        public decimal OpeningDr { get; set; }
        public decimal OpeningCr { get; set; }
        public decimal TransactionDr { get; set; }
        public decimal TransactionCr { get; set; }
        public decimal ClosingDr { get; set; }
        public decimal ClosingCr { get; set; }
        public string Period { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
