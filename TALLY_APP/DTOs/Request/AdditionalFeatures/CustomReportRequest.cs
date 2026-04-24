using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.AdditionalFeatures
{
    /**
     * Request DTO: CustomReport
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class CustomReportRequest
    {
        /**
         * Field: ReportName
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        [MaxLength(200)]
        public string ReportName { get; set; }
        /**
         * Field: Module
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        [MaxLength(100)]
        public string Module { get; set; }
        /**
         * Field: Format
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        [MaxLength(20)]
        public string Format { get; set; }
        /**
         * Field: QueryConfig
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        public string QueryConfig { get; set; }
        /**
         * Field: LastGenerated
         * Type: DateTime
         * Description: Request property for CustomReport
         */
        public DateTime? LastGenerated { get; set; }
        /**
         * Field: Schedule
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        [MaxLength(50)]
        public string Schedule { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for CustomReport
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for CustomReport
         */
        public DateTime? CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for CustomReport
         */
        public DateTime? UpdatedAt { get; set; }

    }
}

