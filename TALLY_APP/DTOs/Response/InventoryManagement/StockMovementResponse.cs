using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockMovement
     *
     * Purpose:
     * Used for API responses of StockMovement
     */
    public class StockMovementResponse
    {
        public long Id { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime MovementDate { get; set; }
        public string MovementType { get; set; }
        public long ItemId { get; set; }
        public long FromGodownId { get; set; }
        public long ToGodownId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
