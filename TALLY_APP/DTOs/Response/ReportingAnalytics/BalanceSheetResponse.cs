using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: BalanceSheet
     *
     * Purpose:
     * Used for API responses of BalanceSheet
     */
    public class BalanceSheetResponse
    {
        public long Id { get; set; }
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
