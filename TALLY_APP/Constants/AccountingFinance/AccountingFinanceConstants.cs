using System;

namespace TALLY_APP.Constants.AccountingFinance
{
    /**
     * @class AccountingFinanceConstants
     * @description Contains all constant values for AccountingFinance module.
     *              Used to avoid magic strings across application.
     */
    public static class AccountingFinanceConstants
    {

        /**
         * @constant LedgerAccount_TABLE
         * @description Database table name for LedgerAccount entity
         */
        public const string LedgerAccount_TABLE = "ledger_account";

        /**
         * @constant LedgerAccount_ENTITY
         * @description Entity name reference for LedgerAccount
         */
        public const string LedgerAccount_ENTITY = "LedgerAccount";

        /**
         * @constant VoucherEntry_TABLE
         * @description Database table name for VoucherEntry entity
         */
        public const string VoucherEntry_TABLE = "voucher_entry";

        /**
         * @constant VoucherEntry_ENTITY
         * @description Entity name reference for VoucherEntry
         */
        public const string VoucherEntry_ENTITY = "VoucherEntry";

        /**
         * @constant PartyDirectory_TABLE
         * @description Database table name for PartyDirectory entity
         */
        public const string PartyDirectory_TABLE = "party_directory";

        /**
         * @constant PartyDirectory_ENTITY
         * @description Entity name reference for PartyDirectory
         */
        public const string PartyDirectory_ENTITY = "PartyDirectory";

        /**
         * @constant BankAccount_TABLE
         * @description Database table name for BankAccount entity
         */
        public const string BankAccount_TABLE = "bank_account";

        /**
         * @constant BankAccount_ENTITY
         * @description Entity name reference for BankAccount
         */
        public const string BankAccount_ENTITY = "BankAccount";

        /**
         * @constant BankReconciliation_TABLE
         * @description Database table name for BankReconciliation entity
         */
        public const string BankReconciliation_TABLE = "bank_reconciliation";

        /**
         * @constant BankReconciliation_ENTITY
         * @description Entity name reference for BankReconciliation
         */
        public const string BankReconciliation_ENTITY = "BankReconciliation";

        /**
         * @constant CurrencyExchange_TABLE
         * @description Database table name for CurrencyExchange entity
         */
        public const string CurrencyExchange_TABLE = "currency_exchange";

        /**
         * @constant CurrencyExchange_ENTITY
         * @description Entity name reference for CurrencyExchange
         */
        public const string CurrencyExchange_ENTITY = "CurrencyExchange";

    }
}
