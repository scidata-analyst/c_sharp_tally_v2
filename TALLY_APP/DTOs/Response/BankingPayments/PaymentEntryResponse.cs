using System;

namespace TALLY_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: PaymentEntry
     *
     * Purpose:
     * API response model for PaymentEntry
     */
    public class PaymentEntryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for PaymentEntry
         */
        public long Id { get; set; }
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string ReferenceNumber { get; set; }
        /**
         * Field: PaymentDate
         * Type: DateTime
         * Description: Response property for PaymentEntry
         */
        public DateTime PaymentDate { get; set; }
        /**
         * Field: PaymentMode
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string PaymentMode { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for PaymentEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string PartyName { get; set; }
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Response property for PaymentEntry
         */
        public long BankAccountId { get; set; }
        /**
         * Field: BankAccount
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string BankAccount { get; set; }
        /**
         * Field: ChequeRefNumber
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string ChequeRefNumber { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Response property for PaymentEntry
         */
        public decimal Amount { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for PaymentEntry
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for PaymentEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for PaymentEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
