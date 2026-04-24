using System;
using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.AdditionalFeatures
{
    public class ForexTransactionResponse
    {
        public long Id { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public long? PartyId { get; set; }
        public string PartyName { get; set; }
        public string Currency { get; set; }
        public decimal ForeignAmount { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal InrAmount { get; set; }
        public decimal ForexGainLoss { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class PaginatedForexTransactionResponse
    {
        public List<ForexTransactionResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
