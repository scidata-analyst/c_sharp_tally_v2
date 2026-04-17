using System;

namespace POS_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: AuditLog
     *
     * Purpose:
     * Used for API responses of AuditLog
     */
    public class AuditLogResponse
    {
        public long Id { get; set; }
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
