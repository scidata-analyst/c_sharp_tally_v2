using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: BalanceSheet
     *
     * Purpose:
     * Used for Create/Update operations of BalanceSheet
     */
    public class BalanceSheetRequest
    {
        public string Period { get; set; }
        public decimal ShareCapital { get; set; }
        public decimal ReservesSurplus { get; set; }
        public decimal SundryCreditors { get; set; }
        public decimal GstPayable { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal FixedAssets { get; set; }
        public decimal StockInTrade { get; set; }
        public decimal SundryDebtors { get; set; }
        public decimal CashBank { get; set; }
        public decimal TotalAssets { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
