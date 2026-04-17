using System;

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
}
