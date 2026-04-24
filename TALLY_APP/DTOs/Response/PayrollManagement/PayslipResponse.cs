using System;

namespace TALLY_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: Payslip
     *
     * Purpose:
     * API response model for Payslip
     */
    public class PayslipResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for Payslip
         */
        public long Id { get; set; }
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Response property for Payslip
         */
        public long EmployeeId { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for Payslip
         */
        public string Period { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal Allowances { get; set; }
        /**
         * Field: GrossPay
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal GrossPay { get; set; }
        /**
         * Field: PfDeduction
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal PfDeduction { get; set; }
        /**
         * Field: EsiDeduction
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal EsiDeduction { get; set; }
        /**
         * Field: NetPay
         * Type: decimal
         * Description: Response property for Payslip
         */
        public decimal NetPay { get; set; }
        /**
         * Field: PayslipData
         * Type: string
         * Description: Response property for Payslip
         */
        public string PayslipData { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for Payslip
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for Payslip
         */
        public DateTime CreatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedPayslipResponse
     *
     * Purpose:
     * API response model for paginated payslip list
     */
    public class PaginatedPayslipResponse
    {
        public List<PayslipResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
