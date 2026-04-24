using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    public class SalesPurchaseSummaryResponse
    {
        public long Id { get; set; }
        public string Period { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalPurchases { get; set; }
        public decimal GrossMargin { get; set; }
        public decimal ReturnOnSales { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedSalesPurchaseSummaryResponse
    {
        public List<SalesPurchaseSummaryResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
