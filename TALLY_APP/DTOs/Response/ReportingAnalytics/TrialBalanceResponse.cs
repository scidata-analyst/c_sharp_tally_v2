using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    public class TrialBalanceResponse
    {
        public long Id { get; set; }
        public string AccountName { get; set; }
        public string GroupName { get; set; }
        public decimal OpeningDr { get; set; }
        public decimal OpeningCr { get; set; }
        public decimal TransactionDr { get; set; }
        public decimal TransactionCr { get; set; }
        public decimal ClosingDr { get; set; }
        public decimal ClosingCr { get; set; }
        public string Period { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedTrialBalanceResponse
    {
        public List<TrialBalanceResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
