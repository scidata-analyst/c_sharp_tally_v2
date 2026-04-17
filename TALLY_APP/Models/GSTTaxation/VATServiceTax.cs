using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.GSTTaxation
{
/**
 * =====================================================
 * ENTITY: VATServiceTax
 * TABLE: vat_service_tax
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

    [Table("vat_service_tax")]
    public class VATServiceTax
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: TaxType
     * Type: string
     */
    [Column("TaxType")]
    [Required]
    [MaxLength(50)]
    public string TaxType { get; set; }

    /**
     * Column: OutputTax
     * Type: decimal
     */
    [Column("OutputTax")]
    public decimal OutputTax { get; set; }

    /**
     * Column: InputTax
     * Type: decimal
     */
    [Column("InputTax")]
    public decimal InputTax { get; set; }

    /**
     * Column: NetTaxPayable
     * Type: decimal
     */
    [Column("NetTaxPayable")]
    public decimal NetTaxPayable { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

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
