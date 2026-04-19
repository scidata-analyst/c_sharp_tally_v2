using System;

namespace TALLY_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: AuditLog
     *
     * Purpose:
     * API response model for AuditLog
     */
    public class AuditLogResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for AuditLog
         */
        public long Id { get; set; }
        /**
         * Field: Timestamp
         * Type: DateTime
         * Description: Response property for AuditLog
         */
        public DateTime Timestamp { get; set; }
        /**
         * Field: UserId
         * Type: long
         * Description: Response property for AuditLog
         */
        public long UserId { get; set; }
        /**
         * Field: UserName
         * Type: string
         * Description: Response property for AuditLog
         */
        public string UserName { get; set; }
        /**
         * Field: IpAddress
         * Type: string
         * Description: Response property for AuditLog
         */
        public string IpAddress { get; set; }
        /**
         * Field: Module
         * Type: string
         * Description: Response property for AuditLog
         */
        public string Module { get; set; }
        /**
         * Field: Action
         * Type: string
         * Description: Response property for AuditLog
         */
        public string Action { get; set; }
        /**
         * Field: Record
         * Type: string
         * Description: Response property for AuditLog
         */
        public string Record { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for AuditLog
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for AuditLog
         */
        public DateTime CreatedAt { get; set; }

    }
}
