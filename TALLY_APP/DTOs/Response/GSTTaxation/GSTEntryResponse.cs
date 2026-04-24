using System;

namespace TALLY_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: GSTEntry
     *
     * Purpose:
     * API response model for GSTEntry
     */
    public class GSTEntryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for GSTEntry
         */
        public long Id { get; set; }
        /**
         * Field: InvoiceNumber
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string InvoiceNumber { get; set; }
        /**
         * Field: InvoiceDate
         * Type: DateTime
         * Description: Response property for GSTEntry
         */
        public DateTime InvoiceDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for GSTEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string PartyName { get; set; }
        /**
         * Field: TransactionType
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string TransactionType { get; set; }
        /**
         * Field: PartyGstin
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string PartyGstin { get; set; }
        /**
         * Field: PlaceOfSupply
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string PlaceOfSupply { get; set; }
        /**
         * Field: TaxableAmount
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal TaxableAmount { get; set; }
        /**
         * Field: GstRate
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal GstRate { get; set; }
        /**
         * Field: CgstAmount
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal CgstAmount { get; set; }
        /**
         * Field: SgstAmount
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal SgstAmount { get; set; }
        /**
         * Field: IgstAmount
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal IgstAmount { get; set; }
        /**
         * Field: TotalTax
         * Type: decimal
         * Description: Response property for GSTEntry
         */
        public decimal TotalTax { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for GSTEntry
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for GSTEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for GSTEntry
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedGSTEntryResponse
     *
     * Purpose:
     * API response model for paginated GST entry list
     */
    public class PaginatedGSTEntryResponse
    {
        public List<GSTEntryResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
