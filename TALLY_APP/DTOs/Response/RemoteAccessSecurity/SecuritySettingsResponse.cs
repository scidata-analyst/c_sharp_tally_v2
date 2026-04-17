using System;

namespace POS_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: SecuritySettings
     *
     * Purpose:
     * API response model for SecuritySettings
     */
    public class SecuritySettingsResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for SecuritySettings
         */
        public long Id { get; set; }
        /**
         * Field: LastBackup
         * Type: DateTime
         * Description: Response property for SecuritySettings
         */
        public DateTime LastBackup { get; set; }
        /**
         * Field: BackupSchedule
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string BackupSchedule { get; set; }
        /**
         * Field: CloudBackup
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string CloudBackup { get; set; }
        /**
         * Field: TwoFactorAuth
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string TwoFactorAuth { get; set; }
        /**
         * Field: Ssl
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string Ssl { get; set; }
        /**
         * Field: EncryptionType
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string EncryptionType { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for SecuritySettings
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for SecuritySettings
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for SecuritySettings
         */
        public DateTime UpdatedAt { get; set; }

    }
}
