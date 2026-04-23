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
 * ENTITY: LedgerAccount
 * TABLE: ledger_account
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

    [Table("ledger_account")]
    public class LedgerAccount
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: LedgerName
     * Type: string
     */
    [Column("LedgerName")]
    [Required]
    [MaxLength(200)]
    public string LedgerName { get; set; } = string.Empty;

    /**
     * Column: LedgerCode
     * Type: string
     */
    [Column("LedgerCode")]
    [Required]
    [MaxLength(50)]
    public string LedgerCode { get; set; } = string.Empty;

    /**
     * Column: GroupName
     * Type: string
     */
    [Column("GroupName")]
    [Required]
    [MaxLength(100)]
    public string GroupName { get; set; } = string.Empty;

    /**
     * Column: AccountType
     * Type: string
     */
    [Column("AccountType")]
    [Required]
    [MaxLength(50)]
    public string AccountType { get; set; } = string.Empty;

    /**
     * Column: OpeningBalance
     * Type: decimal
     */
    [Column("OpeningBalance")]
    public decimal OpeningBalance { get; set; }

    /**
     * Column: BalanceType
     * Type: string
     */
    [Column("BalanceType")]
    [Required]
    [MaxLength(20)]
    public string BalanceType { get; set; } = string.Empty;

    /**
     * Column: Description
     * Type: string
     */
    [Column("Description", TypeName = "longtext")]
    [Required]
    public string Description { get; set; } = string.Empty;

    /**
     * Column: Currency
     * Type: string
     */
    [Column("Currency")]
    [Required]
    [MaxLength(10)]
    public string Currency { get; set; } = string.Empty;

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; } = string.Empty;

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
     * Column: ParentGroupId
     * Type: long? (Nullable for circular/root issues)
     */
    [Column("ParentGroupId")]
    public long? ParentGroupId { get; set; }

    /**
     * Relationship: LedgerAccount
     * Foreign Key: ParentGroupId
     */
    [ForeignKey("ParentGroupId")]
    public virtual LedgerAccount? ParentGroup { get; set; }

    }
}






