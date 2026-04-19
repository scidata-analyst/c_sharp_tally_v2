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
namespace TALLY_APP.Models.BankingPayments
{
/**
 * =====================================================
 * ENTITY: BankIntegration
 * TABLE: bank_integration
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

    [Table("bank_integration")]
    public class BankIntegration
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: BankName
     * Type: string
     */
    [Column("BankName")]
    [Required]
    [MaxLength(200)]
    public string BankName { get; set; }

    /**
     * Column: AccountType
     * Type: string
     */
    [Column("AccountType")]
    [Required]
    [MaxLength(50)]
    public string AccountType { get; set; }

    /**
     * Column: AccountNumber
     * Type: string
     */
    [Column("AccountNumber")]
    [Required]
    [MaxLength(50)]
    public string AccountNumber { get; set; }

    /**
     * Column: ApiKey
     * Type: string
     */
    [Column("ApiKey")]
    [Required]
    [MaxLength(500)]
    public string ApiKey { get; set; }

    /**
     * Column: ApiSecret
     * Type: string
     */
    [Column("ApiSecret")]
    [Required]
    [MaxLength(500)]
    public string ApiSecret { get; set; }

    /**
     * Column: LastSync
     * Type: DateTime
     */
    [Column("LastSync", TypeName = "datetime")]
    public DateTime LastSync { get; set; }

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



