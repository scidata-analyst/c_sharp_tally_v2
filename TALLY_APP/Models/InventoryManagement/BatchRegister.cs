using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.InventoryManagement
{
/**
 * =====================================================
 * ENTITY: BatchRegister
 * TABLE: batch_register
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

    [Table("batch_register")]
    public class BatchRegister
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: BatchNumber
     * Type: string
     */
    [Column("BatchNumber")]
    [Required]
    [MaxLength(50)]
    public string BatchNumber { get; set; }

    /**
     * Column: ItemId
     * Type: long
     */
    [Column("ItemId")]
    public long ItemId { get; set; }

    /**
     * Column: ManufacturingDate
     * Type: DateTime
     */
    [Column("ManufacturingDate")]
    [Column(TypeName = "date")]
    public DateTime ManufacturingDate { get; set; }

    /**
     * Column: ExpiryDate
     * Type: DateTime
     */
    [Column("ExpiryDate")]
    [Column(TypeName = "date")]
    public DateTime ExpiryDate { get; set; }

    /**
     * Column: Quantity
     * Type: int
     */
    [Column("Quantity")]
    public int Quantity { get; set; }

    /**
     * Column: SerialRange
     * Type: string
     */
    [Column("SerialRange")]
    [Required]
    [MaxLength(100)]
    public string SerialRange { get; set; }

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


    /**
     * Relationship: StockItem
     * Foreign Key: ItemId
     */
    [ForeignKey("ItemId")]
    public StockItem StockItem { get; set; }

    }
}
