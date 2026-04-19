using System;

namespace TALLY_APP.DTOs.Response.MultiLocationBranch
{
    /**
     * Response DTO: Branch
     *
     * Purpose:
     * API response model for Branch
     */
    public class BranchResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for Branch
         */
        public long Id { get; set; }
        /**
         * Field: BranchName
         * Type: string
         * Description: Response property for Branch
         */
        public string BranchName { get; set; }
        /**
         * Field: BranchCode
         * Type: string
         * Description: Response property for Branch
         */
        public string BranchCode { get; set; }
        /**
         * Field: CityLocation
         * Type: string
         * Description: Response property for Branch
         */
        public string CityLocation { get; set; }
        /**
         * Field: BranchManager
         * Type: string
         * Description: Response property for Branch
         */
        public string BranchManager { get; set; }
        /**
         * Field: Gstin
         * Type: string
         * Description: Response property for Branch
         */
        public string Gstin { get; set; }
        /**
         * Field: Phone
         * Type: string
         * Description: Response property for Branch
         */
        public string Phone { get; set; }
        /**
         * Field: Address
         * Type: string
         * Description: Response property for Branch
         */
        public string Address { get; set; }
        /**
         * Field: Revenue
         * Type: decimal
         * Description: Response property for Branch
         */
        public decimal Revenue { get; set; }
        /**
         * Field: StockValue
         * Type: decimal
         * Description: Response property for Branch
         */
        public decimal StockValue { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for Branch
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for Branch
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for Branch
         */
        public DateTime UpdatedAt { get; set; }

    }
}
