using System;

namespace POS_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: Godown
     *
     * Purpose:
     * Used for Create/Update operations of Godown
     */
    public class GodownRequest
    {
        public string GodownName { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }
        public string Capacity { get; set; }
        public decimal UsedPercentage { get; set; }
        public decimal StockValue { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
