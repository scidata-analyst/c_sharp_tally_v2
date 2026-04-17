using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: Employee
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class EmployeeRequest
    {
        /**
         * Field: FirstName
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        /**
         * Field: LastName
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        /**
         * Field: EmployeeId
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(50)]
        public string EmployeeId { get; set; }
        /**
         * Field: JoiningDate
         * Type: DateTime
         * Description: Request property for Employee
         */
        public DateTime JoiningDate { get; set; }
        /**
         * Field: Department
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(100)]
        public string Department { get; set; }
        /**
         * Field: Designation
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(100)]
        public string Designation { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Request property for Employee
         */
        [Range(0, double.MaxValue)]
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Request property for Employee
         */
        [Range(0, double.MaxValue)]
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Request property for Employee
         */
        [Range(0, double.MaxValue)]
        public decimal Allowances { get; set; }
        /**
         * Field: GrossSalary
         * Type: decimal
         * Description: Request property for Employee
         */
        [Range(0, double.MaxValue)]
        public decimal GrossSalary { get; set; }
        /**
         * Field: PanNumber
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(20)]
        public string PanNumber { get; set; }
        /**
         * Field: AadharNumber
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(20)]
        public string AadharNumber { get; set; }
        /**
         * Field: PfApplicable
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(10)]
        public string PfApplicable { get; set; }
        /**
         * Field: EsiApplicable
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(10)]
        public string EsiApplicable { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for Employee
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for Employee
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for Employee
         */
        public DateTime UpdatedAt { get; set; }

    }
}
