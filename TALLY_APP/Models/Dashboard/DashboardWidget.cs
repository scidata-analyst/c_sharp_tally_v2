using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TALLY_APP.Models.Dashboard
{
/**
 * =====================================================
 * ENTITY: DashboardWidget
 * TABLE: dashboard_widget
 * MODULE: Dashboard
 * =====================================================
 *
 * Auto-generated EF Core Entity Model
 * Includes:
 * - Column mappings
 * - Data annotations
 * - Relationships
 *
 * Generated: 2026-04-17 21:45:32
 */

    [Table("dashboard_widget")]
    public class DashboardWidget
    {


    /**
     * Column: Id
     * Type: long
     */
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    /**
     * Column: WidgetType
     * Type: string
     */
    [Column("WidgetType")]
    [Required]
    [MaxLength(100)]
    public string WidgetType { get; set; }

    /**
     * Column: Title
     * Type: string
     */
    [Column("Title")]
    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    /**
     * Column: DataSource
     * Type: string
     */
    [Column("DataSource")]
    [Required]
    [MaxLength(500)]
    public string DataSource { get; set; }

    /**
     * Column: Configuration
     * Type: string
     */
    [Column("Configuration")]
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Configuration { get; set; }

    /**
     * Column: Position
     * Type: int
     */
    [Column("Position")]
    public int Position { get; set; }

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
