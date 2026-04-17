using System;

namespace TALLY_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: Budget
     *
     * Purpose:
     * API response model for Budget
     */
    public class BudgetResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for Budget
         */
        public long Id { get; set; }
        /**
         * Field: CostCenter
         * Type: string
         * Description: Response property for Budget
         */
        public string CostCenter { get; set; }
        /**
         * Field: AnnualBudget
         * Type: decimal
         * Description: Response property for Budget
         */
        public decimal AnnualBudget { get; set; }
        /**
         * Field: SpentYTD
         * Type: decimal
         * Description: Response property for Budget
         */
        public decimal SpentYTD { get; set; }
        /**
         * Field: Remaining
         * Type: decimal
         * Description: Response property for Budget
         */
        public decimal Remaining { get; set; }
        /**
         * Field: PercentageUsed
         * Type: decimal
         * Description: Response property for Budget
         */
        public decimal PercentageUsed { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for Budget
         */
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for Budget
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for Budget
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for Budget
         */
        public DateTime UpdatedAt { get; set; }

    }
}
