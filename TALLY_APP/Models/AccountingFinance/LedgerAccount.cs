using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public string LedgerName { get; set; }

    /**
     * Column: LedgerCode
     * Type: string
     */
    [Column("LedgerCode")]
    [Required]
    [MaxLength(50)]
    public string LedgerCode { get; set; }

    /**
     * Column: GroupName
     * Type: string
     */
    [Column("GroupName")]
    [Required]
    [MaxLength(100)]
    public string GroupName { get; set; }

    /**
     * Column: AccountType
     * Type: string
     */
    [Column("AccountType")]
    [Required]
    [MaxLength(50)]
    public string AccountType { get; set; }

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
    public string BalanceType { get; set; }

    /**
     * Column: Description
     * Type: string
     */
    [Column("Description")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Description { get; set; }

    /**
     * Column: Currency
     * Type: string
     */
    [Column("Currency")]
    [Required]
    [MaxLength(10)]
    public string Currency { get; set; }

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
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    /**
     * Column: UpdatedAt
     * Type: DateTime
     */
    [Column("UpdatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }


    /**
     * Relationship: LedgerAccount
     * Foreign Key: ParentGroupId
     */
    [ForeignKey("ParentGroupId")]
    public LedgerAccount ParentGroup { get; set; }

    }
}
