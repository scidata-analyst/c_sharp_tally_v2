using System;

namespace POS_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: PaymentEntry
     *
     * Purpose:
     * Used for Create/Update operations of PaymentEntry
     */
    public class PaymentEntryRequest
    {
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
