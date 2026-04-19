using System;

namespace TALLY_APP.Constants.PayrollManagement
{
    /**
     * @class PayrollManagementConstants
     * @description Contains all constant values for PayrollManagement module.
     *              Used to avoid magic strings across application.
     */
    public static class PayrollManagementConstants
    {

        /**
         * @constant Employee_TABLE
         * @description Database table name for Employee entity
         */
        public const string Employee_TABLE = "employee";

        /**
         * @constant Employee_ENTITY
         * @description Entity name reference for Employee
         */
        public const string Employee_ENTITY = "Employee";

        /**
         * @constant PayrollRun_TABLE
         * @description Database table name for PayrollRun entity
         */
        public const string PayrollRun_TABLE = "payroll_run";

        /**
         * @constant PayrollRun_ENTITY
         * @description Entity name reference for PayrollRun
         */
        public const string PayrollRun_ENTITY = "PayrollRun";

        /**
         * @constant Payslip_TABLE
         * @description Database table name for Payslip entity
         */
        public const string Payslip_TABLE = "payslip";

        /**
         * @constant Payslip_ENTITY
         * @description Entity name reference for Payslip
         */
        public const string Payslip_ENTITY = "Payslip";

        /**
         * @constant StatutoryDeduction_TABLE
         * @description Database table name for StatutoryDeduction entity
         */
        public const string StatutoryDeduction_TABLE = "statutory_deduction";

        /**
         * @constant StatutoryDeduction_ENTITY
         * @description Entity name reference for StatutoryDeduction
         */
        public const string StatutoryDeduction_ENTITY = "StatutoryDeduction";

    }
}
