using System;

namespace POS_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: StatutoryDeduction
     *
     * Purpose:
     * Used for Create/Update operations of StatutoryDeduction
     */
    public class StatutoryDeductionRequest
    {
        public string DeductionType { get; set; }
        public long EmployeeId { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal TotalDeduction { get; set; }
        public DateTime DueDate { get; set; }
        public string Period { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
