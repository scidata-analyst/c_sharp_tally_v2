using System;

namespace POS_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: StockGroup
     *
     * Purpose:
     * Used for Create/Update operations of StockGroup
     */
    public class StockGroupRequest
    {
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
