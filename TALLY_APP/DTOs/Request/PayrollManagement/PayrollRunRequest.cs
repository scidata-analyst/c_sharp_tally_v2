using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: PayrollRun
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class PayrollRunRequest
    {
        /**
         * Field: Period
         * Type: string
         * Description: Request property for PayrollRun
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Request property for PayrollRun
         */
        public long EmployeeId { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal Allowances { get; set; }
        /**
         * Field: GrossSalary
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal GrossSalary { get; set; }
        /**
         * Field: PfDeduction
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal PfDeduction { get; set; }
        /**
         * Field: EsiDeduction
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal EsiDeduction { get; set; }
        /**
         * Field: TdsDeduction
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal TdsDeduction { get; set; }
        /**
         * Field: NetPay
         * Type: decimal
         * Description: Request property for PayrollRun
         */
        [Range(0, double.MaxValue)]
        public decimal NetPay { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for PayrollRun
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: ProcessedAt
         * Type: DateTime
         * Description: Request property for PayrollRun
         */
        public DateTime ProcessedAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for PayrollRun
         */
        public DateTime CreatedAt { get; set; }

    }
}
