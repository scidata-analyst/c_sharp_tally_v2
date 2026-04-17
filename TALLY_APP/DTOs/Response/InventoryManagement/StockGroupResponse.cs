using System;

namespace TALLY_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockGroup
     *
     * Purpose:
     * API response model for StockGroup
     */
    public class StockGroupResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for StockGroup
         */
        public long Id { get; set; }
        /**
         * Field: GroupName
         * Type: string
         * Description: Response property for StockGroup
         */
        public string GroupName { get; set; }
        /**
         * Field: ParentGroup
         * Type: string
         * Description: Response property for StockGroup
         */
        public string ParentGroup { get; set; }
        /**
         * Field: ItemsCount
         * Type: int
         * Description: Response property for StockGroup
         */
        public int ItemsCount { get; set; }
        /**
         * Field: ValuationMethod
         * Type: string
         * Description: Response property for StockGroup
         */
        public string ValuationMethod { get; set; }
        /**
         * Field: TotalValue
         * Type: decimal
         * Description: Response property for StockGroup
         */
        public decimal TotalValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for StockGroup
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for StockGroup
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for StockGroup
         */
        public DateTime UpdatedAt { get; set; }

    }
}
