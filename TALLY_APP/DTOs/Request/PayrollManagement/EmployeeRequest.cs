using System;

namespace POS_APP.DTOs.Request.PayrollManagement
{
    /**
     * Request DTO: Employee
     *
     * Purpose:
     * Used for Create/Update operations of Employee
     */
    public class EmployeeRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Hra { get; set; }
        public decimal Allowances { get; set; }
        public decimal GrossSalary { get; set; }
        public string PanNumber { get; set; }
        public string AadharNumber { get; set; }
        public string PfApplicable { get; set; }
        public string EsiApplicable { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
