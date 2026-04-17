using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: AutomationRule
     *
     * Purpose:
     * API response model for AutomationRule
     */
    public class AutomationRuleResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for AutomationRule
         */
        public long Id { get; set; }
        /**
         * Field: RuleName
         * Type: string
         * Description: Response property for AutomationRule
         */
        public string RuleName { get; set; }
        /**
         * Field: RuleType
         * Type: string
         * Description: Response property for AutomationRule
         */
        public string RuleType { get; set; }
        /**
         * Field: Frequency
         * Type: string
         * Description: Response property for AutomationRule
         */
        public string Frequency { get; set; }
        /**
         * Field: NextRun
         * Type: DateTime
         * Description: Response property for AutomationRule
         */
        public DateTime NextRun { get; set; }
        /**
         * Field: LastRun
         * Type: DateTime
         * Description: Response property for AutomationRule
         */
        public DateTime LastRun { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for AutomationRule
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for AutomationRule
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for AutomationRule
         */
        public DateTime UpdatedAt { get; set; }

    }
}
