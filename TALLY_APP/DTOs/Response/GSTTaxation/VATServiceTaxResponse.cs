using System;

namespace POS_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: VATServiceTax
     *
     * Purpose:
     * Used for API responses of VATServiceTax
     */
    public class VATServiceTaxResponse
    {
        public long Id { get; set; }
        public string TaxType { get; set; }
        public decimal OutputTax { get; set; }
        public decimal InputTax { get; set; }
        public decimal NetTaxPayable { get; set; }
        public string Period { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
