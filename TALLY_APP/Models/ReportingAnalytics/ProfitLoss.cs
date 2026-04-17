using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.ReportingAnalytics
{
/**
 * =====================================================
 * ENTITY: ProfitLoss
 * TABLE: profit_loss
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

    [Table("profit_loss")]
    public class ProfitLoss
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
     * Column: SalesRevenue
     * Type: decimal
     */
    [Column("SalesRevenue")]
    public decimal SalesRevenue { get; set; }

    /**
     * Column: OtherIncome
     * Type: decimal
     */
    [Column("OtherIncome")]
    public decimal OtherIncome { get; set; }

    /**
     * Column: GrossIncome
     * Type: decimal
     */
    [Column("GrossIncome")]
    public decimal GrossIncome { get; set; }

    /**
     * Column: CostOfGoodsSold
     * Type: decimal
     */
    [Column("CostOfGoodsSold")]
    public decimal CostOfGoodsSold { get; set; }

    /**
     * Column: EmployeeCosts
     * Type: decimal
     */
    [Column("EmployeeCosts")]
    public decimal EmployeeCosts { get; set; }

    /**
     * Column: AdminOverheads
     * Type: decimal
     */
    [Column("AdminOverheads")]
    public decimal AdminOverheads { get; set; }

    /**
     * Column: NetProfit
     * Type: decimal
     */
    [Column("NetProfit")]
    public decimal NetProfit { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}
