using System;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: GSTReturn
     *
     * Purpose:
     * Used for Create/Update operations of GSTReturn
     */
    public class GSTReturnRequest
    {
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
