using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.RemoteAccessSecurity
{
/**
 * =====================================================
 * ENTITY: SystemUser
 * TABLE: system_user
 * MODULE: RemoteAccessSecurity
 * =====================================================
 *
 * Auto-generated EF Core Entity Model
 * Includes:
 * - Column mappings
 * - Data annotations
 * - Relationships
 *
 * Generated: 2026-04-17 21:45:33
 */

    [Table("system_user")]
    public class SystemUser
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: FullName
     * Type: string
     */
    [Column("FullName")]
    [Required]
    [MaxLength(200)]
    public string FullName { get; set; }

    /**
     * Column: Email
     * Type: string
     */
    [Column("Email")]
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    /**
     * Column: Role
     * Type: string
     */
    [Column("Role")]
    [Required]
    [MaxLength(50)]
    public string Role { get; set; }

    /**
     * Column: PasswordHash
     * Type: string
     */
    [Column("PasswordHash")]
    [Required]
    [MaxLength(500)]
    public string PasswordHash { get; set; }

    /**
     * Column: ModuleAccess
     * Type: string
     */
    [Column("ModuleAccess")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string ModuleAccess { get; set; }

    /**
     * Column: LastLogin
     * Type: DateTime
     */
    [Column("LastLogin")]
    [Column(TypeName = "datetime")]
    public DateTime LastLogin { get; set; }

    /**
     * Column: Status
     * Type: string
     */
    [Column("Status")]
    [Required]
    [MaxLength(20)]
    public string Status { get; set; }

    /**
     * Column: CreatedAt
     * Type: DateTime
     */
    [Column("CreatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    /**
     * Column: UpdatedAt
     * Type: DateTime
     */
    [Column("UpdatedAt")]
    [Column(TypeName = "datetime")]
    public DateTime UpdatedAt { get; set; }


    }
}
