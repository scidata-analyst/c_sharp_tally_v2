using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.AdditionalFeatures
{
/**
 * =====================================================
 * ENTITY: AutomationRule
 * TABLE: automation_rule
 * MODULE: AdditionalFeatures
 * =====================================================
 *
 * Auto-generated EF Core Entity Model
 * Includes:
 * - Column mappings
 * - Data annotations
 * - Relationships
 *
 * Generated: 2026-04-17 21:45:33
 */

    [Table("automation_rule")]
    public class AutomationRule
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: RuleName
     * Type: string
     */
    [Column("RuleName")]
    [Required]
    [MaxLength(200)]
    public string RuleName { get; set; }

    /**
     * Column: RuleType
     * Type: string
     */
    [Column("RuleType")]
    [Required]
    [MaxLength(50)]
    public string RuleType { get; set; }

    /**
     * Column: Frequency
     * Type: string
     */
    [Column("Frequency")]
    [Required]
    [MaxLength(50)]
    public string Frequency { get; set; }

    /**
     * Column: NextRun
     * Type: DateTime
     */
    [Column("NextRun")]
    [Column(TypeName = "date")]
    public DateTime NextRun { get; set; }

    /**
     * Column: LastRun
     * Type: DateTime
     */
    [Column("LastRun")]
    [Column(TypeName = "date")]
    public DateTime LastRun { get; set; }

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    /**
     * Column: UpdatedAt
     * Type: DateTime
     */
    [Column("UpdatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }


    }
}
