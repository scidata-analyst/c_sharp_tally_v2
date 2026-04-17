using System;

namespace POS_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: PayrollRun
     *
     * Purpose:
     * Used for Create/Update operations of PayrollRun
     */
    public class PayrollRunRequest
    {
        public string Period { get; set; }
        public long EmployeeId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Hra { get; set; }
        public decimal Allowances { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal PfDeduction { get; set; }
        public decimal EsiDeduction { get; set; }
        public decimal TdsDeduction { get; set; }
        public decimal NetPay { get; set; }
        public string Status { get; set; }
        public DateTime ProcessedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
