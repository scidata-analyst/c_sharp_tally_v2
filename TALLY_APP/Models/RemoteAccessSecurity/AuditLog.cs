using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.RemoteAccessSecurity
{
/**
 * =====================================================
 * ENTITY: AuditLog
 * TABLE: audit_log
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

    [Table("audit_log")]
    public class AuditLog
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: Timestamp
     * Type: DateTime
     */
    [Column("Timestamp")]
    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    /**
     * Column: UserId
     * Type: long
     */
    [Column("UserId")]
    public long UserId { get; set; }

    /**
     * Column: UserName
     * Type: string
     */
    [Column("UserName")]
    [Required]
    [MaxLength(100)]
    public string UserName { get; set; }

    /**
     * Column: IpAddress
     * Type: string
     */
    [Column("IpAddress")]
    [Required]
    [MaxLength(50)]
    public string IpAddress { get; set; }

    /**
     * Column: Module
     * Type: string
     */
    [Column("Module")]
    [Required]
    [MaxLength(100)]
    public string Module { get; set; }

    /**
     * Column: Action
     * Type: string
     */
    [Column("Action")]
    [Required]
    [MaxLength(100)]
    public string Action { get; set; }

    /**
     * Column: Record
     * Type: string
     */
    [Column("Record")]
    [Required]
    [MaxLength(100)]
    public string Record { get; set; }

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
     * Relationship: SystemUser
     * Foreign Key: UserId
     */
    [ForeignKey("UserId")]
    public SystemUser User { get; set; }

    }
}
