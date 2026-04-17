using System;

namespace POS_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: PaymentReminder
     *
     * Purpose:
     * Used for Create/Update operations of PaymentReminder
     */
    public class PaymentReminderRequest
    {
        public long PartyId { get; set; }
        public string PartyName { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public int OverdueBy { get; set; }
        public string ReminderNumber { get; set; }
        public DateTime LastSent { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
