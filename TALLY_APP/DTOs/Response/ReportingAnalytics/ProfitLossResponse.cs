using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: ProfitLoss
     *
     * Purpose:
     * Used for API responses of ProfitLoss
     */
    public class ProfitLossResponse
    {
        public long Id { get; set; }
        public string Period { get; set; }
        public decimal SalesRevenue { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal GrossIncome { get; set; }
        public decimal CostOfGoodsSold { get; set; }
        public decimal EmployeeCosts { get; set; }
        public decimal AdminOverheads { get; set; }
        public decimal NetProfit { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
