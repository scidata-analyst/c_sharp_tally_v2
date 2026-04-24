using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: Budget
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BudgetRequest
    {
        /**
         * Field: CostCenter
         * Type: string
         * Description: Request property for Budget
         */
        [Required]
        [MaxLength(100)]
        public string CostCenter { get; set; }
        /**
         * Field: AnnualBudget
         * Type: decimal
         * Description: Request property for Budget
         */
        [Range(0, double.MaxValue)]
        public decimal? AnnualBudget { get; set; }
        /**
         * Field: SpentYTD
         * Type: decimal
         * Description: Request property for Budget
         */
        [Range(0, double.MaxValue)]
        public decimal? SpentYTD { get; set; }
        /**
         * Field: Remaining
         * Type: decimal
         * Description: Request property for Budget
         */
        [Range(0, double.MaxValue)]
        public decimal? Remaining { get; set; }
        /**
         * Field: PercentageUsed
         * Type: decimal
         * Description: Request property for Budget
         */
        [Range(0, double.MaxValue)]
        public decimal? PercentageUsed { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for Budget
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for Budget
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for Budget
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for Budget
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

