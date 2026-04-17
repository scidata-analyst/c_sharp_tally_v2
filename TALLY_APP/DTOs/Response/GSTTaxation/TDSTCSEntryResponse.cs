using System;

namespace TALLY_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: TDSTCSEntry
     *
     * Purpose:
     * API response model for TDSTCSEntry
     */
    public class TDSTCSEntryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for TDSTCSEntry
         */
        public long Id { get; set; }
        /**
         * Field: Section
         * Type: string
         * Description: Response property for TDSTCSEntry
         */
        public string Section { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for TDSTCSEntry
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for TDSTCSEntry
         */
        public string PartyName { get; set; }
        /**
         * Field: PanNumber
         * Type: string
         * Description: Response property for TDSTCSEntry
         */
        public string PanNumber { get; set; }
        /**
         * Field: PaymentAmount
         * Type: decimal
         * Description: Response property for TDSTCSEntry
         */
        public decimal PaymentAmount { get; set; }
        /**
         * Field: TdsRate
         * Type: decimal
         * Description: Response property for TDSTCSEntry
         */
        public decimal TdsRate { get; set; }
        /**
         * Field: TdsAmount
         * Type: decimal
         * Description: Response property for TDSTCSEntry
         */
        public decimal TdsAmount { get; set; }
        /**
         * Field: CertificateNumber
         * Type: string
         * Description: Response property for TDSTCSEntry
         */
        public string CertificateNumber { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for TDSTCSEntry
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for TDSTCSEntry
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for TDSTCSEntry
         */
        public DateTime UpdatedAt { get; set; }

    }
}
