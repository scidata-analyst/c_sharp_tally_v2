using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: SecuritySettings
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class SecuritySettingsRequest
    {
        /**
         * Field: LastBackup
         * Type: DateTime
         * Description: Request property for SecuritySettings
         */
        public DateTime LastBackup { get; set; }
        /**
         * Field: BackupSchedule
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(50)]
        public string BackupSchedule { get; set; }
        /**
         * Field: CloudBackup
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(10)]
        public string CloudBackup { get; set; }
        /**
         * Field: TwoFactorAuth
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(10)]
        public string TwoFactorAuth { get; set; }
        /**
         * Field: Ssl
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(10)]
        public string Ssl { get; set; }
        /**
         * Field: EncryptionType
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(50)]
        public string EncryptionType { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for SecuritySettings
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for SecuritySettings
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for SecuritySettings
         */
        public DateTime UpdatedAt { get; set; }

    }
}
