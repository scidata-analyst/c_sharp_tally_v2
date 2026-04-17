using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.PayrollManagement
{
/**
 * =====================================================
 * ENTITY: PayrollRun
 * TABLE: payroll_run
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

    [Table("payroll_run")]
    public class PayrollRun
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: Period
     * Type: string
     */
    [Column("Period")]
    [Required]
    [MaxLength(20)]
    public string Period { get; set; }

    /**
     * Column: EmployeeId
     * Type: long
     */
    [Column("EmployeeId")]
    public long EmployeeId { get; set; }

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
     * Column: GrossSalary
     * Type: decimal
     */
    [Column("GrossSalary")]
    public decimal GrossSalary { get; set; }

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
     * Column: TdsDeduction
     * Type: decimal
     */
    [Column("TdsDeduction")]
    public decimal TdsDeduction { get; set; }

    /**
     * Column: NetPay
     * Type: decimal
     */
    [Column("NetPay")]
    public decimal NetPay { get; set; }

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; }

    /**
     * Column: ProcessedAt
     * Type: DateTime
     */
    [Column("ProcessedAt")]
    [Column(TypeName = "datetime")]
    public DateTime ProcessedAt { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }


    /**
     * Relationship: Employee
     * Foreign Key: EmployeeId
     */
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }

    }
}
