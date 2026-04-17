using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.RemoteAccessSecurity
{
    /**
     * Request DTO: SystemUser
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class SystemUserRequest
    {
        /**
         * Field: FullName
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; }
        /**
         * Field: Email
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        /**
         * Field: Role
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        [MaxLength(50)]
        public string Role { get; set; }
        /**
         * Field: PasswordHash
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        [MaxLength(500)]
        public string PasswordHash { get; set; }
        /**
         * Field: ModuleAccess
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        public string ModuleAccess { get; set; }
        /**
         * Field: LastLogin
         * Type: DateTime
         * Description: Request property for SystemUser
         */
        public DateTime LastLogin { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for SystemUser
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for SystemUser
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for SystemUser
         */
        public DateTime UpdatedAt { get; set; }

    }
}
