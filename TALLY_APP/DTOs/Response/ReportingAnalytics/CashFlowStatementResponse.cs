using System;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: CashFlowStatement
     *
     * Purpose:
     * API response model for CashFlowStatement
     */
    public class CashFlowStatementResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for CashFlowStatement
         */
        public long Id { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for CashFlowStatement
         */
        public string Period { get; set; }
        /**
         * Field: NetProfit
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal NetProfit { get; set; }
        /**
         * Field: Depreciation
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal Depreciation { get; set; }
        /**
         * Field: IncreaseInDebtors
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal IncreaseInDebtors { get; set; }
        /**
         * Field: NetFromOperations
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal NetFromOperations { get; set; }
        /**
         * Field: PurchaseOfAssets
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal PurchaseOfAssets { get; set; }
        /**
         * Field: NetCashFlow
         * Type: decimal
         * Description: Response property for CashFlowStatement
         */
        public decimal NetCashFlow { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for CashFlowStatement
         */
        public DateTime CreatedAt { get; set; }

    }
}
