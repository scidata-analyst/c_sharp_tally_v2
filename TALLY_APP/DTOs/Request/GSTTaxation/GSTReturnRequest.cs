using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: GSTReturn
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class GSTReturnRequest
    {
        /**
         * Field: ReturnType
         * Type: string
         * Description: Request property for GSTReturn
         */
        [Required]
        [MaxLength(50)]
        public string ReturnType { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for GSTReturn
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: DueDate
         * Type: DateTime
         * Description: Request property for GSTReturn
         */
        public DateTime DueDate { get; set; }
        /**
         * Field: TotalOutward
         * Type: decimal
         * Description: Request property for GSTReturn
         */
        [Range(0, double.MaxValue)]
        public decimal TotalOutward { get; set; }
        /**
         * Field: TaxCollected
         * Type: decimal
         * Description: Request property for GSTReturn
         */
        [Range(0, double.MaxValue)]
        public decimal TaxCollected { get; set; }
        /**
         * Field: TotalInward
         * Type: decimal
         * Description: Request property for GSTReturn
         */
        [Range(0, double.MaxValue)]
        public decimal TotalInward { get; set; }
        /**
         * Field: ItcAvailable
         * Type: decimal
         * Description: Request property for GSTReturn
         */
        [Range(0, double.MaxValue)]
        public decimal ItcAvailable { get; set; }
        /**
         * Field: NetPayable
         * Type: decimal
         * Description: Request property for GSTReturn
         */
        [Range(0, double.MaxValue)]
        public decimal NetPayable { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for GSTReturn
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: FiledDate
         * Type: DateTime
         * Description: Request property for GSTReturn
         */
        public DateTime FiledDate { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for GSTReturn
         */
        public DateTime CreatedAt { get; set; }

    }
}
