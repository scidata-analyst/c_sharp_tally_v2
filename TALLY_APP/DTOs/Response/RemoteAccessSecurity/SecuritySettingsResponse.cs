using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: SecuritySettingsResponse
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

    public class PaginatedSecuritySettingsResponse
    {
        public List<SecuritySettingsResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}