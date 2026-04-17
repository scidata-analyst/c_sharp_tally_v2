using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.ReportingAnalytics
{
/**
 * =====================================================
 * ENTITY: TrialBalance
 * TABLE: trial_balance
 * MODULE: ReportingAnalytics
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

    [Table("trial_balance")]
    public class TrialBalance
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: AccountName
     * Type: string
     */
    [Column("AccountName")]
    [Required]
    [MaxLength(200)]
    public string AccountName { get; set; }

    /**
     * Column: GroupName
     * Type: string
     */
    [Column("GroupName")]
    [Required]
    [MaxLength(100)]
    public string GroupName { get; set; }

    /**
     * Column: OpeningDr
     * Type: decimal
     */
    [Column("OpeningDr")]
    public decimal OpeningDr { get; set; }

    /**
     * Column: OpeningCr
     * Type: decimal
     */
    [Column("OpeningCr")]
    public decimal OpeningCr { get; set; }

    /**
     * Column: TransactionDr
     * Type: decimal
     */
    [Column("TransactionDr")]
    public decimal TransactionDr { get; set; }

    /**
     * Column: TransactionCr
     * Type: decimal
     */
    [Column("TransactionCr")]
    public decimal TransactionCr { get; set; }

    /**
     * Column: ClosingDr
     * Type: decimal
     */
    [Column("ClosingDr")]
    public decimal ClosingDr { get; set; }

    /**
     * Column: ClosingCr
     * Type: decimal
     */
    [Column("ClosingCr")]
    public decimal ClosingCr { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}
