using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    public class CashFlowStatementResponse
    {
        public long Id { get; set; }
        public string Period { get; set; }
        public decimal NetProfit { get; set; }
        public decimal Depreciation { get; set; }
        public decimal IncreaseInDebtors { get; set; }
        public decimal NetFromOperations { get; set; }
        public decimal PurchaseOfAssets { get; set; }
        public decimal NetCashFlow { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedCashFlowStatementResponse
    {
        public List<CashFlowStatementResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
