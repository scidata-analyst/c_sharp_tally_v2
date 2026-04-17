using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: Budget
     *
     * Purpose:
     * Used for API responses of Budget
     */
    public class BudgetResponse
    {
        public long Id { get; set; }
        public string CostCenter { get; set; }
        public decimal AnnualBudget { get; set; }
        public decimal SpentYTD { get; set; }
        public decimal Remaining { get; set; }
        public decimal PercentageUsed { get; set; }
        public string Period { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
