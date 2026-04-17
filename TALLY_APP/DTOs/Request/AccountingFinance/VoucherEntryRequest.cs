using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: VoucherEntry
     *
     * Purpose:
     * Used for Create/Update operations of VoucherEntry
     */
    public class VoucherEntryRequest
    {
        public string VoucherNumber { get; set; }
        public string VoucherType { get; set; }
        public DateTime VoucherDate { get; set; }
        public long PartyId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public long BankAccountId { get; set; }
        public string ReferenceNumber { get; set; }
        public string Narration { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
