using System;

namespace POS_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: SecuritySettings
     *
     * Purpose:
     * Used for API responses of SecuritySettings
     */
    public class SecuritySettingsResponse
    {
        public long Id { get; set; }
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
