using System;

namespace POS_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: SystemUser
     *
     * Purpose:
     * Used for Create/Update operations of SystemUser
     */
    public class SystemUserRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PasswordHash { get; set; }
        public string ModuleAccess { get; set; }
        public DateTime LastLogin { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
