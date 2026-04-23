using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: LedgerAccount
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class LedgerAccountRequest
    {
        /**
         * Field: LedgerName
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(200)]
        public string LedgerName { get; set; } = string.Empty;
        /**
         * Field: LedgerCode
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(50)]
        public string LedgerCode { get; set; } = string.Empty;
        /**
         * Field: GroupName
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(100)]
        public string GroupName { get; set; } = string.Empty;
        /**
         * Field: AccountType
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(50)]
        public string AccountType { get; set; } = string.Empty;
        /**
         * Field: OpeningBalance
         * Type: decimal
         * Description: Request property for LedgerAccount
         */
        [Range(0, double.MaxValue)]
        public decimal OpeningBalance { get; set; }
        /**
         * Field: BalanceType
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(20)]
        public string BalanceType { get; set; } = string.Empty;
        /**
         * Field: Description
         * Type: string
         * Description: Request property for LedgerAccount
         */
        public string? Description { get; set; }
        /**
         * Field: Currency
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(10)]
        public string Currency { get; set; } = string.Empty;
        /**
         * Field: Status
         * Type: string
         * Description: Request property for LedgerAccount
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = string.Empty;
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for LedgerAccount
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for LedgerAccount
         */
        public DateTime UpdatedAt { get; set; }

    }
}
