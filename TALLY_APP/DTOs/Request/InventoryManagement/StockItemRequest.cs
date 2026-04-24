using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: StockItem
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class StockItemRequest
    {
        /**
         * Field: ItemName
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(200)]
        public string ItemName { get; set; }
        /**
         * Field: ItemCode
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(50)]
        public string ItemCode { get; set; }
        /**
         * Field: StockGroupId
         * Type: long
         * Description: Request property for StockItem
         */
        public long? StockGroupId { get; set; }
        /**
         * Field: Category
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        /**
         * Field: UnitOfMeasure
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(20)]
        public string UnitOfMeasure { get; set; }
        /**
         * Field: OpeningQty
         * Type: int
         * Description: Request property for StockItem
         */
        public int? OpeningQty { get; set; }
        /**
         * Field: PurchaseRate
         * Type: decimal
         * Description: Request property for StockItem
         */
        [Range(0, double.MaxValue)]
        public decimal? PurchaseRate { get; set; }
        /**
         * Field: SellingRate
         * Type: decimal
         * Description: Request property for StockItem
         */
        [Range(0, double.MaxValue)]
        public decimal? SellingRate { get; set; }
        /**
         * Field: ValuationMethod
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(50)]
        public string ValuationMethod { get; set; }
        /**
         * Field: ReorderLevel
         * Type: int
         * Description: Request property for StockItem
         */
        public int? ReorderLevel { get; set; }
        /**
         * Field: GstRate
         * Type: decimal
         * Description: Request property for StockItem
         */
        [Range(0, double.MaxValue)]
        public decimal? GstRate { get; set; }
        /**
         * Field: HsnSacCode
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(20)]
        public string HsnSacCode { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for StockItem
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for StockItem
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for StockItem
         */
        public DateTime? UpdatedAt { get; set; }

    }
}


