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
 * ENTITY: StockGroup
 * TABLE: stock_group
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

    [Table("stock_group")]
    public class StockGroup
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: GroupName
     * Type: string
     */
    [Column("GroupName")]
    [Required]
    [MaxLength(200)]
    public string GroupName { get; set; }

    /**
     * Column: ParentGroup
     * Type: string
     */
    [Column("ParentGroup")]
    [Required]
    [MaxLength(100)]
    public string ParentGroup { get; set; }

    /**
     * Column: ItemsCount
     * Type: int
     */
    [Column("ItemsCount")]
    public int ItemsCount { get; set; }

    /**
     * Column: ValuationMethod
     * Type: string
     */
    [Column("ValuationMethod")]
    [Required]
    [MaxLength(50)]
    public string ValuationMethod { get; set; }

    /**
     * Column: TotalValue
     * Type: decimal
     */
    [Column("TotalValue")]
    public decimal TotalValue { get; set; }

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


    }
}



