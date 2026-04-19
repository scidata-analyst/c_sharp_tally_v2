using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: StatutoryDeduction
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class StatutoryDeductionRequest
    {
        /**
         * Field: DeductionType
         * Type: string
         * Description: Request property for StatutoryDeduction
         */
        [Required]
        [MaxLength(50)]
        public string DeductionType { get; set; }
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Request property for StatutoryDeduction
         */
        public long EmployeeId { get; set; }
        /**
         * Field: EmployeeContribution
         * Type: decimal
         * Description: Request property for StatutoryDeduction
         */
        [Range(0, double.MaxValue)]
        public decimal EmployeeContribution { get; set; }
        /**
         * Field: EmployerContribution
         * Type: decimal
         * Description: Request property for StatutoryDeduction
         */
        [Range(0, double.MaxValue)]
        public decimal EmployerContribution { get; set; }
        /**
         * Field: TotalDeduction
         * Type: decimal
         * Description: Request property for StatutoryDeduction
         */
        [Range(0, double.MaxValue)]
        public decimal TotalDeduction { get; set; }
        /**
         * Field: DueDate
         * Type: DateTime
         * Description: Request property for StatutoryDeduction
         */
        public DateTime DueDate { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for StatutoryDeduction
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for StatutoryDeduction
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for StatutoryDeduction
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for StatutoryDeduction
         */
        public DateTime UpdatedAt { get; set; }

    }
}
