using System;

namespace POS_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: AutomationRule
     *
     * Purpose:
     * Used for Create/Update operations of AutomationRule
     */
    public class AutomationRuleRequest
    {
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
