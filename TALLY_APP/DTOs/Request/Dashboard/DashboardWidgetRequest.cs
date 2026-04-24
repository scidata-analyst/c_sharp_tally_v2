using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.Dashboard
{
    /**
     * Request DTO: DashboardWidget
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class DashboardWidgetRequest
    {
        /**
         * Field: WidgetType
         * Type: string
         * Description: Request property for DashboardWidget
         */
        [Required]
        [MaxLength(100)]
        public string WidgetType { get; set; }
        /**
         * Field: Title
         * Type: string
         * Description: Request property for DashboardWidget
         */
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        /**
         * Field: DataSource
         * Type: string
         * Description: Request property for DashboardWidget
         */
        [Required]
        [MaxLength(500)]
        public string DataSource { get; set; }
        /**
         * Field: Configuration
         * Type: string
         * Description: Request property for DashboardWidget
         */
        [Required]
        public string Configuration { get; set; }
        /**
         * Field: Position
         * Type: int
         * Description: Request property for DashboardWidget
         */
        public int? Position { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for DashboardWidget
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for DashboardWidget
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for DashboardWidget
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

