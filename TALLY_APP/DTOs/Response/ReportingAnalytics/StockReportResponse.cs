using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    public class StockReportResponse
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int OpeningQty { get; set; }
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public int ClosingQty { get; set; }
        public decimal StockValue { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedStockReportResponse
    {
        public List<StockReportResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
