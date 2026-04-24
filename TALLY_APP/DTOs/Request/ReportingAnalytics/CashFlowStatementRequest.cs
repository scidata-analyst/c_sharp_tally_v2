using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: CashFlowStatement
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class CashFlowStatementRequest
    {
        /**
         * Field: Period
         * Type: string
         * Description: Request property for CashFlowStatement
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: NetProfit
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? NetProfit { get; set; }
        /**
         * Field: Depreciation
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? Depreciation { get; set; }
        /**
         * Field: IncreaseInDebtors
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? IncreaseInDebtors { get; set; }
        /**
         * Field: NetFromOperations
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? NetFromOperations { get; set; }
        /**
         * Field: PurchaseOfAssets
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? PurchaseOfAssets { get; set; }
        /**
         * Field: NetCashFlow
         * Type: decimal
         * Description: Request property for CashFlowStatement
         */
        [Range(0, double.MaxValue)]
        public decimal? NetCashFlow { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for CashFlowStatement
         */
        public DateTime? CreatedAt { get; set; }

    }
}

