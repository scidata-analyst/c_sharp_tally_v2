using System;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: VATServiceTax
     *
     * Purpose:
     * Used for Create/Update operations of VATServiceTax
     */
    public class VATServiceTaxRequest
    {
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
