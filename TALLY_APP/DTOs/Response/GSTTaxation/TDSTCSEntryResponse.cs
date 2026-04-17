using System;

namespace POS_APP.DTOs.Response.GSTTaxation
{
    /**
     * Response DTO: TDSTCSEntry
     *
     * Purpose:
     * Used for API responses of TDSTCSEntry
     */
    public class TDSTCSEntryResponse
    {
        public long Id { get; set; }
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
