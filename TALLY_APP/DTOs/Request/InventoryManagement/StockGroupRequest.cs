using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: StockGroup
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class StockGroupRequest
    {
        /**
         * Field: GroupName
         * Type: string
         * Description: Request property for StockGroup
         */
        [Required]
        [MaxLength(200)]
        public string GroupName { get; set; }
        /**
         * Field: ParentGroup
         * Type: string
         * Description: Request property for StockGroup
         */
        [Required]
        [MaxLength(100)]
        public string ParentGroup { get; set; }
        /**
         * Field: ItemsCount
         * Type: int
         * Description: Request property for StockGroup
         */
        public int ItemsCount { get; set; }
        /**
         * Field: ValuationMethod
         * Type: string
         * Description: Request property for StockGroup
         */
        [Required]
        [MaxLength(50)]
        public string ValuationMethod { get; set; }
        /**
         * Field: TotalValue
         * Type: decimal
         * Description: Request property for StockGroup
         */
        [Range(0, double.MaxValue)]
        public decimal TotalValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for StockGroup
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for StockGroup
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for StockGroup
         */
        public DateTime UpdatedAt { get; set; }

    }
}
