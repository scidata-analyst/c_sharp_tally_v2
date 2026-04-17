using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: Godown
     *
     * Purpose:
     * Used for API responses of Godown
     */
    public class GodownResponse
    {
        public long Id { get; set; }
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
