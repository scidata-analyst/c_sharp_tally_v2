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
namespace TALLY_APP.Models.RemoteAccessSecurity
{
/**
 * =====================================================
 * ENTITY: SecuritySettings
 * TABLE: security_settings
 * MODULE: RemoteAccessSecurity
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

    [Table("security_settings")]
    public class SecuritySettings
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: LastBackup
     * Type: DateTime
     */
    [Column("LastBackup", TypeName = "datetime")]
    public DateTime LastBackup { get; set; }

    /**
     * Column: BackupSchedule
     * Type: string
     */
    [Column("BackupSchedule")]
    [Required]
    [MaxLength(50)]
    public string BackupSchedule { get; set; }

    /**
     * Column: CloudBackup
     * Type: string
     */
    [Column("CloudBackup")]
    [Required]
    [MaxLength(10)]
    public string CloudBackup { get; set; }

    /**
     * Column: TwoFactorAuth
     * Type: string
     */
    [Column("TwoFactorAuth")]
    [Required]
    [MaxLength(10)]
    public string TwoFactorAuth { get; set; }

    /**
     * Column: Ssl
     * Type: string
     */
    [Column("Ssl")]
    [Required]
    [MaxLength(10)]
    public string Ssl { get; set; }

    /**
     * Column: EncryptionType
     * Type: string
     */
    [Column("EncryptionType")]
    [Required]
    [MaxLength(50)]
    public string EncryptionType { get; set; }

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



