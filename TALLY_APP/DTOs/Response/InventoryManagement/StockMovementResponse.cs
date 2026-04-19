using System;

namespace TALLY_APP.DTOs.Response.InventoryManagement
{
    /**
     * Response DTO: StockMovement
     *
     * Purpose:
     * API response model for StockMovement
     */
    public class StockMovementResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for StockMovement
         */
        public long Id { get; set; }
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Response property for StockMovement
         */
        public string ReferenceNumber { get; set; }
        /**
         * Field: MovementDate
         * Type: DateTime
         * Description: Response property for StockMovement
         */
        public DateTime MovementDate { get; set; }
        /**
         * Field: MovementType
         * Type: string
         * Description: Response property for StockMovement
         */
        public string MovementType { get; set; }
        /**
         * Field: ItemId
         * Type: long
         * Description: Response property for StockMovement
         */
        public long ItemId { get; set; }
        /**
         * Field: FromGodownId
         * Type: long
         * Description: Response property for StockMovement
         */
        public long FromGodownId { get; set; }
        /**
         * Field: ToGodownId
         * Type: long
         * Description: Response property for StockMovement
         */
        public long ToGodownId { get; set; }
        /**
         * Field: Quantity
         * Type: int
         * Description: Response property for StockMovement
         */
        public int Quantity { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for StockMovement
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for StockMovement
         */
        public DateTime CreatedAt { get; set; }

    }
}
