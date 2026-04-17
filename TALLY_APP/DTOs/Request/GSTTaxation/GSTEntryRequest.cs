using System;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: GSTEntry
     *
     * Purpose:
     * Used for Create/Update operations of GSTEntry
     */
    public class GSTEntryRequest
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public long PartyId { get; set; }
        public string PartyName { get; set; }
        public string TransactionType { get; set; }
        public string PartyGstin { get; set; }
        public string PlaceOfSupply { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal GstRate { get; set; }
        public decimal CgstAmount { get; set; }
        public decimal SgstAmount { get; set; }
        public decimal IgstAmount { get; set; }
        public decimal TotalTax { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
