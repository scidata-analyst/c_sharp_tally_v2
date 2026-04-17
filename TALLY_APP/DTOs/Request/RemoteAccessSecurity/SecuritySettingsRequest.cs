using System;

namespace POS_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: SecuritySettings
     *
     * Purpose:
     * Used for Create/Update operations of SecuritySettings
     */
    public class SecuritySettingsRequest
    {
        public DateTime LastBackup { get; set; }
        public string BackupSchedule { get; set; }
        public string CloudBackup { get; set; }
        public string TwoFactorAuth { get; set; }
        public string Ssl { get; set; }
        public string EncryptionType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
