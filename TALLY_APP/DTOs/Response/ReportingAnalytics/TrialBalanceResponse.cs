using System;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: TrialBalance
     *
     * Purpose:
     * API response model for TrialBalance
     */
    public class TrialBalanceResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for TrialBalance
         */
        public long Id { get; set; }
        /**
         * Field: AccountName
         * Type: string
         * Description: Response property for TrialBalance
         */
        public string AccountName { get; set; }
        /**
         * Field: GroupName
         * Type: string
         * Description: Response property for TrialBalance
         */
        public string GroupName { get; set; }
        /**
         * Field: OpeningDr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal OpeningDr { get; set; }
        /**
         * Field: OpeningCr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal OpeningCr { get; set; }
        /**
         * Field: TransactionDr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal TransactionDr { get; set; }
        /**
         * Field: TransactionCr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal TransactionCr { get; set; }
        /**
         * Field: ClosingDr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal ClosingDr { get; set; }
        /**
         * Field: ClosingCr
         * Type: decimal
         * Description: Response property for TrialBalance
         */
        public decimal ClosingCr { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for TrialBalance
         */
        public string Period { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for TrialBalance
         */
        public DateTime CreatedAt { get; set; }

    }
}
