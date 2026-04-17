using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: StockMovement
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class StockMovementRequest
    {
        /**
         * Field: ReferenceNumber
         * Type: string
         * Description: Request property for StockMovement
         */
        [Required]
        [MaxLength(50)]
        public string ReferenceNumber { get; set; }
        /**
         * Field: MovementDate
         * Type: DateTime
         * Description: Request property for StockMovement
         */
        public DateTime MovementDate { get; set; }
        /**
         * Field: MovementType
         * Type: string
         * Description: Request property for StockMovement
         */
        [Required]
        [MaxLength(50)]
        public string MovementType { get; set; }
        /**
         * Field: ItemId
         * Type: long
         * Description: Request property for StockMovement
         */
        public long ItemId { get; set; }
        /**
         * Field: FromGodownId
         * Type: long
         * Description: Request property for StockMovement
         */
        public long FromGodownId { get; set; }
        /**
         * Field: ToGodownId
         * Type: long
         * Description: Request property for StockMovement
         */
        public long ToGodownId { get; set; }
        /**
         * Field: Quantity
         * Type: int
         * Description: Request property for StockMovement
         */
        public int Quantity { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for StockMovement
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for StockMovement
         */
        public DateTime CreatedAt { get; set; }

    }
}
