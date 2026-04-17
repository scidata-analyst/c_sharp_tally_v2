using System;

namespace POS_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: ForexTransaction
     *
     * Purpose:
     * Used for Create/Update operations of ForexTransaction
     */
    public class ForexTransactionRequest
    {
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
