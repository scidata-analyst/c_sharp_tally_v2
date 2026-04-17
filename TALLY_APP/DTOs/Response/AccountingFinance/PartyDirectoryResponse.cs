using System;

namespace TALLY_APP.DTOs.Response.AccountingFinance
{
    /**
     * Response DTO: PartyDirectory
     *
     * Purpose:
     * API response model for PartyDirectory
     */
    public class PartyDirectoryResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for PartyDirectory
         */
        public long Id { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string PartyName { get; set; }
        /**
         * Field: PartyType
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string PartyType { get; set; }
        /**
         * Field: Gstin
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string Gstin { get; set; }
        /**
         * Field: PanNumber
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string PanNumber { get; set; }
        /**
         * Field: Phone
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string Phone { get; set; }
        /**
         * Field: Email
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string Email { get; set; }
        /**
         * Field: Address
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string Address { get; set; }
        /**
         * Field: CreditLimit
         * Type: decimal
         * Description: Response property for PartyDirectory
         */
        public decimal CreditLimit { get; set; }
        /**
         * Field: CreditPeriod
         * Type: int
         * Description: Response property for PartyDirectory
         */
        public int CreditPeriod { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for PartyDirectory
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for PartyDirectory
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Response property for PartyDirectory
         */
        public DateTime UpdatedAt { get; set; }

    }
}
