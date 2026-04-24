using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: PartyDirectory
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class PartyDirectoryRequest
    {
        /**
         * Field: PartyName
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(200)]
        public string PartyName { get; set; } = string.Empty;
        /**
         * Field: PartyType
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(50)]
        public string PartyType { get; set; } = string.Empty;
        /**
         * Field: Gstin
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(50)]
        public string Gstin { get; set; } = string.Empty;
        /**
         * Field: PanNumber
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(20)]
        public string PanNumber { get; set; } = string.Empty;
        /**
         * Field: Phone
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;
        /**
         * Field: Email
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;
        /**
         * Field: Address
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        public string Address { get; set; } = string.Empty;
        /**
         * Field: CreditLimit
         * Type: decimal
         * Description: Request property for PartyDirectory
         */
        [Range(0, double.MaxValue)]
        public decimal? CreditLimit { get; set; }
        /**
         * Field: CreditPeriod
         * Type: int
         * Description: Request property for PartyDirectory
         */
        public int? CreditPeriod { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for PartyDirectory
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = string.Empty;
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for PartyDirectory
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for PartyDirectory
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

