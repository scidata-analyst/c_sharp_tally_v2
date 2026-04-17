using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: ForexTransaction
     *
     * Purpose:
     * Used for API responses of ForexTransaction
     */
    public class ForexTransactionResponse
    {
        public long Id { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public long PartyId { get; set; }
        public string PartyName { get; set; }
        public long CurrencyId { get; set; }
        public string Currency { get; set; }
        public decimal ForeignAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal InrAmount { get; set; }
        public decimal ForexGainLoss { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
