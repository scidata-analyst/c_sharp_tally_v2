using System;

namespace TALLY_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: Godown
     *
     * Purpose:
     * API response model for Godown
     */
    public class GodownResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for Godown
         */
        public long Id { get; set; }
        /**
         * Field: GodownName
         * Type: string
         * Description: Response property for Godown
         */
        public string GodownName { get; set; }
        /**
         * Field: Location
         * Type: string
         * Description: Response property for Godown
         */
        public string Location { get; set; }
        /**
         * Field: Manager
         * Type: string
         * Description: Response property for Godown
         */
        public string Manager { get; set; }
        /**
         * Field: Capacity
         * Type: string
         * Description: Response property for Godown
         */
        public string Capacity { get; set; }
        /**
         * Field: UsedPercentage
         * Type: decimal
         * Description: Response property for Godown
         */
        public decimal UsedPercentage { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Response property for Godown
         */
        public decimal StockValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for Godown
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for Godown
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for Godown
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedGodownResponse
     *
     * Purpose:
     * API response model for paginated godown list
     */
    public class PaginatedGodownResponse
    {
        public List<GodownResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
