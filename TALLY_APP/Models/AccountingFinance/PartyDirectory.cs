using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.AccountingFinance
{
/**
 * =====================================================
 * ENTITY: PartyDirectory
 * TABLE: party_directory
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

    [Table("party_directory")]
    public class PartyDirectory
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: PartyName
     * Type: string
     */
    [Column("PartyName")]
    [Required]
    [MaxLength(200)]
    public string PartyName { get; set; }

    /**
     * Column: PartyType
     * Type: string
     */
    [Column("PartyType")]
    [Required]
    [MaxLength(50)]
    public string PartyType { get; set; }

    /**
     * Column: Gstin
     * Type: string
     */
    [Column("Gstin")]
    [Required]
    [MaxLength(50)]
    public string Gstin { get; set; }

    /**
     * Column: PanNumber
     * Type: string
     */
    [Column("PanNumber")]
    [Required]
    [MaxLength(20)]
    public string PanNumber { get; set; }

    /**
     * Column: Phone
     * Type: string
     */
    [Column("Phone")]
    [Required]
    [MaxLength(20)]
    public string Phone { get; set; }

    /**
     * Column: Email
     * Type: string
     */
    [Column("Email")]
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    /**
     * Column: Address
     * Type: string
     */
    [Column("Address")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Address { get; set; }

    /**
     * Column: CreditLimit
     * Type: decimal
     */
    [Column("CreditLimit")]
    public decimal CreditLimit { get; set; }

    /**
     * Column: CreditPeriod
     * Type: int
     */
    [Column("CreditPeriod")]
    public int CreditPeriod { get; set; }

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


    }
}
