using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: VATServiceTax
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class VATServiceTaxRequest
    {
        /**
         * Field: TaxType
         * Type: string
         * Description: Request property for VATServiceTax
         */
        [Required]
        [MaxLength(50)]
        public string TaxType { get; set; }
        /**
         * Field: OutputTax
         * Type: decimal
         * Description: Request property for VATServiceTax
         */
        [Range(0, double.MaxValue)]
        public decimal OutputTax { get; set; }
        /**
         * Field: InputTax
         * Type: decimal
         * Description: Request property for VATServiceTax
         */
        [Range(0, double.MaxValue)]
        public decimal InputTax { get; set; }
        /**
         * Field: NetTaxPayable
         * Type: decimal
         * Description: Request property for VATServiceTax
         */
        [Range(0, double.MaxValue)]
        public decimal NetTaxPayable { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for VATServiceTax
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for VATServiceTax
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for VATServiceTax
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for VATServiceTax
         */
        public DateTime UpdatedAt { get; set; }

    }
}
