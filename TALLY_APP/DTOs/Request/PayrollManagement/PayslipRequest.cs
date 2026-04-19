using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: Payslip
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class PayslipRequest
    {
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Request property for Payslip
         */
        public long EmployeeId { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Request property for Payslip
         */
        [Required]
        [MaxLength(20)]
        public string Period { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal Allowances { get; set; }
        /**
         * Field: GrossPay
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal GrossPay { get; set; }
        /**
         * Field: PfDeduction
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal PfDeduction { get; set; }
        /**
         * Field: EsiDeduction
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal EsiDeduction { get; set; }
        /**
         * Field: NetPay
         * Type: decimal
         * Description: Request property for Payslip
         */
        [Range(0, double.MaxValue)]
        public decimal NetPay { get; set; }
        /**
         * Field: PayslipData
         * Type: string
         * Description: Request property for Payslip
         */
        [Required]
        public string PayslipData { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for Payslip
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for Payslip
         */
        public DateTime CreatedAt { get; set; }

    }
}
