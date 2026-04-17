using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.AdditionalFeatures
{
/**
 * =====================================================
 * ENTITY: CustomReport
 * TABLE: custom_report
 * MODULE: AdditionalFeatures
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

    [Table("custom_report")]
    public class CustomReport
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: ReportName
     * Type: string
     */
    [Column("ReportName")]
    [Required]
    [MaxLength(200)]
    public string ReportName { get; set; }

    /**
     * Column: Module
     * Type: string
     */
    [Column("Module")]
    [Required]
    [MaxLength(100)]
    public string Module { get; set; }

    /**
     * Column: Format
     * Type: string
     */
    [Column("Format")]
    [Required]
    [MaxLength(20)]
    public string Format { get; set; }

    /**
     * Column: QueryConfig
     * Type: string
     */
    [Column("QueryConfig")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string QueryConfig { get; set; }

    /**
     * Column: LastGenerated
     * Type: DateTime
     */
    [Column("LastGenerated")]
    [Column(TypeName = "datetime")]
    public DateTime LastGenerated { get; set; }

    /**
     * Column: Schedule
     * Type: string
     */
    [Column("Schedule")]
    [Required]
    [MaxLength(50)]
    public string Schedule { get; set; }

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
