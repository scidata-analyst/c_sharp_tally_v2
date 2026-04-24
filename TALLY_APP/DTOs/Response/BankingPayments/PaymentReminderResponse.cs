using System;

namespace TALLY_APP.DTOs.Response.BankingPayments
{
    /**
     * Response DTO: PaymentReminder
     *
     * Purpose:
     * API response model for PaymentReminder
     */
    public class PaymentReminderResponse
    {
        /**
         * Field: Id
         * Type: long
         * Description: Response property for PaymentReminder
         */
        public long Id { get; set; }
        /**
         * Field: PartyId
         * Type: long
         * Description: Response property for PaymentReminder
         */
        public long PartyId { get; set; }
        /**
         * Field: PartyName
         * Type: string
         * Description: Response property for PaymentReminder
         */
        public string PartyName { get; set; }
        /**
         * Field: InvoiceNumber
         * Type: string
         * Description: Response property for PaymentReminder
         */
        public string InvoiceNumber { get; set; }
        /**
         * Field: Amount
         * Type: decimal
         * Description: Response property for PaymentReminder
         */
        public decimal Amount { get; set; }
        /**
         * Field: OverdueBy
         * Type: int
         * Description: Response property for PaymentReminder
         */
        public int OverdueBy { get; set; }
        /**
         * Field: ReminderNumber
         * Type: string
         * Description: Response property for PaymentReminder
         */
        public string ReminderNumber { get; set; }
        /**
         * Field: LastSent
         * Type: DateTime
         * Description: Response property for PaymentReminder
         */
        public DateTime LastSent { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Response property for PaymentReminder
         */
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Response property for PaymentReminder
         */
        public DateTime CreatedAt { get; set; }

    }

    /**
     * Response DTO: PaginatedPaymentReminderResponse
     *
     * Purpose:
     * API response model for paginated payment reminder list
     */
    public class PaginatedPaymentReminderResponse
    {
        public List<PaymentReminderResponse> Data { get; set; }
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}
