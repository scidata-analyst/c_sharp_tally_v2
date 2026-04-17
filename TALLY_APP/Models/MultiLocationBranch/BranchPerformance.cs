using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.MultiLocationBranch
{
/**
 * =====================================================
 * ENTITY: BranchPerformance
 * TABLE: branch_performance
 * MODULE: MultiLocationBranch
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

    [Table("branch_performance")]
    public class BranchPerformance
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: BranchName
     * Type: string
     */
    [Column("BranchName")]
    [Required]
    [MaxLength(200)]
    public string BranchName { get; set; }

    /**
     * Column: OpeningStock
     * Type: decimal
     */
    [Column("OpeningStock")]
    public decimal OpeningStock { get; set; }

    /**
     * Column: Received
     * Type: decimal
     */
    [Column("Received")]
    public decimal Received { get; set; }

    /**
     * Column: Sold
     * Type: decimal
     */
    [Column("Sold")]
    public decimal Sold { get; set; }

    /**
     * Column: ClosingStock
     * Type: decimal
     */
    [Column("ClosingStock")]
    public decimal ClosingStock { get; set; }

    /**
     * Column: Revenue
     * Type: decimal
     */
    [Column("Revenue")]
    public decimal Revenue { get; set; }

    /**
     * Column: Target
     * Type: decimal
     */
    [Column("Target")]
    public decimal Target { get; set; }

    /**
     * Column: AchievedPercentage
     * Type: decimal
     */
    [Column("AchievedPercentage")]
    public decimal AchievedPercentage { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}
