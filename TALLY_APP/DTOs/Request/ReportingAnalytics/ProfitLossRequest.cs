using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: ProfitLoss
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class ProfitLossRequest
    {
        /**
         * Field: Period
         * Type: string
         * Description: Request property for ProfitLoss
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: SalesRevenue
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal SalesRevenue { get; set; }
        /**
         * Field: OtherIncome
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal OtherIncome { get; set; }
        /**
         * Field: GrossIncome
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal GrossIncome { get; set; }
        /**
         * Field: CostOfGoodsSold
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal CostOfGoodsSold { get; set; }
        /**
         * Field: EmployeeCosts
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal EmployeeCosts { get; set; }
        /**
         * Field: AdminOverheads
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal AdminOverheads { get; set; }
        /**
         * Field: NetProfit
         * Type: decimal
         * Description: Request property for ProfitLoss
         */
        [Range(0, double.MaxValue)]
        public decimal NetProfit { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for ProfitLoss
         */
        public DateTime CreatedAt { get; set; }

    }
}
