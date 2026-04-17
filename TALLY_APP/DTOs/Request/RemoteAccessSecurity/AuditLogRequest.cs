using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: AuditLog
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class AuditLogRequest
    {
        /**
         * Field: Timestamp
         * Type: DateTime
         * Description: Request property for AuditLog
         */
        public DateTime Timestamp { get; set; }
        /**
         * Field: UserId
         * Type: long
         * Description: Request property for AuditLog
         */
        public long UserId { get; set; }
        /**
         * Field: UserName
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        /**
         * Field: IpAddress
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(50)]
        public string IpAddress { get; set; }
        /**
         * Field: Module
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(100)]
        public string Module { get; set; }
        /**
         * Field: Action
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(100)]
        public string Action { get; set; }
        /**
         * Field: Record
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(100)]
        public string Record { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for AuditLog
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for AuditLog
         */
        public DateTime CreatedAt { get; set; }

    }
}
