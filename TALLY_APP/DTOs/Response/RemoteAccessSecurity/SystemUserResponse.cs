using System;

namespace POS_APP.DTOs.Response.RemoteAccessSecurity
{
    /**
     * Response DTO: SystemUser
     *
     * Purpose:
     * API response model for SystemUser
     */
    public class SystemUserResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for SystemUser
         */
        public long Id { get; set; }
        /**
         * Field: FullName
         * Type: string
         * Description: Response property for SystemUser
         */
        public string FullName { get; set; }
        /**
         * Field: Email
         * Type: string
         * Description: Response property for SystemUser
         */
        public string Email { get; set; }
        /**
         * Field: Role
         * Type: string
         * Description: Response property for SystemUser
         */
        public string Role { get; set; }
        /**
         * Field: PasswordHash
         * Type: string
         * Description: Response property for SystemUser
         */
        public string PasswordHash { get; set; }
        /**
         * Field: ModuleAccess
         * Type: string
         * Description: Response property for SystemUser
         */
        public string ModuleAccess { get; set; }
        /**
         * Field: LastLogin
         * Type: DateTime
         * Description: Response property for SystemUser
         */
        public DateTime LastLogin { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for SystemUser
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for SystemUser
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for SystemUser
         */
        public DateTime UpdatedAt { get; set; }

    }
}
