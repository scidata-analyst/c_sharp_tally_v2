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
 * ENTITY: VoucherEntry
 * TABLE: voucher_entry
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

    [Table("voucher_entry")]
    public class VoucherEntry
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: VoucherNumber
     * Type: string
     */
    [Column("VoucherNumber")]
    [Required]
    [MaxLength(50)]
    public string VoucherNumber { get; set; } = string.Empty;

    /**
     * Column: VoucherType
     * Type: string
     */
    [Column("VoucherType")]
    [Required]
    [MaxLength(50)]
    public string VoucherType { get; set; } = string.Empty;

    /**
     * Column: VoucherDate
     * Type: DateTime
     */
    [Column("VoucherDate", TypeName = "date")]
    public DateTime VoucherDate { get; set; }

    /**
     * Column: PartyId
     * Type: long?
     */
    [Column("PartyId")]
    public long? PartyId { get; set; }

    /**
     * Column: Amount
     * Type: decimal
     */
    [Column("Amount")]
    public decimal Amount { get; set; }

    /**
     * Column: PaymentMode
     * Type: string
     */
    [Column("PaymentMode")]
    [Required]
    [MaxLength(50)]
    public string PaymentMode { get; set; } = string.Empty;

    /**
     * Column: BankAccountId
     * Type: long?
     */
    [Column("BankAccountId")]
    public long? BankAccountId { get; set; }

    /**
     * Column: ReferenceNumber
     * Type: string
     */
    [Column("ReferenceNumber")]
    [Required]
    [MaxLength(100)]
    public string ReferenceNumber { get; set; } = string.Empty;

    /**
     * Column: Narration
     * Type: string
     */
    [Column("Narration", TypeName = "longtext")]
    [Required]
    public string Narration { get; set; } = string.Empty;

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
     * Relationship: PartyDirectory
     * Foreign Key: PartyId
     */
    [ForeignKey("PartyId")]
    public virtual PartyDirectory? Party { get; set; }

    /**
     * Relationship: BankAccount
     * Foreign Key: BankAccountId
     */
    [ForeignKey("BankAccountId")]
    public virtual BankAccount? BankAccount { get; set; }

    }
}






