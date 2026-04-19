using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: ForexTransaction
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class ForexTransactionRequest
    {
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Request property for ForexTransaction
         */
        [Required]
        [MaxLength(50)]
        public string ReferenceNumber { get; set; }
        /**
         * Field: TransactionDate
         * Type: DateTime
         * Description: Request property for ForexTransaction
         */
        public DateTime TransactionDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for ForexTransaction
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for ForexTransaction
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; }
        /**
         * Field: CurrencyId
         * Type: long
         * Description: Request property for ForexTransaction
         */
        public long CurrencyId { get; set; }
        /**
         * Field: Currency
         * Type: string
         * Description: Request property for ForexTransaction
         */
        [Required]
        [MaxLength(10)]
        public string Currency { get; set; }
        /**
         * Field: ForeignAmount
         * Type: decimal
         * Description: Request property for ForexTransaction
         */
        [Range(0, double.MaxValue)]
        public decimal ForeignAmount { get; set; }
        /**
         * Field: ExchangeRate
         * Type: decimal
         * Description: Request property for ForexTransaction
         */
        [Range(0, double.MaxValue)]
        public decimal ExchangeRate { get; set; }
        /**
         * Field: InrAmount
         * Type: decimal
         * Description: Request property for ForexTransaction
         */
        [Range(0, double.MaxValue)]
        public decimal InrAmount { get; set; }
        /**
         * Field: ForexGainLoss
         * Type: decimal
         * Description: Request property for ForexTransaction
         */
        [Range(0, double.MaxValue)]
        public decimal ForexGainLoss { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for ForexTransaction
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for ForexTransaction
         */
        public DateTime CreatedAt { get; set; }

    }
}
