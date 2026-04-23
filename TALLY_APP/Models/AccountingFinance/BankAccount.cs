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
 * ENTITY: BankAccount
 * TABLE: bank_account
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

    [Table("bank_account")]
    public class BankAccount
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: AccountName
     * Type: string
     */
    [Column("AccountName")]
    [Required]
    [MaxLength(200)]
    public string AccountName { get; set; } = string.Empty;

    /**
     * Column: AccountType
     * Type: string
     */
    [Column("AccountType")]
    [Required]
    [MaxLength(50)]
    public string AccountType { get; set; } = string.Empty;

    /**
     * Column: BankName
     * Type: string
     */
    [Column("BankName")]
    [Required]
    [MaxLength(200)]
    public string BankName { get; set; } = string.Empty;

    /**
     * Column: AccountNumber
     * Type: string
     */
    [Column("AccountNumber")]
    [Required]
    [MaxLength(50)]
    public string AccountNumber { get; set; } = string.Empty;

    /**
     * Column: IfscCode
     * Type: string
     */
    [Column("IfscCode")]
    [Required]
    [MaxLength(20)]
    public string IfscCode { get; set; } = string.Empty;

    /**
     * Column: OpeningBalance
     * Type: decimal
     */
    [Column("OpeningBalance")]
    public decimal OpeningBalance { get; set; }

    /**
     * Column: CurrentBalance
     * Type: decimal
     */
    [Column("CurrentBalance")]
    public decimal CurrentBalance { get; set; }

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



