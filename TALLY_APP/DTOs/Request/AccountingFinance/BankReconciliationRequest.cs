using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: BankReconciliation
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BankReconciliationRequest
    {
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Request property for BankReconciliation
         */
        public long BankAccountId { get; set; }
        /**
         * Field: StatementDate
         * Type: DateTime
         * Description: Request property for BankReconciliation
         */
        public DateTime StatementDate { get; set; }
        /**
         * Field: BankBalance
         * Type: decimal
         * Description: Request property for BankReconciliation
         */
        [Range(0, double.MaxValue)]
        public decimal BankBalance { get; set; }
        /**
         * Field: BookBalance
         * Type: decimal
         * Description: Request property for BankReconciliation
         */
        [Range(0, double.MaxValue)]
        public decimal BookBalance { get; set; }
        /**
         * Field: UnreconciledAmount
         * Type: decimal
         * Description: Request property for BankReconciliation
         */
        [Range(0, double.MaxValue)]
        public decimal UnreconciledAmount { get; set; }
        /**
         * Field: PendingItems
         * Type: int
         * Description: Request property for BankReconciliation
         */
        public int PendingItems { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for BankReconciliation
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: ReconciledAt
         * Type: DateTime
         * Description: Request property for BankReconciliation
         */
        public DateTime ReconciledAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BankReconciliation
         */
        public DateTime CreatedAt { get; set; }

    }
}
