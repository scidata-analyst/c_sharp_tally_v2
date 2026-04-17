using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.PayrollManagement
{
/**
 * =====================================================
 * ENTITY: Employee
 * TABLE: employee
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

    [Table("employee")]
    public class Employee
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: FirstName
     * Type: string
     */
    [Column("FirstName")]
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    /**
     * Column: LastName
     * Type: string
     */
    [Column("LastName")]
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }

    /**
     * Column: EmployeeId
     * Type: string
     */
    [Column("EmployeeId")]
    [Required]
    [MaxLength(50)]
    public string EmployeeId { get; set; }

    /**
     * Column: JoiningDate
     * Type: DateTime
     */
    [Column("JoiningDate")]
    [Column(TypeName = "date")]
    public DateTime JoiningDate { get; set; }

    /**
     * Column: Department
     * Type: string
     */
    [Column("Department")]
    [Required]
    [MaxLength(100)]
    public string Department { get; set; }

    /**
     * Column: Designation
     * Type: string
     */
    [Column("Designation")]
    [Required]
    [MaxLength(100)]
    public string Designation { get; set; }

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
     * Column: PanNumber
     * Type: string
     */
    [Column("PanNumber")]
    [Required]
    [MaxLength(20)]
    public string PanNumber { get; set; }

    /**
     * Column: AadharNumber
     * Type: string
     */
    [Column("AadharNumber")]
    [Required]
    [MaxLength(20)]
    public string AadharNumber { get; set; }

    /**
     * Column: PfApplicable
     * Type: string
     */
    [Column("PfApplicable")]
    [Required]
    [MaxLength(10)]
    public string PfApplicable { get; set; }

    /**
     * Column: EsiApplicable
     * Type: string
     */
    [Column("EsiApplicable")]
    [Required]
    [MaxLength(10)]
    public string EsiApplicable { get; set; }

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
