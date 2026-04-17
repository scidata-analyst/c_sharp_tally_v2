using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: SalesPurchaseSummary
     *
     * Purpose:
     * API response model for SalesPurchaseSummary
     */
    public class SalesPurchaseSummaryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for SalesPurchaseSummary
         */
        public long Id { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for SalesPurchaseSummary
         */
        public string Period { get; set; }
        /**
         * Field: TotalSales
         * Type: decimal
         * Description: Response property for SalesPurchaseSummary
         */
        public decimal TotalSales { get; set; }
        /**
         * Field: TotalPurchases
         * Type: decimal
         * Description: Response property for SalesPurchaseSummary
         */
        public decimal TotalPurchases { get; set; }
        /**
         * Field: GrossMargin
         * Type: decimal
         * Description: Response property for SalesPurchaseSummary
         */
        public decimal GrossMargin { get; set; }
        /**
         * Field: ReturnOnSales
         * Type: decimal
         * Description: Response property for SalesPurchaseSummary
         */
        public decimal ReturnOnSales { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for SalesPurchaseSummary
         */
        public DateTime CreatedAt { get; set; }

    }
}
