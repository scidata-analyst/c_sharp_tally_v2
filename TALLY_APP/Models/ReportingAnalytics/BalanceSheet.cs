using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.ReportingAnalytics
{
/**
 * =====================================================
 * ENTITY: BalanceSheet
 * TABLE: balance_sheet
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

    [Table("balance_sheet")]
    public class BalanceSheet
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: ShareCapital
     * Type: decimal
     */
    [Column("ShareCapital")]
    public decimal ShareCapital { get; set; }

    /**
     * Column: ReservesSurplus
     * Type: decimal
     */
    [Column("ReservesSurplus")]
    public decimal ReservesSurplus { get; set; }

    /**
     * Column: SundryCreditors
     * Type: decimal
     */
    [Column("SundryCreditors")]
    public decimal SundryCreditors { get; set; }

    /**
     * Column: GstPayable
     * Type: decimal
     */
    [Column("GstPayable")]
    public decimal GstPayable { get; set; }

    /**
     * Column: TotalLiabilities
     * Type: decimal
     */
    [Column("TotalLiabilities")]
    public decimal TotalLiabilities { get; set; }

    /**
     * Column: FixedAssets
     * Type: decimal
     */
    [Column("FixedAssets")]
    public decimal FixedAssets { get; set; }

    /**
     * Column: StockInTrade
     * Type: decimal
     */
    [Column("StockInTrade")]
    public decimal StockInTrade { get; set; }

    /**
     * Column: SundryDebtors
     * Type: decimal
     */
    [Column("SundryDebtors")]
    public decimal SundryDebtors { get; set; }

    /**
     * Column: CashBank
     * Type: decimal
     */
    [Column("CashBank")]
    public decimal CashBank { get; set; }

    /**
     * Column: TotalAssets
     * Type: decimal
     */
    [Column("TotalAssets")]
    public decimal TotalAssets { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}
