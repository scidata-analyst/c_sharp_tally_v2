using System;

namespace POS_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: BatchRegister
     *
     * Purpose:
     * Used for API responses of BatchRegister
     */
    public class BatchRegisterResponse
    {
        public long Id { get; set; }
        public string BatchNumber { get; set; }
        public long ItemId { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public string SerialRange { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
