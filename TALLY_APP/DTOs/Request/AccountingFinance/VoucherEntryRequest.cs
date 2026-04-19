using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: VoucherEntry
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class VoucherEntryRequest
    {
        /**
         * Field: VoucherNumber
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        [MaxLength(50)]
        public string VoucherNumber { get; set; }
        /**
         * Field: VoucherType
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        [MaxLength(50)]
        public string VoucherType { get; set; }
        /**
         * Field: VoucherDate
         * Type: DateTime
         * Description: Request property for VoucherEntry
         */
        public DateTime VoucherDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for VoucherEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Request property for VoucherEntry
         */
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
        /**
         * Field: PaymentMode
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        [MaxLength(50)]
        public string PaymentMode { get; set; }
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Request property for VoucherEntry
         */
        public long BankAccountId { get; set; }
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        [MaxLength(100)]
        public string ReferenceNumber { get; set; }
        /**
         * Field: Narration
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        public string Narration { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for VoucherEntry
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for VoucherEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for VoucherEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
