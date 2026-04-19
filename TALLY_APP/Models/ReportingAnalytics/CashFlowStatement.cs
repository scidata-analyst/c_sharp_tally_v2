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
 * ENTITY: CashFlowStatement
 * TABLE: cash_flow_statement
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

    [Table("cash_flow_statement")]
    public class CashFlowStatement
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
     * Column: NetProfit
     * Type: decimal
     */
    [Column("NetProfit")]
    public decimal NetProfit { get; set; }

    /**
     * Column: Depreciation
     * Type: decimal
     */
    [Column("Depreciation")]
    public decimal Depreciation { get; set; }

    /**
     * Column: IncreaseInDebtors
     * Type: decimal
     */
    [Column("IncreaseInDebtors")]
    public decimal IncreaseInDebtors { get; set; }

    /**
     * Column: NetFromOperations
     * Type: decimal
     */
    [Column("NetFromOperations")]
    public decimal NetFromOperations { get; set; }

    /**
     * Column: PurchaseOfAssets
     * Type: decimal
     */
    [Column("PurchaseOfAssets")]
    public decimal PurchaseOfAssets { get; set; }

    /**
     * Column: NetCashFlow
     * Type: decimal
     */
    [Column("NetCashFlow")]
    public decimal NetCashFlow { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    }
}



