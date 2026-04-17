using System;

namespace POS_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: Payslip
     *
     * Purpose:
     * Used for Create/Update operations of Payslip
     */
    public class PayslipRequest
    {
        public long EmployeeId { get; set; }
        public string Period { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Hra { get; set; }
        public decimal Allowances { get; set; }
        public decimal GrossPay { get; set; }
        public decimal PfDeduction { get; set; }
        public decimal EsiDeduction { get; set; }
        public decimal NetPay { get; set; }
        public string PayslipData { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
