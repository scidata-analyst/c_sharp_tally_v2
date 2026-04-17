using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockItem
     *
     * Purpose:
     * Used for API responses of StockItem
     */
    public class StockItemResponse
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public long StockGroupId { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasure { get; set; }
        public int OpeningQty { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellingRate { get; set; }
        public string ValuationMethod { get; set; }
        public int ReorderLevel { get; set; }
        public decimal GstRate { get; set; }
        public string HsnSacCode { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
