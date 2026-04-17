using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.ReportingAnalytics
{
    /**
     * Request DTO: StockReport
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class StockReportRequest
    {
        /**
         * Field: ItemName
         * Type: string
         * Description: Request property for StockReport
         */
        [Required]
        [MaxLength(200)]
        public string ItemName { get; set; }
        /**
         * Field: Category
         * Type: string
         * Description: Request property for StockReport
         */
        [Required]
        [MaxLength(100)]
        public string Category { get; set; }
        /**
         * Field: OpeningQty
         * Type: int
         * Description: Request property for StockReport
         */
        public int OpeningQty { get; set; }
        /**
         * Field: StockIn
         * Type: int
         * Description: Request property for StockReport
         */
        public int StockIn { get; set; }
        /**
         * Field: StockOut
         * Type: int
         * Description: Request property for StockReport
         */
        public int StockOut { get; set; }
        /**
         * Field: ClosingQty
         * Type: int
         * Description: Request property for StockReport
         */
        public int ClosingQty { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Request property for StockReport
         */
        [Range(0, double.MaxValue)]
        public decimal StockValue { get; set; }
        /**
         * Field: ReportDate
         * Type: DateTime
         * Description: Request property for StockReport
         */
        public DateTime ReportDate { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for StockReport
         */
        public DateTime CreatedAt { get; set; }

    }
}
