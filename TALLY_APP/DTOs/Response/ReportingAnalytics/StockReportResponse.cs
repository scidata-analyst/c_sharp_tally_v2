using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: StockReport
     *
     * Purpose:
     * Used for API responses of StockReport
     */
    public class StockReportResponse
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int OpeningQty { get; set; }
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public int ClosingQty { get; set; }
        public decimal StockValue { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
