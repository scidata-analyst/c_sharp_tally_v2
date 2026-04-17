using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: ForexTransaction
     *
     * Purpose:
     * API response model for ForexTransaction
     */
    public class ForexTransactionResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for ForexTransaction
         */
        public long Id { get; set; }
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Response property for ForexTransaction
         */
        public string ReferenceNumber { get; set; }
        /**
         * Field: TransactionDate
         * Type: DateTime
         * Description: Response property for ForexTransaction
         */
        public DateTime TransactionDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for ForexTransaction
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for ForexTransaction
         */
        public string PartyName { get; set; }
        /**
         * Field: CurrencyId
         * Type: long
         * Description: Response property for ForexTransaction
         */
        public long CurrencyId { get; set; }
        /**
         * Field: Currency
         * Type: string
         * Description: Response property for ForexTransaction
         */
        public string Currency { get; set; }
        /**
         * Field: ForeignAmount
         * Type: decimal
         * Description: Response property for ForexTransaction
         */
        public decimal ForeignAmount { get; set; }
        /**
         * Field: ExchangeRate
         * Type: decimal
         * Description: Response property for ForexTransaction
         */
        public decimal ExchangeRate { get; set; }
        /**
         * Field: InrAmount
         * Type: decimal
         * Description: Response property for ForexTransaction
         */
        public decimal InrAmount { get; set; }
        /**
         * Field: ForexGainLoss
         * Type: decimal
         * Description: Response property for ForexTransaction
         */
        public decimal ForexGainLoss { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for ForexTransaction
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for ForexTransaction
         */
        public DateTime CreatedAt { get; set; }

    }
}
