using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: AutomationRule
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class AutomationRuleRequest
    {
        /**
         * Field: RuleName
         * Type: string
         * Description: Request property for AutomationRule
         */
        [Required]
        [MaxLength(200)]
        public string RuleName { get; set; }
        /**
         * Field: RuleType
         * Type: string
         * Description: Request property for AutomationRule
         */
        [Required]
        [MaxLength(50)]
        public string RuleType { get; set; }
        /**
         * Field: Frequency
         * Type: string
         * Description: Request property for AutomationRule
         */
        [Required]
        [MaxLength(50)]
        public string Frequency { get; set; }
        /**
         * Field: NextRun
         * Type: DateTime
         * Description: Request property for AutomationRule
         */
        public DateTime? NextRun { get; set; }
        /**
         * Field: LastRun
         * Type: DateTime
         * Description: Request property for AutomationRule
         */
        public DateTime? LastRun { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for AutomationRule
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for AutomationRule
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for AutomationRule
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

