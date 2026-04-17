using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.InventoryManagement
{
/**
 * =====================================================
 * ENTITY: StockMovement
 * TABLE: stock_movement
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

    [Table("stock_movement")]
    public class StockMovement
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: ReferenceNumber
     * Type: string
     */
    [Column("ReferenceNumber")]
    [Required]
    [MaxLength(50)]
    public string ReferenceNumber { get; set; }

    /**
     * Column: MovementDate
     * Type: DateTime
     */
    [Column("MovementDate")]
    [Column(TypeName = "date")]
    public DateTime MovementDate { get; set; }

    /**
     * Column: MovementType
     * Type: string
     */
    [Column("MovementType")]
    [Required]
    [MaxLength(50)]
    public string MovementType { get; set; }

    /**
     * Column: ItemId
     * Type: long
     */
    [Column("ItemId")]
    public long ItemId { get; set; }

    /**
     * Column: FromGodownId
     * Type: long
     */
    [Column("FromGodownId")]
    public long FromGodownId { get; set; }

    /**
     * Column: ToGodownId
     * Type: long
     */
    [Column("ToGodownId")]
    public long ToGodownId { get; set; }

    /**
     * Column: Quantity
     * Type: int
     */
    [Column("Quantity")]
    public int Quantity { get; set; }

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
     * Relationship: StockItem
     * Foreign Key: ItemId
     */
    [ForeignKey("ItemId")]
    public StockItem StockItem { get; set; }

    /**
     * Relationship: Godown
     * Foreign Key: FromGodownId
     */
    [ForeignKey("FromGodownId")]
    public Godown FromGodown { get; set; }

    /**
     * Relationship: Godown
     * Foreign Key: ToGodownId
     */
    [ForeignKey("ToGodownId")]
    public Godown ToGodown { get; set; }

    }
}
