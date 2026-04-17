using System;

namespace TALLY_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: Employee
     *
     * Purpose:
     * API response model for Employee
     */
    public class EmployeeResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for Employee
         */
        public long Id { get; set; }
        /**
         * Field: FirstName
         * Type: string
         * Description: Response property for Employee
         */
        public string FirstName { get; set; }
        /**
         * Field: LastName
         * Type: string
         * Description: Response property for Employee
         */
        public string LastName { get; set; }
        /**
         * Field: EmployeeId
         * Type: string
         * Description: Response property for Employee
         */
        public string EmployeeId { get; set; }
        /**
         * Field: JoiningDate
         * Type: DateTime
         * Description: Response property for Employee
         */
        public DateTime JoiningDate { get; set; }
        /**
         * Field: Department
         * Type: string
         * Description: Response property for Employee
         */
        public string Department { get; set; }
        /**
         * Field: Designation
         * Type: string
         * Description: Response property for Employee
         */
        public string Designation { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Response property for Employee
         */
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Response property for Employee
         */
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Response property for Employee
         */
        public decimal Allowances { get; set; }
        /**
         * Field: GrossSalary
         * Type: decimal
         * Description: Response property for Employee
         */
        public decimal GrossSalary { get; set; }
        /**
         * Field: PanNumber
         * Type: string
         * Description: Response property for Employee
         */
        public string PanNumber { get; set; }
        /**
         * Field: AadharNumber
         * Type: string
         * Description: Response property for Employee
         */
        public string AadharNumber { get; set; }
        /**
         * Field: PfApplicable
         * Type: string
         * Description: Response property for Employee
         */
        public string PfApplicable { get; set; }
        /**
         * Field: EsiApplicable
         * Type: string
         * Description: Response property for Employee
         */
        public string EsiApplicable { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for Employee
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for Employee
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for Employee
         */
        public DateTime UpdatedAt { get; set; }

    }
}
