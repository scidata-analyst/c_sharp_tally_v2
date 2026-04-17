using System;

namespace POS_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: GSTReturn
     *
     * Purpose:
     * Used for API responses of GSTReturn
     */
    public class GSTReturnResponse
    {
        public long Id { get; set; }
        public string ReturnType { get; set; }
        public string Period { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalOutward { get; set; }
        public decimal TaxCollected { get; set; }
        public decimal TotalInward { get; set; }
        public decimal ItcAvailable { get; set; }
        public decimal NetPayable { get; set; }
        public string Status { get; set; }
        public DateTime FiledDate { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
