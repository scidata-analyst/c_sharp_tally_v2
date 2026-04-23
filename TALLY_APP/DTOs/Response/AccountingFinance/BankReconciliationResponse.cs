using System;

namespace TALLY_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: BankReconciliation
     *
     * Purpose:
     * API response model for BankReconciliation
     */
    public class BankReconciliationResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BankReconciliation
         */
        public long Id { get; set; }
        /**
         * Field: BankAccountId
         * Type: long
         * Description: Response property for BankReconciliation
         */
        public long BankAccountId { get; set; }
        /**
         * Field: StatementDate
         * Type: DateTime
         * Description: Response property for BankReconciliation
         */
        public DateTime StatementDate { get; set; }
        /**
         * Field: BankBalance
         * Type: decimal
         * Description: Response property for BankReconciliation
         */
        public decimal BankBalance { get; set; }
        /**
         * Field: BookBalance
         * Type: decimal
         * Description: Response property for BankReconciliation
         */
        public decimal BookBalance { get; set; }
        /**
         * Field: UnreconciledAmount
         * Type: decimal
         * Description: Response property for BankReconciliation
         */
        public decimal UnreconciledAmount { get; set; }
        /**
         * Field: PendingItems
         * Type: int
         * Description: Response property for BankReconciliation
         */
        public int PendingItems { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for BankReconciliation
         */
        public string Status { get; set; }
        /**
         * Field: ReconciledAt
         * Type: DateTime
         * Description: Response property for BankReconciliation
         */
        public DateTime ReconciledAt { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BankReconciliation
         */
        public DateTime CreatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedBankReconciliationResponse
     *
     * Purpose:
     * API response model for paginated bank reconciliation list
     */
    public class PaginatedBankReconciliationResponse
    {
        public System.Collections.Generic.List<BankReconciliationResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
