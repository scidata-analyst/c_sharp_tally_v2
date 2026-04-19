using System;

namespace TALLY_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: PayrollRun
     *
     * Purpose:
     * API response model for PayrollRun
     */
    public class PayrollRunResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for PayrollRun
         */
        public long Id { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for PayrollRun
         */
        public string Period { get; set; }
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Response property for PayrollRun
         */
        public long EmployeeId { get; set; }
        /**
         * Field: BasicSalary
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal BasicSalary { get; set; }
        /**
         * Field: Hra
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal Hra { get; set; }
        /**
         * Field: Allowances
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal Allowances { get; set; }
        /**
         * Field: GrossSalary
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal GrossSalary { get; set; }
        /**
         * Field: PfDeduction
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal PfDeduction { get; set; }
        /**
         * Field: EsiDeduction
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal EsiDeduction { get; set; }
        /**
         * Field: TdsDeduction
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal TdsDeduction { get; set; }
        /**
         * Field: NetPay
         * Type: decimal
         * Description: Response property for PayrollRun
         */
        public decimal NetPay { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for PayrollRun
         */
        public string Status { get; set; }
        /**
         * Field: ProcessedAt
         * Type: DateTime
         * Description: Response property for PayrollRun
         */
        public DateTime ProcessedAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for PayrollRun
         */
        public DateTime CreatedAt { get; set; }

    }
}
