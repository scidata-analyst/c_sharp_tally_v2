using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.BankingPayments
{
/**
 * =====================================================
 * ENTITY: PaymentReminder
 * TABLE: payment_reminder
 * MODULE: BankingPayments
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

    [Table("payment_reminder")]
    public class PaymentReminder
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

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
     * Column: InvoiceNumber
     * Type: string
     */
    [Column("InvoiceNumber")]
    [Required]
    [MaxLength(50)]
    public string InvoiceNumber { get; set; }

    /**
     * Column: Amount
     * Type: decimal
     */
    [Column("Amount")]
    public decimal Amount { get; set; }

    /**
     * Column: OverdueBy
     * Type: int
     */
    [Column("OverdueBy")]
    public int OverdueBy { get; set; }

    /**
     * Column: ReminderNumber
     * Type: string
     */
    [Column("ReminderNumber")]
    [Required]
    [MaxLength(20)]
    public string ReminderNumber { get; set; }

    /**
     * Column: LastSent
     * Type: DateTime
     */
    [Column("LastSent")]
    [Column(TypeName = "datetime")]
    public DateTime LastSent { get; set; }

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
     * Relationship: PartyDirectory
     * Foreign Key: PartyId
     */
    [ForeignKey("PartyId")]
    public PartyDirectory Party { get; set; }

    }
}
