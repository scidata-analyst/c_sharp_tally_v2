using System;

namespace POS_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: CurrencyExchange
     *
     * Purpose:
     * API response model for CurrencyExchange
     */
    public class CurrencyExchangeResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for CurrencyExchange
         */
        public long Id { get; set; }
        /**
         * Field: CurrencyName
         * Type: string
         * Description: Response property for CurrencyExchange
         */
        public string CurrencyName { get; set; }
        /**
         * Field: CurrencyCode
         * Type: string
         * Description: Response property for CurrencyExchange
         */
        public string CurrencyCode { get; set; }
        /**
         * Field: Symbol
         * Type: string
         * Description: Response property for CurrencyExchange
         */
        public string Symbol { get; set; }
        /**
         * Field: BuyRate
         * Type: decimal
         * Description: Response property for CurrencyExchange
         */
        public decimal BuyRate { get; set; }
        /**
         * Field: SellRate
         * Type: decimal
         * Description: Response property for CurrencyExchange
         */
        public decimal SellRate { get; set; }
        /**
         * Field: LastUpdated
         * Type: DateTime
         * Description: Response property for CurrencyExchange
         */
        public DateTime LastUpdated { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for CurrencyExchange
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for CurrencyExchange
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for CurrencyExchange
         */
        public DateTime UpdatedAt { get; set; }

    }
}
