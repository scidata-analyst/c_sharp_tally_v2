using System;

namespace POS_APP.DTOs.Request.MultiLocationBranch
{
    /**
     * Request DTO: BranchConsolidation
     *
     * Purpose:
     * Used for Create/Update operations of BranchConsolidation
     */
    public class BranchConsolidationRequest
    {
        public long BranchId { get; set; }
        public string Period { get; set; }
        public decimal Revenue { get; set; }
        public decimal StockValue { get; set; }
        public DateTime ConsolidatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
