using System;

namespace TALLY_APP.Constants.RemoteAccessSecurity
{
    /**
     * @class RemoteAccessSecurityConstants
     * @description Contains all constant values for RemoteAccessSecurity module.
     *              Used to avoid magic strings across application.
     */
    public static class RemoteAccessSecurityConstants
    {

        /**
         * @constant SystemUser_TABLE
         * @description Database table name for SystemUser entity
         */
        public const string SystemUser_TABLE = "system_user";

        /**
         * @constant SystemUser_ENTITY
         * @description Entity name reference for SystemUser
         */
        public const string SystemUser_ENTITY = "SystemUser";

        /**
         * @constant AuditLog_TABLE
         * @description Database table name for AuditLog entity
         */
        public const string AuditLog_TABLE = "audit_log";

        /**
         * @constant AuditLog_ENTITY
         * @description Entity name reference for AuditLog
         */
        public const string AuditLog_ENTITY = "AuditLog";

        /**
         * @constant SecuritySettings_TABLE
         * @description Database table name for SecuritySettings entity
         */
        public const string SecuritySettings_TABLE = "security_settings";

        /**
         * @constant SecuritySettings_ENTITY
         * @description Entity name reference for SecuritySettings
         */
        public const string SecuritySettings_ENTITY = "SecuritySettings";

    }
}
