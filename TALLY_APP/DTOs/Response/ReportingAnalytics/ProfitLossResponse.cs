using System;

namespace POS_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: ProfitLoss
     *
     * Purpose:
     * API response model for ProfitLoss
     */
    public class ProfitLossResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for ProfitLoss
         */
        public long Id { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for ProfitLoss
         */
        public string Period { get; set; }
        /**
         * Field: SalesRevenue
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal SalesRevenue { get; set; }
        /**
         * Field: OtherIncome
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal OtherIncome { get; set; }
        /**
         * Field: GrossIncome
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal GrossIncome { get; set; }
        /**
         * Field: CostOfGoodsSold
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal CostOfGoodsSold { get; set; }
        /**
         * Field: EmployeeCosts
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal EmployeeCosts { get; set; }
        /**
         * Field: AdminOverheads
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal AdminOverheads { get; set; }
        /**
         * Field: NetProfit
         * Type: decimal
         * Description: Response property for ProfitLoss
         */
        public decimal NetProfit { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for ProfitLoss
         */
        public DateTime CreatedAt { get; set; }

    }
}
