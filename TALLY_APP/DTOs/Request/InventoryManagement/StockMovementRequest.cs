using System;

namespace POS_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: StockMovement
     *
     * Purpose:
     * Used for Create/Update operations of StockMovement
     */
    public class StockMovementRequest
    {
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
