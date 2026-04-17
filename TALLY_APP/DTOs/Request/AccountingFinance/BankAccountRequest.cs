using System;

namespace POS_APP.DTOs.Request.AccountingFinance
{
    /**
     * Request DTO: BankAccount
     *
     * Purpose:
     * Used for Create/Update operations of BankAccount
     */
    public class BankAccountRequest
    {
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
