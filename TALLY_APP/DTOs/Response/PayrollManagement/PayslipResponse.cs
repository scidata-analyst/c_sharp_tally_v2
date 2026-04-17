using System;

namespace POS_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: Payslip
     *
     * Purpose:
     * Used for API responses of Payslip
     */
    public class PayslipResponse
    {
        public long Id { get; set; }
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
