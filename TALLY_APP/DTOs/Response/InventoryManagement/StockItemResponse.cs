using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockItem
     *
     * Purpose:
     * API response model for StockItem
     */
    public class StockItemResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for StockItem
         */
        public long Id { get; set; }
        /**
         * Field: ItemName
         * Type: string
         * Description: Response property for StockItem
         */
        public string ItemName { get; set; }
        /**
         * Field: ItemCode
         * Type: string
         * Description: Response property for StockItem
         */
        public string ItemCode { get; set; }
        /**
         * Field: StockGroupId
         * Type: long
         * Description: Response property for StockItem
         */
        public long StockGroupId { get; set; }
        /**
         * Field: Category
         * Type: string
         * Description: Response property for StockItem
         */
        public string Category { get; set; }
        /**
         * Field: UnitOfMeasure
         * Type: string
         * Description: Response property for StockItem
         */
        public string UnitOfMeasure { get; set; }
        /**
         * Field: OpeningQty
         * Type: int
         * Description: Response property for StockItem
         */
        public int OpeningQty { get; set; }
        /**
         * Field: PurchaseRate
         * Type: decimal
         * Description: Response property for StockItem
         */
        public decimal PurchaseRate { get; set; }
        /**
         * Field: SellingRate
         * Type: decimal
         * Description: Response property for StockItem
         */
        public decimal SellingRate { get; set; }
        /**
         * Field: ValuationMethod
         * Type: string
         * Description: Response property for StockItem
         */
        public string ValuationMethod { get; set; }
        /**
         * Field: ReorderLevel
         * Type: int
         * Description: Response property for StockItem
         */
        public int ReorderLevel { get; set; }
        /**
         * Field: GstRate
         * Type: decimal
         * Description: Response property for StockItem
         */
        public decimal GstRate { get; set; }
        /**
         * Field: HsnSacCode
         * Type: string
         * Description: Response property for StockItem
         */
        public string HsnSacCode { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for StockItem
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for StockItem
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for StockItem
         */
        public DateTime UpdatedAt { get; set; }

    }
}
