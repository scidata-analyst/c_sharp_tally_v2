using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: Godown
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class GodownRequest
    {
        /**
         * Field: GodownName
         * Type: string
         * Description: Request property for Godown
         */
        [Required]
        [MaxLength(200)]
        public string GodownName { get; set; }
        /**
         * Field: Location
         * Type: string
         * Description: Request property for Godown
         */
        [Required]
        [MaxLength(200)]
        public string Location { get; set; }
        /**
         * Field: Manager
         * Type: string
         * Description: Request property for Godown
         */
        [Required]
        [MaxLength(100)]
        public string Manager { get; set; }
        /**
         * Field: Capacity
         * Type: string
         * Description: Request property for Godown
         */
        [Required]
        [MaxLength(50)]
        public string Capacity { get; set; }
        /**
         * Field: UsedPercentage
         * Type: decimal
         * Description: Request property for Godown
         */
        [Range(0, double.MaxValue)]
        public decimal UsedPercentage { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Request property for Godown
         */
        [Range(0, double.MaxValue)]
        public decimal StockValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for Godown
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for Godown
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for Godown
         */
        public DateTime UpdatedAt { get; set; }

    }
}
