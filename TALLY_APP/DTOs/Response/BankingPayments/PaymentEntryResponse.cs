using System;

namespace POS_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: PaymentEntry
     *
     * Purpose:
     * Used for API responses of PaymentEntry
     */
    public class PaymentEntryResponse
    {
        public long Id { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public long PartyId { get; set; }
        public string PartyName { get; set; }
        public long BankAccountId { get; set; }
        public string BankAccount { get; set; }
        public string ChequeRefNumber { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
