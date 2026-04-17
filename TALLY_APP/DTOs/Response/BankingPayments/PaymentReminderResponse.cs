using System;

namespace POS_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: PaymentReminder
     *
     * Purpose:
     * Used for API responses of PaymentReminder
     */
    public class PaymentReminderResponse
    {
        public long Id { get; set; }
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
