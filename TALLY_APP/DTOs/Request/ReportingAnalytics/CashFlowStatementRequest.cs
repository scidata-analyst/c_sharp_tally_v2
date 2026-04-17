using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: CashFlowStatement
     *
     * Purpose:
     * Used for Create/Update operations of CashFlowStatement
     */
    public class CashFlowStatementRequest
    {
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
