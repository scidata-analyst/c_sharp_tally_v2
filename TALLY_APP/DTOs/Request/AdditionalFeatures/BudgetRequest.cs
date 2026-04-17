using System;

namespace POS_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: Budget
     *
     * Purpose:
     * Used for Create/Update operations of Budget
     */
    public class BudgetRequest
    {
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
