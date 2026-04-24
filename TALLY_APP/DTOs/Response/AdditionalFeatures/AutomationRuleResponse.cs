using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.AdditionalFeatures
{
    public class AutomationRuleResponse
    {
        public long Id { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; }
        public string Frequency { get; set; }
        public DateTime NextRun { get; set; }
        public DateTime LastRun { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PaginatedAutomationRuleResponse
    {
        public List<AutomationRuleResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
