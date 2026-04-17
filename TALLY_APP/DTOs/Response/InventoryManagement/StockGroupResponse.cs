using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockGroup
     *
     * Purpose:
     * Used for API responses of StockGroup
     */
    public class StockGroupResponse
    {
        public long Id { get; set; }
        public string GroupName { get; set; }
        public string ParentGroup { get; set; }
        public int ItemsCount { get; set; }
        public string ValuationMethod { get; set; }
        public decimal TotalValue { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
