using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.InventoryManagement
{
    /**
     * Request DTO: BatchRegister
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BatchRegisterRequest
    {
        /**
         * Field: BatchNumber
         * Type: string
         * Description: Request property for BatchRegister
         */
        [Required]
        [MaxLength(50)]
        public string BatchNumber { get; set; }
        /**
         * Field: ItemId
         * Type: long
         * Description: Request property for BatchRegister
         */
        public long ItemId { get; set; }
        /**
         * Field: ManufacturingDate
         * Type: DateTime
         * Description: Request property for BatchRegister
         */
        public DateTime ManufacturingDate { get; set; }
        /**
         * Field: ExpiryDate
         * Type: DateTime
         * Description: Request property for BatchRegister
         */
        public DateTime ExpiryDate { get; set; }
        /**
         * Field: Quantity
         * Type: int
         * Description: Request property for BatchRegister
         */
        public int Quantity { get; set; }
        /**
         * Field: SerialRange
         * Type: string
         * Description: Request property for BatchRegister
         */
        [Required]
        [MaxLength(100)]
        public string SerialRange { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for BatchRegister
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BatchRegister
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for BatchRegister
         */
        public DateTime UpdatedAt { get; set; }

    }
}
