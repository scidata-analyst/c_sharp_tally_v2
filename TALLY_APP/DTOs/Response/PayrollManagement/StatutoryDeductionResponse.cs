using System;

namespace TALLY_APP.DTOs.Response.PayrollManagement
{
    /**
     * Response DTO: StatutoryDeduction
     *
     * Purpose:
     * API response model for StatutoryDeduction
     */
    public class StatutoryDeductionResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for StatutoryDeduction
         */
        public long Id { get; set; }
        /**
         * Field: DeductionType
         * Type: string
         * Description: Response property for StatutoryDeduction
         */
        public string DeductionType { get; set; }
        /**
         * Field: EmployeeId
         * Type: long
         * Description: Response property for StatutoryDeduction
         */
        public long EmployeeId { get; set; }
        /**
         * Field: EmployeeContribution
         * Type: decimal
         * Description: Response property for StatutoryDeduction
         */
        public decimal EmployeeContribution { get; set; }
        /**
         * Field: EmployerContribution
         * Type: decimal
         * Description: Response property for StatutoryDeduction
         */
        public decimal EmployerContribution { get; set; }
        /**
         * Field: TotalDeduction
         * Type: decimal
         * Description: Response property for StatutoryDeduction
         */
        public decimal TotalDeduction { get; set; }
        /**
         * Field: DueDate
         * Type: DateTime
         * Description: Response property for StatutoryDeduction
         */
        public DateTime DueDate { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for StatutoryDeduction
         */
        public string Period { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for StatutoryDeduction
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for StatutoryDeduction
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for StatutoryDeduction
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedStatutoryDeductionResponse
     *
     * Purpose:
     * API response model for paginated statutory deduction list
     */
    public class PaginatedStatutoryDeductionResponse
    {
        public List<StatutoryDeductionResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
