using System;

namespace POS_APP.DTOs.Response.AdditionalFeatures
{
    /**
     * Response DTO: CustomReport
     *
     * Purpose:
     * API response model for CustomReport
     */
    public class CustomReportResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for CustomReport
         */
        public long Id { get; set; }
        /**
         * Field: ReportName
         * Type: string
         * Description: Response property for CustomReport
         */
        public string ReportName { get; set; }
        /**
         * Field: Module
         * Type: string
         * Description: Response property for CustomReport
         */
        public string Module { get; set; }
        /**
         * Field: Format
         * Type: string
         * Description: Response property for CustomReport
         */
        public string Format { get; set; }
        /**
         * Field: QueryConfig
         * Type: string
         * Description: Response property for CustomReport
         */
        public string QueryConfig { get; set; }
        /**
         * Field: LastGenerated
         * Type: DateTime
         * Description: Response property for CustomReport
         */
        public DateTime LastGenerated { get; set; }
        /**
         * Field: Schedule
         * Type: string
         * Description: Response property for CustomReport
         */
        public string Schedule { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for CustomReport
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for CustomReport
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for CustomReport
         */
        public DateTime UpdatedAt { get; set; }

    }
}
