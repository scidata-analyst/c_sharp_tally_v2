using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.AdditionalFeatures
{
/**
 * =====================================================
 * ENTITY: ForexTransaction
 * TABLE: forex_transaction
 * MODULE: AdditionalFeatures
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

    [Table("forex_transaction")]
    public class ForexTransaction
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
     * Column: TransactionDate
     * Type: DateTime
     */
    [Column("TransactionDate")]
    [Column(TypeName = "date")]
    public DateTime TransactionDate { get; set; }

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
     * Column: CurrencyId
     * Type: long
     */
    [Column("CurrencyId")]
    public long CurrencyId { get; set; }

    /**
     * Column: Currency
     * Type: string
     */
    [Column("Currency")]
    [Required]
    [MaxLength(10)]
    public string Currency { get; set; }

    /**
     * Column: ForeignAmount
     * Type: decimal
     */
    [Column("ForeignAmount")]
    public decimal ForeignAmount { get; set; }

    /**
     * Column: ExchangeRate
     * Type: decimal
     */
    [Column("ExchangeRate")]
    public decimal ExchangeRate { get; set; }

    /**
     * Column: InrAmount
     * Type: decimal
     */
    [Column("InrAmount")]
    public decimal InrAmount { get; set; }

    /**
     * Column: ForexGainLoss
     * Type: decimal
     */
    [Column("ForexGainLoss")]
    public decimal ForexGainLoss { get; set; }

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

    /**
     * Relationship: CurrencyExchange
     * Foreign Key: CurrencyId
     */
    [ForeignKey("CurrencyId")]
    public CurrencyExchange Currency { get; set; }

    }
}
