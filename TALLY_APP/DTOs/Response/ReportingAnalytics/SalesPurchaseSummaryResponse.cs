using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: SalesPurchaseSummary
     *
     * Purpose:
     * Used for API responses of SalesPurchaseSummary
     */
    public class SalesPurchaseSummaryResponse
    {
        public long Id { get; set; }
        public string Period { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalPurchases { get; set; }
        public decimal GrossMargin { get; set; }
        public decimal ReturnOnSales { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
