using System;

namespace TALLY_APP.DTOs.Response.AccountingFinance
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

    /**
     * Response DTO: PaginatedCurrencyResponse
     *
     * Purpose:
     * API response model for paginated currency list
     */
    public class PaginatedCurrencyResponse
    {
        public System.Collections.Generic.List<CurrencyExchangeResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
