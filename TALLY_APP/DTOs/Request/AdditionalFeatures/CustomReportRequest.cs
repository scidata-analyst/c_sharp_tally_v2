using System;

namespace POS_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: CustomReport
     *
     * Purpose:
     * Used for Create/Update operations of CustomReport
     */
    public class CustomReportRequest
    {
        public string ReportName { get; set; }
        public string Module { get; set; }
        public string Format { get; set; }
        public string QueryConfig { get; set; }
        public DateTime LastGenerated { get; set; }
        public string Schedule { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
