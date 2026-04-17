using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: CurrencyExchange
     *
     * Purpose:
     * Used for Create/Update operations of CurrencyExchange
     */
    public class CurrencyExchangeRequest
    {
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string Symbol { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SellRate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
