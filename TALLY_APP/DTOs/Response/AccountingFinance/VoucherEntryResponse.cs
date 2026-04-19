using System;

namespace TALLY_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: VoucherEntry
     *
     * Purpose:
     * API response model for VoucherEntry
     */
    public class VoucherEntryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for VoucherEntry
         */
        public long Id { get; set; }
        /**
         * Field: VoucherNumber
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string VoucherNumber { get; set; }
        /**
         * Field: VoucherType
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string VoucherType { get; set; }
        /**
         * Field: VoucherDate
         * Type: DateTime
         * Description: Response property for VoucherEntry
         */
        public DateTime VoucherDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for VoucherEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Response property for VoucherEntry
         */
        public decimal Amount { get; set; }
        /**
         * Field: PaymentMode
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string PaymentMode { get; set; }
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Response property for VoucherEntry
         */
        public long BankAccountId { get; set; }
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string ReferenceNumber { get; set; }
        /**
         * Field: Narration
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string Narration { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for VoucherEntry
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for VoucherEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for VoucherEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
