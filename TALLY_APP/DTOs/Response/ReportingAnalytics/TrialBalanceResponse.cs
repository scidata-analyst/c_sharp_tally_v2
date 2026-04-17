using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: TrialBalance
     *
     * Purpose:
     * Used for API responses of TrialBalance
     */
    public class TrialBalanceResponse
    {
        public long Id { get; set; }
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
