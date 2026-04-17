using System;

namespace POS_APP.DTOs.Response.MultiLocationBranch
{
    /**
     * Response DTO: BranchConsolidation
     *
     * Purpose:
     * Used for API responses of BranchConsolidation
     */
    public class BranchConsolidationResponse
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public string Period { get; set; }
        public decimal Revenue { get; set; }
        public decimal StockValue { get; set; }
        public DateTime ConsolidatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
