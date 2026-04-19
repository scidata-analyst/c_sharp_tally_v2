using System;

namespace TALLY_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: GSTReturn
     *
     * Purpose:
     * API response model for GSTReturn
     */
    public class GSTReturnResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for GSTReturn
         */
        public long Id { get; set; }
        /**
         * Field: ReturnType
         * Type: string
         * Description: Response property for GSTReturn
         */
        public string ReturnType { get; set; }
        /**
         * Field: Period
         * Type: string
         * Description: Response property for GSTReturn
         */
        public string Period { get; set; }
        /**
         * Field: DueDate
         * Type: DateTime
         * Description: Response property for GSTReturn
         */
        public DateTime DueDate { get; set; }
        /**
         * Field: TotalOutward
         * Type: decimal
         * Description: Response property for GSTReturn
         */
        public decimal TotalOutward { get; set; }
        /**
         * Field: TaxCollected
         * Type: decimal
         * Description: Response property for GSTReturn
         */
        public decimal TaxCollected { get; set; }
        /**
         * Field: TotalInward
         * Type: decimal
         * Description: Response property for GSTReturn
         */
        public decimal TotalInward { get; set; }
        /**
         * Field: ItcAvailable
         * Type: decimal
         * Description: Response property for GSTReturn
         */
        public decimal ItcAvailable { get; set; }
        /**
         * Field: NetPayable
         * Type: decimal
         * Description: Response property for GSTReturn
         */
        public decimal NetPayable { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for GSTReturn
         */
        public string Status { get; set; }
        /**
         * Field: FiledDate
         * Type: DateTime
         * Description: Response property for GSTReturn
         */
        public DateTime FiledDate { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for GSTReturn
         */
        public DateTime CreatedAt { get; set; }

    }
}
