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
    public string PartyName { get; set; } = string.Empty;

    /**
     * Column: PartyType
     * Type: string
     */
    [Column("PartyType")]
    [Required]
    [MaxLength(50)]
    public string PartyType { get; set; } = string.Empty;

    /**
     * Column: Gstin
     * Type: string
     */
    [Column("Gstin")]
    [Required]
    [MaxLength(50)]
    public string Gstin { get; set; } = string.Empty;

    /**
     * Column: PanNumber
     * Type: string
     */
    [Column("PanNumber")]
    [Required]
    [MaxLength(20)]
    public string PanNumber { get; set; } = string.Empty;

    /**
     * Column: Phone
     * Type: string
     */
    [Column("Phone")]
    [Required]
    [MaxLength(20)]
    public string Phone { get; set; } = string.Empty;

    /**
     * Column: Email
     * Type: string
     */
    [Column("Email")]
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    /**
     * Column: Address
     * Type: string
     */
    [Column("Address", TypeName = "longtext")]
    [Required]
    public string Address { get; set; } = string.Empty;

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






