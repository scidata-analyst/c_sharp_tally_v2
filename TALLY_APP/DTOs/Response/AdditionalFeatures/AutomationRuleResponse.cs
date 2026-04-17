using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: AutomationRule
     *
     * Purpose:
     * Used for API responses of AutomationRule
     */
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
}
