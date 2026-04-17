using System;

namespace POS_APP.DTOs.Response.Dashboard
{
    /**
     * Response DTO: DashboardWidget
     *
     * Purpose:
     * Used for API responses of DashboardWidget
     */
    public class DashboardWidgetResponse
    {
        public long Id { get; set; }
        public string WidgetType { get; set; }
        public string Title { get; set; }
        public string DataSource { get; set; }
        public string Configuration { get; set; }
        public int Position { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
