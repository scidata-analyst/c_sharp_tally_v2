using System;

namespace TALLY_APP.DTOs.Response.MultiLocationBranch
{
    /**
     * Response DTO: BranchPerformance
     *
     * Purpose:
     * API response model for BranchPerformance
     */
    public class BranchPerformanceResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BranchPerformance
         */
        public long Id { get; set; }
        /**
         * Field: BranchName
         * Type: string
         * Description: Response property for BranchPerformance
         */
        public string BranchName { get; set; }
        /**
         * Field: OpeningStock
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal OpeningStock { get; set; }
        /**
         * Field: Received
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal Received { get; set; }
        /**
         * Field: Sold
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal Sold { get; set; }
        /**
         * Field: ClosingStock
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal ClosingStock { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal Revenue { get; set; }
        /**
         * Field: Target
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal Target { get; set; }
        /**
         * Field: AchievedPercentage
         * Type: decimal
         * Description: Response property for BranchPerformance
         */
        public decimal AchievedPercentage { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BranchPerformance
         */
        public DateTime CreatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedBranchPerformanceResponse
     *
     * Purpose:
     * API response model for paginated performance list
     */
    public class PaginatedBranchPerformanceResponse
    {
        public List<BranchPerformanceResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
