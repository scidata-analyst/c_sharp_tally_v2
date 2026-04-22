using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: LedgerAccount
     *
     * Purpose:
     * API response model for LedgerAccount
     */
    public class LedgerAccountResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for LedgerAccount
         */
        public long Id { get; set; }
        /**
         * Field: LedgerName
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string LedgerName { get; set; }
        /**
         * Field: LedgerCode
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string LedgerCode { get; set; }
        /**
         * Field: GroupName
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string GroupName { get; set; }
        /**
         * Field: AccountType
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string AccountType { get; set; }
        /**
         * Field: OpeningBalance
         * Type: decimal
         * Description: Response property for LedgerAccount
         */
        public decimal OpeningBalance { get; set; }
        /**
         * Field: BalanceType
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string BalanceType { get; set; }
        /**
         * Field: Description
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string Description { get; set; }
        /**
         * Field: Currency
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string Currency { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for LedgerAccount
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for LedgerAccount
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for LedgerAccount
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedLedgerResponse
     *
     * Purpose:
     * API response model for paginated ledger list
     */
    public class PaginatedLedgerResponse
    {
        /**
         * Field: Data
         * Type: List<LedgerAccountResponse>
         * Description: List of ledger accounts
         */
        public List<LedgerAccountResponse> Data { get; set; }

        /**
         * Field: TotalCount
         * Type: int
         * Description: Total number of records
         */
        public int TotalCount { get; set; }

        /**
         * Field: Page
         * Type: int
         * Description: Current page number
         */
        public int Page { get; set; }

        /**
         * Field: PageSize
         * Type: int
         * Description: Number of records per page
         */
        public int PageSize { get; set; }

        /**
         * Field: TotalPages
         * Type: int
         * Description: Total number of pages
         */
        public int TotalPages { get; set; }

        /**
         * Field: HasPreviousPage
         * Type: bool
         * Description: Whether previous page exists
         */
        public bool HasPreviousPage { get; set; }

        /**
         * Field: HasNextPage
         * Type: bool
         * Description: Whether next page exists
         */
        public bool HasNextPage { get; set; }
    }
}
