using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: TDSTCSEntry
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class TDSTCSEntryRequest
    {
        /**
         * Field: Section
         * Type: string
         * Description: Request property for TDSTCSEntry
         */
        [Required]
        [MaxLength(20)]
        public string Section { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Request property for TDSTCSEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for TDSTCSEntry
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; }
        /**
         * Field: PanNumber
         * Type: string
         * Description: Request property for TDSTCSEntry
         */
        [Required]
        [MaxLength(20)]
        public string PanNumber { get; set; }
        /**
         * Field: PaymentAmount
         * Type: decimal
         * Description: Request property for TDSTCSEntry
         */
        [Range(0, double.MaxValue)]
        public decimal PaymentAmount { get; set; }
        /**
         * Field: TdsRate
         * Type: decimal
         * Description: Request property for TDSTCSEntry
         */
        [Range(0, double.MaxValue)]
        public decimal TdsRate { get; set; }
        /**
         * Field: TdsAmount
         * Type: decimal
         * Description: Request property for TDSTCSEntry
         */
        [Range(0, double.MaxValue)]
        public decimal TdsAmount { get; set; }
        /**
         * Field: CertificateNumber
         * Type: string
         * Description: Request property for TDSTCSEntry
         */
        [Required]
        [MaxLength(50)]
        public string CertificateNumber { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for TDSTCSEntry
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for TDSTCSEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for TDSTCSEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
