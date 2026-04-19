using System;

namespace TALLY_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: VATServiceTax
     *
     * Purpose:
     * API response model for VATServiceTax
     */
    public class VATServiceTaxResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for VATServiceTax
         */
        public long Id { get; set; }
        /**
         * Field: TaxType
         * Type: string
         * Description: Response property for VATServiceTax
         */
        public string TaxType { get; set; }
        /**
         * Field: OutputTax
         * Type: decimal
         * Description: Response property for VATServiceTax
         */
        public decimal OutputTax { get; set; }
        /**
         * Field: InputTax
         * Type: decimal
         * Description: Response property for VATServiceTax
         */
        public decimal InputTax { get; set; }
        /**
         * Field: NetTaxPayable
         * Type: decimal
         * Description: Response property for VATServiceTax
         */
        public decimal NetTaxPayable { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for VATServiceTax
         */
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for VATServiceTax
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for VATServiceTax
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for VATServiceTax
         */
        public DateTime UpdatedAt { get; set; }

    }
}
