using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: BalanceSheet
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BalanceSheetRequest
    {
        /**
         * Field: Period
         * Type: string
         * Description: Request property for BalanceSheet
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: ShareCapital
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal ShareCapital { get; set; }
        /**
         * Field: ReservesSurplus
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal ReservesSurplus { get; set; }
        /**
         * Field: SundryCreditors
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal SundryCreditors { get; set; }
        /**
         * Field: GstPayable
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal GstPayable { get; set; }
        /**
         * Field: TotalLiabilities
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal TotalLiabilities { get; set; }
        /**
         * Field: FixedAssets
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal FixedAssets { get; set; }
        /**
         * Field: StockInTrade
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal StockInTrade { get; set; }
        /**
         * Field: SundryDebtors
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal SundryDebtors { get; set; }
        /**
         * Field: CashBank
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal CashBank { get; set; }
        /**
         * Field: TotalAssets
         * Type: decimal
         * Description: Request property for BalanceSheet
         */
        [Range(0, double.MaxValue)]
        public decimal TotalAssets { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BalanceSheet
         */
        public DateTime CreatedAt { get; set; }

    }
}
