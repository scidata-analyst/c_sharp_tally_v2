using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: SystemUserResponse
     */
    public class SystemUserResponse
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string ModuleAccess { get; set; }
        public DateTime LastLogin { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PaginatedSystemUserResponse
    {
        public List<SystemUserResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}