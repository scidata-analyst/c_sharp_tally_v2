using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.MultiLocationBranch
{
    /**
     * Request DTO: BranchPerformance
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BranchPerformanceRequest
    {
        /**
         * Field: BranchName
         * Type: string
         * Description: Request property for BranchPerformance
         */
        [Required]
        [MaxLength(200)]
        public string BranchName { get; set; }
        /**
         * Field: OpeningStock
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal OpeningStock { get; set; }
        /**
         * Field: Received
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal Received { get; set; }
        /**
         * Field: Sold
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal Sold { get; set; }
        /**
         * Field: ClosingStock
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal ClosingStock { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal Revenue { get; set; }
        /**
         * Field: Target
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal Target { get; set; }
        /**
         * Field: AchievedPercentage
         * Type: decimal
         * Description: Request property for BranchPerformance
         */
        [Range(0, double.MaxValue)]
        public decimal AchievedPercentage { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BranchPerformance
         */
        public DateTime CreatedAt { get; set; }

    }
}
