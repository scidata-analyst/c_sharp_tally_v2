using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: BankAccount
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BankAccountRequest
    {
        /**
         * Field: AccountName
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(200)]
        public string AccountName { get; set; } = string.Empty;
        /**
         * Field: AccountType
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(50)]
        public string AccountType { get; set; } = string.Empty;
        /**
         * Field: BankName
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(200)]
        public string BankName { get; set; } = string.Empty;
        /**
         * Field: AccountNumber
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(50)]
        public string AccountNumber { get; set; } = string.Empty;
        /**
         * Field: IfscCode
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(20)]
        public string IfscCode { get; set; } = string.Empty;
        /**
         * Field: OpeningBalance
         * Type: decimal
         * Description: Request property for BankAccount
         */
        [Range(0, double.MaxValue)]
        public decimal? OpeningBalance { get; set; }
        /**
         * Field: CurrentBalance
         * Type: decimal
         * Description: Request property for BankAccount
         */
        [Range(0, double.MaxValue)]
        public decimal? CurrentBalance { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for BankAccount
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = string.Empty;
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BankAccount
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for BankAccount
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

