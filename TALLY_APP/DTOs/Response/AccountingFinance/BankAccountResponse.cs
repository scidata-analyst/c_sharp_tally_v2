using System;

namespace TALLY_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: BankAccount
     *
     * Purpose:
     * API response model for BankAccount
     */
    public class BankAccountResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BankAccount
         */
        public long Id { get; set; }
        /**
         * Field: AccountName
         * Type: string
         * Description: Response property for BankAccount
         */
        public string AccountName { get; set; }
        /**
         * Field: AccountType
         * Type: string
         * Description: Response property for BankAccount
         */
        public string AccountType { get; set; }
        /**
         * Field: BankName
         * Type: string
         * Description: Response property for BankAccount
         */
        public string BankName { get; set; }
        /**
         * Field: AccountNumber
         * Type: string
         * Description: Response property for BankAccount
         */
        public string AccountNumber { get; set; }
        /**
         * Field: IfscCode
         * Type: string
         * Description: Response property for BankAccount
         */
        public string IfscCode { get; set; }
        /**
         * Field: OpeningBalance
         * Type: decimal
         * Description: Response property for BankAccount
         */
        public decimal OpeningBalance { get; set; }
        /**
         * Field: CurrentBalance
         * Type: decimal
         * Description: Response property for BankAccount
         */
        public decimal CurrentBalance { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for BankAccount
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BankAccount
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for BankAccount
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedBankAccountResponse
     *
     * Purpose:
     * API response model for paginated bank account list
     */
    public class PaginatedBankAccountResponse
    {
        public System.Collections.Generic.List<BankAccountResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
