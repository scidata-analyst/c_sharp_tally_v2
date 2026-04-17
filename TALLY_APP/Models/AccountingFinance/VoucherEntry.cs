using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    public string VoucherNumber { get; set; }

    /**
     * Column: VoucherType
     * Type: string
     */
    [Column("VoucherType")]
    [Required]
    [MaxLength(50)]
    public string VoucherType { get; set; }

    /**
     * Column: VoucherDate
     * Type: DateTime
     */
    [Column("VoucherDate")]
    [Column(TypeName = "date")]
    public DateTime VoucherDate { get; set; }

    /**
     * Column: PartyId
     * Type: long
     */
    [Column("PartyId")]
    public long PartyId { get; set; }

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
    public string PaymentMode { get; set; }

    /**
     * Column: BankAccountId
     * Type: long
     */
    [Column("BankAccountId")]
    public long BankAccountId { get; set; }

    /**
     * Column: ReferenceNumber
     * Type: string
     */
    [Column("ReferenceNumber")]
    [Required]
    [MaxLength(100)]
    public string ReferenceNumber { get; set; }

    /**
     * Column: Narration
     * Type: string
     */
    [Column("Narration")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Narration { get; set; }

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
     * Relationship: PartyDirectory
     * Foreign Key: PartyId
     */
    [ForeignKey("PartyId")]
    public PartyDirectory Party { get; set; }

    /**
     * Relationship: BankAccount
     * Foreign Key: BankAccountId
     */
    [ForeignKey("BankAccountId")]
    public BankAccount BankAccount { get; set; }

    }
}
