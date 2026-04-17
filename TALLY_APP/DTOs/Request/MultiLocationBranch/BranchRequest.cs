using System;
using System.ComponentModel.DataAnnotations;

namespace POS_APP.DTOs.Request.MultiLocationBranch
{
    /**
     * Request DTO: Branch
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BranchRequest
    {
        /**
         * Field: BranchName
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(200)]
        public string BranchName { get; set; }
        /**
         * Field: BranchCode
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(50)]
        public string BranchCode { get; set; }
        /**
         * Field: CityLocation
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(100)]
        public string CityLocation { get; set; }
        /**
         * Field: BranchManager
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(100)]
        public string BranchManager { get; set; }
        /**
         * Field: Gstin
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(50)]
        public string Gstin { get; set; }
        /**
         * Field: Phone
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        /**
         * Field: Address
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        public string Address { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Request property for Branch
         */
        [Range(0, double.MaxValue)]
        public decimal Revenue { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Request property for Branch
         */
        [Range(0, double.MaxValue)]
        public decimal StockValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for Branch
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for Branch
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for Branch
         */
        public DateTime UpdatedAt { get; set; }

    }
}
