using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.PayrollManagement
{
/**
 * =====================================================
 * ENTITY: StatutoryDeduction
 * TABLE: statutory_deduction
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

    [Table("statutory_deduction")]
    public class StatutoryDeduction
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: DeductionType
     * Type: string
     */
    [Column("DeductionType")]
    [Required]
    [MaxLength(50)]
    public string DeductionType { get; set; }

    /**
     * Column: EmployeeId
     * Type: long
     */
    [Column("EmployeeId")]
    public long EmployeeId { get; set; }

    /**
     * Column: EmployeeContribution
     * Type: decimal
     */
    [Column("EmployeeContribution")]
    public decimal EmployeeContribution { get; set; }

    /**
     * Column: EmployerContribution
     * Type: decimal
     */
    [Column("EmployerContribution")]
    public decimal EmployerContribution { get; set; }

    /**
     * Column: TotalDeduction
     * Type: decimal
     */
    [Column("TotalDeduction")]
    public decimal TotalDeduction { get; set; }

    /**
     * Column: DueDate
     * Type: DateTime
     */
    [Column("DueDate")]
    [Column(TypeName = "date")]
    public DateTime DueDate { get; set; }

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


    /**
     * Relationship: Employee
     * Foreign Key: EmployeeId
     */
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }

    }
}
