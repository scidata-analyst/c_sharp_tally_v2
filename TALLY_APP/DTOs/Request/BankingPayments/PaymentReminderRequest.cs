using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: PaymentReminder
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class PaymentReminderRequest
    {
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for PaymentReminder
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for PaymentReminder
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; }
        /**
         * Field: InvoiceNumber
         * Type: string
         * Description: Request property for PaymentReminder
         */
        [Required]
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Request property for PaymentReminder
         */
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }
        /**
         * Field: OverdueBy
         * Type: int
         * Description: Request property for PaymentReminder
         */
        public int OverdueBy { get; set; }
        /**
         * Field: ReminderNumber
         * Type: string
         * Description: Request property for PaymentReminder
         */
        [Required]
        [MaxLength(20)]
        public string ReminderNumber { get; set; }
        /**
         * Field: LastSent
         * Type: DateTime
         * Description: Request property for PaymentReminder
         */
        public DateTime LastSent { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for PaymentReminder
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for PaymentReminder
         */
        public DateTime CreatedAt { get; set; }

    }
}
