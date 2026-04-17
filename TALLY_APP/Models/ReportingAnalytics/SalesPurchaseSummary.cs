using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.ReportingAnalytics
{
/**
 * =====================================================
 * ENTITY: SalesPurchaseSummary
 * TABLE: sales_purchase_summary
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

    [Table("sales_purchase_summary")]
    public class SalesPurchaseSummary
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
     * Column: TotalSales
     * Type: decimal
     */
    [Column("TotalSales")]
    public decimal TotalSales { get; set; }

    /**
     * Column: TotalPurchases
     * Type: decimal
     */
    [Column("TotalPurchases")]
    public decimal TotalPurchases { get; set; }

    /**
     * Column: GrossMargin
     * Type: decimal
     */
    [Column("GrossMargin")]
    public decimal GrossMargin { get; set; }

    /**
     * Column: ReturnOnSales
     * Type: decimal
     */
    [Column("ReturnOnSales")]
    public decimal ReturnOnSales { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}
