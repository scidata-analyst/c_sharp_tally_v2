using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.AdditionalFeatures
{
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

    public class PaginatedBudgetResponse
    {
        public List<BudgetResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
