using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: CashFlowStatement
     *
     * Purpose:
     * Used for API responses of CashFlowStatement
     */
    public class CashFlowStatementResponse
    {
        public long Id { get; set; }
        public string Period { get; set; }
        public decimal NetProfit { get; set; }
        public decimal Depreciation { get; set; }
        public decimal IncreaseInDebtors { get; set; }
        public decimal NetFromOperations { get; set; }
        public decimal PurchaseOfAssets { get; set; }
        public decimal NetCashFlow { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
