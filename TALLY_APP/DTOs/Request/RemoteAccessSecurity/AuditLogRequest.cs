using System;

namespace POS_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: AuditLog
     *
     * Purpose:
     * Used for Create/Update operations of AuditLog
     */
    public class AuditLogRequest
    {
        public DateTime Timestamp { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Record { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
