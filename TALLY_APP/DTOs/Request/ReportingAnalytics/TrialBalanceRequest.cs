using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: TrialBalance
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class TrialBalanceRequest
    {
        /**
         * Field: AccountName
         * Type: string
         * Description: Request property for TrialBalance
         */
        [Required]
        [MaxLength(200)]
        public string AccountName { get; set; }
        /**
         * Field: GroupName
         * Type: string
         * Description: Request property for TrialBalance
         */
        [Required]
        [MaxLength(100)]
        public string GroupName { get; set; }
        /**
         * Field: OpeningDr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal OpeningDr { get; set; }
        /**
         * Field: OpeningCr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal OpeningCr { get; set; }
        /**
         * Field: TransactionDr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal TransactionDr { get; set; }
        /**
         * Field: TransactionCr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal TransactionCr { get; set; }
        /**
         * Field: ClosingDr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal ClosingDr { get; set; }
        /**
         * Field: ClosingCr
         * Type: decimal
         * Description: Request property for TrialBalance
         */
        [Range(0, double.MaxValue)]
        public decimal ClosingCr { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for TrialBalance
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for TrialBalance
         */
        public DateTime CreatedAt { get; set; }

    }
}
