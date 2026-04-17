using System;

namespace TALLY_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: BankIntegration
     *
     * Purpose:
     * API response model for BankIntegration
     */
    public class BankIntegrationResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BankIntegration
         */
        public long Id { get; set; }
        /**
         * Field: BankName
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string BankName { get; set; }
        /**
         * Field: AccountType
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string AccountType { get; set; }
        /**
         * Field: AccountNumber
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string AccountNumber { get; set; }
        /**
         * Field: ApiKey
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string ApiKey { get; set; }
        /**
         * Field: ApiSecret
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string ApiSecret { get; set; }
        /**
         * Field: LastSync
         * Type: DateTime
         * Description: Response property for BankIntegration
         */
        public DateTime LastSync { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for BankIntegration
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BankIntegration
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for BankIntegration
         */
        public DateTime UpdatedAt { get; set; }

    }
}
