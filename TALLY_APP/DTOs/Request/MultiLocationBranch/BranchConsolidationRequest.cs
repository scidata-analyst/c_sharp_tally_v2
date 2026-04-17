using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.MultiLocationBranch
{
    /**
     * Request DTO: BranchConsolidation
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BranchConsolidationRequest
    {
        /**
         * Field: BranchId
         * Type: long
         * Description: Request property for BranchConsolidation
         */
        public long BranchId { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for BranchConsolidation
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Request property for BranchConsolidation
         */
        [Range(0, double.MaxValue)]
        public decimal Revenue { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Request property for BranchConsolidation
         */
        [Range(0, double.MaxValue)]
        public decimal StockValue { get; set; }
        /**
         * Field: ConsolidatedAt
         * Type: DateTime
         * Description: Request property for BranchConsolidation
         */
        public DateTime ConsolidatedAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BranchConsolidation
         */
        public DateTime CreatedAt { get; set; }

    }
}
