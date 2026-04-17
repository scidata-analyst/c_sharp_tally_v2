using System;

namespace POS_APP.DTOs.Request.GSTTaxation
{
    /**
     * Request DTO: TDSTCSEntry
     *
     * Purpose:
     * Used for Create/Update operations of TDSTCSEntry
     */
    public class TDSTCSEntryRequest
    {
        public string Section { get; set; }
        public long PartyId { get; set; }
        public string PartyName { get; set; }
        public string PanNumber { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal TdsRate { get; set; }
        public decimal TdsAmount { get; set; }
        public string CertificateNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
