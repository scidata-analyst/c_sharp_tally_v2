using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.GSTTaxation
{
/**
 * =====================================================
 * ENTITY: TDSTCSEntry
 * TABLE: tds_tcs_entry
 * MODULE: GSTTaxation
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

    [Table("tds_tcs_entry")]
    public class TDSTCSEntry
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: Section
     * Type: string
     */
    [Column("Section")]
    [Required]
    [MaxLength(20)]
    public string Section { get; set; }

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
     * Column: PanNumber
     * Type: string
     */
    [Column("PanNumber")]
    [Required]
    [MaxLength(20)]
    public string PanNumber { get; set; }

    /**
     * Column: PaymentAmount
     * Type: decimal
     */
    [Column("PaymentAmount")]
    public decimal PaymentAmount { get; set; }

    /**
     * Column: TdsRate
     * Type: decimal
     */
    [Column("TdsRate")]
    public decimal TdsRate { get; set; }

    /**
     * Column: TdsAmount
     * Type: decimal
     */
    [Column("TdsAmount")]
    public decimal TdsAmount { get; set; }

    /**
     * Column: CertificateNumber
     * Type: string
     */
    [Column("CertificateNumber")]
    [Required]
    [MaxLength(50)]
    public string CertificateNumber { get; set; }

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

    }
}
