using System;

namespace POS_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: CurrencyExchange
     *
     * Purpose:
     * Used for API responses of CurrencyExchange
     */
    public class CurrencyExchangeResponse
    {
        public long Id { get; set; }
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
