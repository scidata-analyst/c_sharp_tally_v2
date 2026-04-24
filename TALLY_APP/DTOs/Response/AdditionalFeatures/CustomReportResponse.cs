using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.AdditionalFeatures
{
    public class CustomReportResponse
    {
        public long Id { get; set; }
        public string ReportName { get; set; }
        public string Module { get; set; }
        public string Format { get; set; }
        public string QueryConfig { get; set; }
        public DateTime LastGenerated { get; set; }
        public string Schedule { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PaginatedCustomReportResponse
    {
        public List<CustomReportResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
