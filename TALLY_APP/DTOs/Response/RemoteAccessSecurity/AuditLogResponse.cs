using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: AuditLogResponse
     */
    public class AuditLogResponse
    {
        public long Id { get; set; }
        public DateTime Timestamp { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Record { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedAuditLogResponse
    {
        public List<AuditLogResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}