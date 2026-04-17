using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.GSTTaxation
{
/**
 * =====================================================
 * ENTITY: GSTEntry
 * TABLE: gst_entry
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

    [Table("gst_entry")]
    public class GSTEntry
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: InvoiceNumber
     * Type: string
     */
    [Column("InvoiceNumber")]
    [Required]
    [MaxLength(50)]
    public string InvoiceNumber { get; set; }

    /**
     * Column: InvoiceDate
     * Type: DateTime
     */
    [Column("InvoiceDate")]
    [Column(TypeName = "date")]
    public DateTime InvoiceDate { get; set; }

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
     * Column: TransactionType
     * Type: string
     */
    [Column("TransactionType")]
    [Required]
    [MaxLength(50)]
    public string TransactionType { get; set; }

    /**
     * Column: PartyGstin
     * Type: string
     */
    [Column("PartyGstin")]
    [Required]
    [MaxLength(50)]
    public string PartyGstin { get; set; }

    /**
     * Column: PlaceOfSupply
     * Type: string
     */
    [Column("PlaceOfSupply")]
    [Required]
    [MaxLength(100)]
    public string PlaceOfSupply { get; set; }

    /**
     * Column: TaxableAmount
     * Type: decimal
     */
    [Column("TaxableAmount")]
    public decimal TaxableAmount { get; set; }

    /**
     * Column: GstRate
     * Type: decimal
     */
    [Column("GstRate")]
    public decimal GstRate { get; set; }

    /**
     * Column: CgstAmount
     * Type: decimal
     */
    [Column("CgstAmount")]
    public decimal CgstAmount { get; set; }

    /**
     * Column: SgstAmount
     * Type: decimal
     */
    [Column("SgstAmount")]
    public decimal SgstAmount { get; set; }

    /**
     * Column: IgstAmount
     * Type: decimal
     */
    [Column("IgstAmount")]
    public decimal IgstAmount { get; set; }

    /**
     * Column: TotalTax
     * Type: decimal
     */
    [Column("TotalTax")]
    public decimal TotalTax { get; set; }

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
