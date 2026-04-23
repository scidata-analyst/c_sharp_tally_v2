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

    /**
     * Response DTO: PaginatedVoucherResponse
     *
     * Purpose:
     * API response model for paginated voucher list
     */
    public class PaginatedVoucherResponse
    {
        public System.Collections.Generic.List<VoucherEntryResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
