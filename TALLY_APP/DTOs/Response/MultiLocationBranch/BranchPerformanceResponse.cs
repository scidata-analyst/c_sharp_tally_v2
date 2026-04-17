using System;

namespace POS_APP.DTOs.Response.MultiLocationBranch
{
    /**
     * Response DTO: BranchPerformance
     *
     * Purpose:
     * Used for API responses of BranchPerformance
     */
    public class BranchPerformanceResponse
    {
        public long Id { get; set; }
        public string BranchName { get; set; }
        public decimal OpeningStock { get; set; }
        public decimal Received { get; set; }
        public decimal Sold { get; set; }
        public decimal ClosingStock { get; set; }
        public decimal Revenue { get; set; }
        public decimal Target { get; set; }
        public decimal AchievedPercentage { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
