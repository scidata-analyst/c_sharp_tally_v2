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
namespace TALLY_APP.Models.ReportingAnalytics
{
/**
 * =====================================================
 * ENTITY: StockReport
 * TABLE: stock_report
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

    [Table("stock_report")]
    public class StockReport
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
     * Column: Category
     * Type: string
     */
    [Column("Category")]
    [Required]
    [MaxLength(100)]
    public string Category { get; set; }

    /**
     * Column: OpeningQty
     * Type: int
     */
    [Column("OpeningQty")]
    public int OpeningQty { get; set; }

    /**
     * Column: StockIn
     * Type: int
     */
    [Column("StockIn")]
    public int StockIn { get; set; }

    /**
     * Column: StockOut
     * Type: int
     */
    [Column("StockOut")]
    public int StockOut { get; set; }

    /**
     * Column: ClosingQty
     * Type: int
     */
    [Column("ClosingQty")]
    public int ClosingQty { get; set; }

    /**
     * Column: StockValue
     * Type: decimal
     */
    [Column("StockValue")]
    public decimal StockValue { get; set; }

    /**
     * Column: ReportDate
     * Type: DateTime
     */
    [Column("ReportDate", TypeName = "datetime")]
    public DateTime ReportDate { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}



