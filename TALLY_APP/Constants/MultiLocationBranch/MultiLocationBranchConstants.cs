using System;

namespace TALLY_APP.Constants.MultiLocationBranch
{
    /**
     * @class MultiLocationBranchConstants
     * @description Contains all constant values for MultiLocationBranch module.
     *              Used to avoid magic strings across application.
     */
    public static class MultiLocationBranchConstants
    {

        /**
         * @constant Branch_TABLE
         * @description Database table name for Branch entity
         */
        public const string Branch_TABLE = "branch";

        /**
         * @constant Branch_ENTITY
         * @description Entity name reference for Branch
         */
        public const string Branch_ENTITY = "Branch";

        /**
         * @constant BranchConsolidation_TABLE
         * @description Database table name for BranchConsolidation entity
         */
        public const string BranchConsolidation_TABLE = "branch_consolidation";

        /**
         * @constant BranchConsolidation_ENTITY
         * @description Entity name reference for BranchConsolidation
         */
        public const string BranchConsolidation_ENTITY = "BranchConsolidation";

        /**
         * @constant BranchPerformance_TABLE
         * @description Database table name for BranchPerformance entity
         */
        public const string BranchPerformance_TABLE = "branch_performance";

        /**
         * @constant BranchPerformance_ENTITY
         * @description Entity name reference for BranchPerformance
         */
        public const string BranchPerformance_ENTITY = "BranchPerformance";

    }
}
