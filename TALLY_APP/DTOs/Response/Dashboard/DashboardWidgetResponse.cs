using System;

namespace TALLY_APP.DTOs.Response.Dashboard
{
    /**
     * Response DTO: DashboardWidget
     *
     * Purpose:
     * API response model for DashboardWidget
     */
    public class DashboardWidgetResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for DashboardWidget
         */
        public long Id { get; set; }
        /**
         * Field: WidgetType
         * Type: string
         * Description: Response property for DashboardWidget
         */
        public string WidgetType { get; set; }
        /**
         * Field: Title
         * Type: string
         * Description: Response property for DashboardWidget
         */
        public string Title { get; set; }
        /**
         * Field: DataSource
         * Type: string
         * Description: Response property for DashboardWidget
         */
        public string DataSource { get; set; }
        /**
         * Field: Configuration
         * Type: string
         * Description: Response property for DashboardWidget
         */
        public string Configuration { get; set; }
        /**
         * Field: Position
         * Type: int
         * Description: Response property for DashboardWidget
         */
        public int Position { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for DashboardWidget
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for DashboardWidget
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for DashboardWidget
         */
        public DateTime UpdatedAt { get; set; }

    }
}
