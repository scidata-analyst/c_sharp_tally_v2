using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.BankingPayments
{
/**
 * =====================================================
 * ENTITY: PaymentEntry
 * TABLE: payment_entry
 * MODULE: BankingPayments
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

    [Table("payment_entry")]
    public class PaymentEntry
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: ReferenceNumber
     * Type: string
     */
    [Column("ReferenceNumber")]
    [Required]
    [MaxLength(50)]
    public string ReferenceNumber { get; set; }

    /**
     * Column: PaymentDate
     * Type: DateTime
     */
    [Column("PaymentDate")]
    [Column(TypeName = "date")]
    public DateTime PaymentDate { get; set; }

    /**
     * Column: PaymentMode
     * Type: string
     */
    [Column("PaymentMode")]
    [Required]
    [MaxLength(50)]
    public string PaymentMode { get; set; }

    /**
     * Column: PartyId
     * Type: long
     */
    [Column("PartyId")]
    public long PartyId { get; set; }

    /**
     * Column: PartyName
     * Type: string
     */
    [Column("PartyName")]
    [Required]
    [MaxLength(200)]
    public string PartyName { get; set; }

    /**
     * Column: BankAccountId
     * Type: long
     */
    [Column("BankAccountId")]
    public long BankAccountId { get; set; }

    /**
     * Column: BankAccount
     * Type: string
     */
    [Column("BankAccount")]
    [Required]
    [MaxLength(100)]
    public string BankAccount { get; set; }

    /**
     * Column: ChequeRefNumber
     * Type: string
     */
    [Column("ChequeRefNumber")]
    [Required]
    [MaxLength(50)]
    public string ChequeRefNumber { get; set; }

    /**
     * Column: Amount
     * Type: decimal
     */
    [Column("Amount")]
    public decimal Amount { get; set; }

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
