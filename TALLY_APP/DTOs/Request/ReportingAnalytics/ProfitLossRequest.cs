using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: ProfitLoss
     *
     * Purpose:
     * Used for Create/Update operations of ProfitLoss
     */
    public class ProfitLossRequest
    {
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
