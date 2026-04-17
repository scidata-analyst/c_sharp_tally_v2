using System;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: BalanceSheet
     *
     * Purpose:
     * API response model for BalanceSheet
     */
    public class BalanceSheetResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BalanceSheet
         */
        public long Id { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for BalanceSheet
         */
        public string Period { get; set; }
        /**
         * Field: ShareCapital
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal ShareCapital { get; set; }
        /**
         * Field: ReservesSurplus
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal ReservesSurplus { get; set; }
        /**
         * Field: SundryCreditors
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal SundryCreditors { get; set; }
        /**
         * Field: GstPayable
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal GstPayable { get; set; }
        /**
         * Field: TotalLiabilities
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal TotalLiabilities { get; set; }
        /**
         * Field: FixedAssets
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal FixedAssets { get; set; }
        /**
         * Field: StockInTrade
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal StockInTrade { get; set; }
        /**
         * Field: SundryDebtors
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal SundryDebtors { get; set; }
        /**
         * Field: CashBank
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal CashBank { get; set; }
        /**
         * Field: TotalAssets
         * Type: decimal
         * Description: Response property for BalanceSheet
         */
        public decimal TotalAssets { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BalanceSheet
         */
        public DateTime CreatedAt { get; set; }

    }
}
