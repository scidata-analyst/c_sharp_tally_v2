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
 * ENTITY: CurrencyExchange
 * TABLE: currency_exchange
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

    [Table("currency_exchange")]
    public class CurrencyExchange
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: CurrencyName
     * Type: string
     */
    [Column("CurrencyName")]
    [Required]
    [MaxLength(100)]
    public string CurrencyName { get; set; } = string.Empty;

    /**
     * Column: CurrencyCode
     * Type: string
     */
    [Column("CurrencyCode")]
    [Required]
    [MaxLength(10)]
    public string CurrencyCode { get; set; } = string.Empty;

    /**
     * Column: Symbol
     * Type: string
     */
    [Column("Symbol")]
    [Required]
    [MaxLength(10)]
    public string Symbol { get; set; } = string.Empty;

    /**
     * Column: BuyRate
     * Type: decimal
     */
    [Column("BuyRate")]
    public decimal BuyRate { get; set; }

    /**
     * Column: SellRate
     * Type: decimal
     */
    [Column("SellRate")]
    public decimal SellRate { get; set; }

    /**
     * Column: LastUpdated
     * Type: DateTime
     */
    [Column("LastUpdated", TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

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


    }
}



