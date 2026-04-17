using System;

namespace TALLY_APP.DTOs.Response.ReportingAnalytics
{
    /**
     * Response DTO: StockReport
     *
     * Purpose:
     * API response model for StockReport
     */
    public class StockReportResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for StockReport
         */
        public long Id { get; set; }
        /**
         * Field: ItemName
         * Type: string
         * Description: Response property for StockReport
         */
        public string ItemName { get; set; }
        /**
         * Field: Category
         * Type: string
         * Description: Response property for StockReport
         */
        public string Category { get; set; }
        /**
         * Field: OpeningQty
         * Type: int
         * Description: Response property for StockReport
         */
        public int OpeningQty { get; set; }
        /**
         * Field: StockIn
         * Type: int
         * Description: Response property for StockReport
         */
        public int StockIn { get; set; }
        /**
         * Field: StockOut
         * Type: int
         * Description: Response property for StockReport
         */
        public int StockOut { get; set; }
        /**
         * Field: ClosingQty
         * Type: int
         * Description: Response property for StockReport
         */
        public int ClosingQty { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Response property for StockReport
         */
        public decimal StockValue { get; set; }
        /**
         * Field: ReportDate
         * Type: DateTime
         * Description: Response property for StockReport
         */
        public DateTime ReportDate { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for StockReport
         */
        public DateTime CreatedAt { get; set; }

    }
}
