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
namespace TALLY_APP.Models.PayrollManagement
{
/**
 * =====================================================
 * ENTITY: Payslip
 * TABLE: payslip
 * MODULE: PayrollManagement
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

    [Table("payslip")]
    public class Payslip
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: EmployeeId
     * Type: long?
     */
    [Column("EmployeeId")]
    public long? EmployeeId { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: BasicSalary
     * Type: decimal
     */
    [Column("BasicSalary")]
    public decimal BasicSalary { get; set; }

    /**
     * Column: Hra
     * Type: decimal
     */
    [Column("Hra")]
    public decimal Hra { get; set; }

    /**
     * Column: Allowances
     * Type: decimal
     */
    [Column("Allowances")]
    public decimal Allowances { get; set; }

    /**
     * Column: GrossPay
     * Type: decimal
     */
    [Column("GrossPay")]
    public decimal GrossPay { get; set; }

    /**
     * Column: PfDeduction
     * Type: decimal
     */
    [Column("PfDeduction")]
    public decimal PfDeduction { get; set; }

    /**
     * Column: EsiDeduction
     * Type: decimal
     */
    [Column("EsiDeduction")]
    public decimal EsiDeduction { get; set; }

    /**
     * Column: NetPay
     * Type: decimal
     */
    [Column("NetPay")]
    public decimal NetPay { get; set; }

    /**
     * Column: PayslipData
     * Type: string
     */
    [Column("PayslipData", TypeName = "longtext")]
    [Required]
    public string PayslipData { get; set; }

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
     * Relationship: Employee
     * Foreign Key: EmployeeId
     */
    [ForeignKey("EmployeeId")]
    public virtual Employee? Employee { get; set; }

    }
}






