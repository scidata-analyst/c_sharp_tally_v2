using System;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: SalesPurchaseSummary
     *
     * Purpose:
     * Used for Create/Update operations of SalesPurchaseSummary
     */
    public class SalesPurchaseSummaryRequest
    {
        public string Period { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalPurchases { get; set; }
        public decimal GrossMargin { get; set; }
        public decimal ReturnOnSales { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
