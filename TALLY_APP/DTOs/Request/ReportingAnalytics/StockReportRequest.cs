using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: StockReport
     *
     * Purpose:
     * Used for Create/Update operations of StockReport
     */
    public class StockReportRequest
    {
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
