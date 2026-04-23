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
namespace TALLY_APP.Models.AccountingFinance
{
/**
 * =====================================================
 * ENTITY: BankReconciliation
 * TABLE: bank_reconciliation
 * MODULE: AccountingFinance
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

    [Table("bank_reconciliation")]
    public class BankReconciliation
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: BankAccountId
     * Type: long?
     */
    [Column("BankAccountId")]
    public long? BankAccountId { get; set; }

    /**
     * Column: StatementDate
     * Type: DateTime
     */
    [Column("StatementDate", TypeName = "date")]
    public DateTime StatementDate { get; set; }

    /**
     * Column: BankBalance
     * Type: decimal
     */
    [Column("BankBalance")]
    public decimal BankBalance { get; set; }

    /**
     * Column: BookBalance
     * Type: decimal
     */
    [Column("BookBalance")]
    public decimal BookBalance { get; set; }

    /**
     * Column: UnreconciledAmount
     * Type: decimal
     */
    [Column("UnreconciledAmount")]
    public decimal UnreconciledAmount { get; set; }

    /**
     * Column: PendingItems
     * Type: int
     */
    [Column("PendingItems")]
    public int PendingItems { get; set; }

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; } = string.Empty;

    /**
     * Column: ReconciledAt
     * Type: DateTime
     */
    [Column("ReconciledAt", TypeName = "datetime")]
    public DateTime ReconciledAt { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    /**
     * Relationship: BankAccount
     * Foreign Key: BankAccountId
     */
    [ForeignKey("BankAccountId")]
    public virtual BankAccount? BankAccount { get; set; }

    }
}



