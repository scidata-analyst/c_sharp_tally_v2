using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: PaymentEntry
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class PaymentEntryRequest
    {
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(50)]
        public string ReferenceNumber { get; set; }
        /**
         * Field: PaymentDate
         * Type: DateTime
         * Description: Request property for PaymentEntry
         */
        public DateTime PaymentDate { get; set; }
        /**
         * Field: PaymentMode
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(50)]
        public string PaymentMode { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for PaymentEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; }
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Request property for PaymentEntry
         */
        public long BankAccountId { get; set; }
        /**
         * Field: BankAccount
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(100)]
        public string BankAccount { get; set; }
        /**
         * Field: ChequeRefNumber
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(50)]
        public string ChequeRefNumber { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Request property for PaymentEntry
         */
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for PaymentEntry
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for PaymentEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for PaymentEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
