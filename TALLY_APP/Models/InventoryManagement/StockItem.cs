using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using TALLY_APP.Models.AccountingFinance;
using TALLY_APP.Models.InventoryManagement;
using TALLY_APP.Models.GSTTaxation;
using TALLY_APP.Models.PayrollManagement;
using TALLY_APP.Models.BankingPayments;
using TALLY_APP.Models.ReportingAnalytics;
using TALLY_APP.Models.MultiLocationBranch;
using TALLY_APP.Models.RemoteAccessSecurity;
using TALLY_APP.Models.AdditionalFeatures;
namespace TALLY_APP.Models.InventoryManagement
{
/**
 * =====================================================
 * ENTITY: StockItem
 * TABLE: stock_item
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

    [Table("stock_item")]
    public class StockItem
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: ItemName
     * Type: string
     */
    [Column("ItemName")]
    [Required]
    [MaxLength(200)]
    public string ItemName { get; set; }

    /**
     * Column: ItemCode
     * Type: string
     */
    [Column("ItemCode")]
    [Required]
    [MaxLength(50)]
    public string ItemCode { get; set; }

    /**
     * Column: StockGroupId
     * Type: long?
     */
    [Column("StockGroupId")]
    public long? StockGroupId { get; set; }

    /**
     * Column: Category
     * Type: string
     */
    [Column("Category")]
    [Required]
    [MaxLength(100)]
    public string Category { get; set; }

    /**
     * Column: UnitOfMeasure
     * Type: string
     */
    [Column("UnitOfMeasure")]
    [Required]
    [MaxLength(20)]
    public string UnitOfMeasure { get; set; }

    /**
     * Column: OpeningQty
     * Type: int
     */
    [Column("OpeningQty")]
    public int OpeningQty { get; set; }

    /**
     * Column: PurchaseRate
     * Type: decimal
     */
    [Column("PurchaseRate")]
    public decimal PurchaseRate { get; set; }

    /**
     * Column: SellingRate
     * Type: decimal
     */
    [Column("SellingRate")]
    public decimal SellingRate { get; set; }

    /**
     * Column: ValuationMethod
     * Type: string
     */
    [Column("ValuationMethod")]
    [Required]
    [MaxLength(50)]
    public string ValuationMethod { get; set; }

    /**
     * Column: ReorderLevel
     * Type: int
     */
    [Column("ReorderLevel")]
    public int ReorderLevel { get; set; }

    /**
     * Column: GstRate
     * Type: decimal
     */
    [Column("GstRate")]
    public decimal GstRate { get; set; }

    /**
     * Column: HsnSacCode
     * Type: string
     */
    [Column("HsnSacCode")]
    [Required]
    [MaxLength(20)]
    public string HsnSacCode { get; set; }

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
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    /**
     * Column: UpdatedAt
     * Type: DateTime
     */
    [Column("UpdatedAt", TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }


    /**
     * Relationship: StockGroup
     * Foreign Key: StockGroupId
     */
    [ForeignKey("StockGroupId")]
    public virtual StockGroup? StockGroup { get; set; }

    }
}



