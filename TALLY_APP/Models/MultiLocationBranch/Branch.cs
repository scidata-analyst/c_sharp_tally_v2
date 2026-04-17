using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.MultiLocationBranch
{
/**
 * =====================================================
 * ENTITY: Branch
 * TABLE: branch
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

    [Table("branch")]
    public class Branch
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
     * Column: BranchCode
     * Type: string
     */
    [Column("BranchCode")]
    [Required]
    [MaxLength(50)]
    public string BranchCode { get; set; }

    /**
     * Column: CityLocation
     * Type: string
     */
    [Column("CityLocation")]
    [Required]
    [MaxLength(100)]
    public string CityLocation { get; set; }

    /**
     * Column: BranchManager
     * Type: string
     */
    [Column("BranchManager")]
    [Required]
    [MaxLength(100)]
    public string BranchManager { get; set; }

    /**
     * Column: Gstin
     * Type: string
     */
    [Column("Gstin")]
    [Required]
    [MaxLength(50)]
    public string Gstin { get; set; }

    /**
     * Column: Phone
     * Type: string
     */
    [Column("Phone")]
    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    /**
     * Column: Address
     * Type: string
     */
    [Column("Address")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Address { get; set; }

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
