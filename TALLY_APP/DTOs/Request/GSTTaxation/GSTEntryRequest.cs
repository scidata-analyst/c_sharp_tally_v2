using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: GSTEntry
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class GSTEntryRequest
    {
        /**
         * Field: InvoiceNumber
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(50)]
        public string InvoiceNumber { get; set; }
        /**
         * Field: InvoiceDate
         * Type: DateTime
         * Description: Request property for GSTEntry
         */
        public DateTime InvoiceDate { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for GSTEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; }
        /**
         * Field: TransactionType
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(50)]
        public string TransactionType { get; set; }
        /**
         * Field: PartyGstin
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(50)]
        public string PartyGstin { get; set; }
        /**
         * Field: PlaceOfSupply
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(100)]
        public string PlaceOfSupply { get; set; }
        /**
         * Field: TaxableAmount
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal TaxableAmount { get; set; }
        /**
         * Field: GstRate
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal GstRate { get; set; }
        /**
         * Field: CgstAmount
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal CgstAmount { get; set; }
        /**
         * Field: SgstAmount
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal SgstAmount { get; set; }
        /**
         * Field: IgstAmount
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal IgstAmount { get; set; }
        /**
         * Field: TotalTax
         * Type: decimal
         * Description: Request property for GSTEntry
         */
        [Range(0, double.MaxValue)]
        public decimal TotalTax { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for GSTEntry
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for GSTEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for GSTEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
