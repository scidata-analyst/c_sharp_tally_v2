using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: CurrencyExchange
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class CurrencyExchangeRequest
    {
        /**
         * Field: CurrencyName
         * Type: string
         * Description: Request property for CurrencyExchange
         */
        [Required]
        [MaxLength(100)]
        public string CurrencyName { get; set; }
        /**
         * Field: CurrencyCode
         * Type: string
         * Description: Request property for CurrencyExchange
         */
        [Required]
        [MaxLength(10)]
        public string CurrencyCode { get; set; }
        /**
         * Field: Symbol
         * Type: string
         * Description: Request property for CurrencyExchange
         */
        [Required]
        [MaxLength(10)]
        public string Symbol { get; set; }
        /**
         * Field: BuyRate
         * Type: decimal
         * Description: Request property for CurrencyExchange
         */
        [Range(0, double.MaxValue)]
        public decimal BuyRate { get; set; }
        /**
         * Field: SellRate
         * Type: decimal
         * Description: Request property for CurrencyExchange
         */
        [Range(0, double.MaxValue)]
        public decimal SellRate { get; set; }
        /**
         * Field: LastUpdated
         * Type: DateTime
         * Description: Request property for CurrencyExchange
         */
        public DateTime LastUpdated { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for CurrencyExchange
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for CurrencyExchange
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for CurrencyExchange
         */
        public DateTime UpdatedAt { get; set; }

    }
}
