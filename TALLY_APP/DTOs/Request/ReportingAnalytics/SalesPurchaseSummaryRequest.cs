using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: SalesPurchaseSummary
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class SalesPurchaseSummaryRequest
    {
        /**
         * Field: Period
         * Type: string
         * Description: Request property for SalesPurchaseSummary
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: TotalSales
         * Type: decimal
         * Description: Request property for SalesPurchaseSummary
         */
        [Range(0, double.MaxValue)]
        public decimal TotalSales { get; set; }
        /**
         * Field: TotalPurchases
         * Type: decimal
         * Description: Request property for SalesPurchaseSummary
         */
        [Range(0, double.MaxValue)]
        public decimal TotalPurchases { get; set; }
        /**
         * Field: GrossMargin
         * Type: decimal
         * Description: Request property for SalesPurchaseSummary
         */
        [Range(0, double.MaxValue)]
        public decimal GrossMargin { get; set; }
        /**
         * Field: ReturnOnSales
         * Type: decimal
         * Description: Request property for SalesPurchaseSummary
         */
        [Range(0, double.MaxValue)]
        public decimal ReturnOnSales { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for SalesPurchaseSummary
         */
        public DateTime CreatedAt { get; set; }

    }
}
