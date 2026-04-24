using System;

namespace TALLY_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: BatchRegister
     *
     * Purpose:
     * API response model for BatchRegister
     */
    public class BatchRegisterResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for BatchRegister
         */
        public long Id { get; set; }
        /**
         * Field: BatchNumber
         * Type: string
         * Description: Response property for BatchRegister
         */
        public string BatchNumber { get; set; }
        /**
         * Field: ItemId
         * Type: long
         * Description: Response property for BatchRegister
         */
        public long ItemId { get; set; }
        /**
         * Field: ManufacturingDate
         * Type: DateTime
         * Description: Response property for BatchRegister
         */
        public DateTime ManufacturingDate { get; set; }
        /**
         * Field: ExpiryDate
         * Type: DateTime
         * Description: Response property for BatchRegister
         */
        public DateTime ExpiryDate { get; set; }
        /**
         * Field: Quantity
         * Type: int
         * Description: Response property for BatchRegister
         */
        public int Quantity { get; set; }
        /**
         * Field: SerialRange
         * Type: string
         * Description: Response property for BatchRegister
         */
        public string SerialRange { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for BatchRegister
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for BatchRegister
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for BatchRegister
         */
        public DateTime UpdatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedBatchRegisterResponse
     *
     * Purpose:
     * API response model for paginated batch register list
     */
    public class PaginatedBatchRegisterResponse
    {
        public List<BatchRegisterResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
