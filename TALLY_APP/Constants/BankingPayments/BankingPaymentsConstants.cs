using System;

namespace TALLY_APP.Constants.BankingPayments
{
    /**
     * @class BankingPaymentsConstants
     * @description Contains all constant values for BankingPayments module.
     *              Used to avoid magic strings across application.
     */
    public static class BankingPaymentsConstants
    {

        /**
         * @constant PaymentEntry_TABLE
         * @description Database table name for PaymentEntry entity
         */
        public const string PaymentEntry_TABLE = "payment_entry";

        /**
         * @constant PaymentEntry_ENTITY
         * @description Entity name reference for PaymentEntry
         */
        public const string PaymentEntry_ENTITY = "PaymentEntry";

        /**
         * @constant PaymentReminder_TABLE
         * @description Database table name for PaymentReminder entity
         */
        public const string PaymentReminder_TABLE = "payment_reminder";

        /**
         * @constant PaymentReminder_ENTITY
         * @description Entity name reference for PaymentReminder
         */
        public const string PaymentReminder_ENTITY = "PaymentReminder";

        /**
         * @constant BankIntegration_TABLE
         * @description Database table name for BankIntegration entity
         */
        public const string BankIntegration_TABLE = "bank_integration";

        /**
         * @constant BankIntegration_ENTITY
         * @description Entity name reference for BankIntegration
         */
        public const string BankIntegration_ENTITY = "BankIntegration";

    }
}
