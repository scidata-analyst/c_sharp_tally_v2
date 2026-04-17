using System;

namespace POS_APP.DTOs.Request.MultiLocationBranch
{
    /**
     * Request DTO: Branch
     *
     * Purpose:
     * Used for Create/Update operations of Branch
     */
    public class BranchRequest
    {
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string CityLocation { get; set; }
        public string BranchManager { get; set; }
        public string Gstin { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Revenue { get; set; }
        public decimal StockValue { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
