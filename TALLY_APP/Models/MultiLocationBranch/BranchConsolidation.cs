using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.MultiLocationBranch
{
/**
 * =====================================================
 * ENTITY: BranchConsolidation
 * TABLE: branch_consolidation
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

    [Table("branch_consolidation")]
    public class BranchConsolidation
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: BranchId
     * Type: long
     */
    [Column("BranchId")]
    public long BranchId { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: Revenue
     * Type: decimal
     */
    [Column("Revenue")]
    public decimal Revenue { get; set; }

    /**
     * Column: StockValue
     * Type: decimal
     */
    [Column("StockValue")]
    public decimal StockValue { get; set; }

    /**
     * Column: ConsolidatedAt
     * Type: DateTime
     */
    [Column("ConsolidatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime ConsolidatedAt { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    /**
     * Relationship: Branch
     * Foreign Key: BranchId
     */
    [ForeignKey("BranchId")]
    public Branch Branch { get; set; }

    }
}
