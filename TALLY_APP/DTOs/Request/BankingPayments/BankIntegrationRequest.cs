using System;
using System.ComponentModel.DataAnnotations;

namespace TALLY_APP.DTOs.Request.BankingPayments
{
    /**
     * Request DTO: BankIntegration
     *
     * Purpose:
     * Used for CREATE and UPDATE operations
     * Includes validation rules based on schema
     */
    public class BankIntegrationRequest
    {
        /**
         * Field: BankName
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(200)]
        public string BankName { get; set; }
        /**
         * Field: AccountType
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(50)]
        public string AccountType { get; set; }
        /**
         * Field: AccountNumber
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(50)]
        public string AccountNumber { get; set; }
        /**
         * Field: ApiKey
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(500)]
        public string ApiKey { get; set; }
        /**
         * Field: ApiSecret
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(500)]
        public string ApiSecret { get; set; }
        /**
         * Field: LastSync
         * Type: DateTime
         * Description: Request property for BankIntegration
         */
        public DateTime LastSync { get; set; }
        /**
         * Field: Status
         * Type: string
         * Description: Request property for BankIntegration
         */
        [Required]
        [MaxLength(20)]
        public string Status { get; set; }
        /**
         * Field: CreatedAt
         * Type: DateTime
         * Description: Request property for BankIntegration
         */
        public DateTime CreatedAt { get; set; }
        /**
         * Field: UpdatedAt
         * Type: DateTime
         * Description: Request property for BankIntegration
         */
        public DateTime UpdatedAt { get; set; }

    }
}
