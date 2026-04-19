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
namespace TALLY_APP.Models.AdditionalFeatures
{
/**
 * =====================================================
 * ENTITY: Budget
 * TABLE: budget
 * MODULE: AdditionalFeatures
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

    [Table("budget")]
    public class Budget
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: CostCenter
     * Type: string
     */
    [Column("CostCenter")]
    [Required]
    [MaxLength(100)]
    public string CostCenter { get; set; }

    /**
     * Column: AnnualBudget
     * Type: decimal
     */
    [Column("AnnualBudget")]
    public decimal AnnualBudget { get; set; }

    /**
     * Column: SpentYTD
     * Type: decimal
     */
    [Column("SpentYTD")]
    public decimal SpentYTD { get; set; }

    /**
     * Column: Remaining
     * Type: decimal
     */
    [Column("Remaining")]
    public decimal Remaining { get; set; }

    /**
     * Column: PercentageUsed
     * Type: decimal
     */
    [Column("PercentageUsed")]
    public decimal PercentageUsed { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

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



