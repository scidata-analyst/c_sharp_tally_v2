using System;

namespace POS_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: StatutoryDeduction
     *
     * Purpose:
     * Used for API responses of StatutoryDeduction
     */
    public class StatutoryDeductionResponse
    {
        public long Id { get; set; }
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
