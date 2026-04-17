using System;

namespace TALLY_APP.DTOs.Response.MultiLocationBranch
{
    /**
     * Response DTO: BranchConsolidation
     *
     * Purpose:
     * API response model for BranchConsolidation
     */
    public class BranchConsolidationResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BranchConsolidation
         */
        public long Id { get; set; }
        /**
         * Field: BranchId
         * Type: long
         * Description: Response property for BranchConsolidation
         */
        public long BranchId { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for BranchConsolidation
         */
        public string Period { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Response property for BranchConsolidation
         */
        public decimal Revenue { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Response property for BranchConsolidation
         */
        public decimal StockValue { get; set; }
        /**
         * Field: ConsolidatedAt
         * Type: DateTime
         * Description: Response property for BranchConsolidation
         */
        public DateTime ConsolidatedAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BranchConsolidation
         */
        public DateTime CreatedAt { get; set; }

    }
}
