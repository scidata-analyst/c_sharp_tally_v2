using System;

namespace POS_APP.DTOs.Request.Dashboard
{
    /**
     * Request DTO: DashboardWidget
     *
     * Purpose:
     * Used for Create/Update operations of DashboardWidget
     */
    public class DashboardWidgetRequest
    {
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
