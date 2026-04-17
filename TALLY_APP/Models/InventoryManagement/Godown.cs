using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.InventoryManagement
{
/**
 * =====================================================
 * ENTITY: Godown
 * TABLE: godown
 * MODULE: InventoryManagement
 * =====================================================
 *
 * Auto-generated EF Core Entity Model
 * Includes:
 * - Column mappings
 * - Data annotations
 * - Relationships
 *
 * Generated: 2026-04-17 21:45:32
 */

    [Table("godown")]
    public class Godown
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: GodownName
     * Type: string
     */
    [Column("GodownName")]
    [Required]
    [MaxLength(200)]
    public string GodownName { get; set; }

    /**
     * Column: Location
     * Type: string
     */
    [Column("Location")]
    [Required]
    [MaxLength(200)]
    public string Location { get; set; }

    /**
     * Column: Manager
     * Type: string
     */
    [Column("Manager")]
    [Required]
    [MaxLength(100)]
    public string Manager { get; set; }

    /**
     * Column: Capacity
     * Type: string
     */
    [Column("Capacity")]
    [Required]
    [MaxLength(50)]
    public string Capacity { get; set; }

    /**
     * Column: UsedPercentage
     * Type: decimal
     */
    [Column("UsedPercentage")]
    public decimal UsedPercentage { get; set; }

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
