using System.Collections.Generic;
using System.Threading.Tasks;
using BankingPayments.DTOs.Request;
using BankingPayments.DTOs.Response;

namespace TALLY_APP.Interfaces.BankingPayments
{
    /**
     * =====================================================
     * Interface: IBankIntegrationService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BankIntegration business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBankIntegrationService
    {
        /**
         * Get all records
         */
        Task<List<BankIntegrationResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BankIntegrationResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BankIntegrationResponse> View(long id);

        /**
         * Create new record
         */
        Task<BankIntegrationResponse> Create(BankIntegrationRequest request);

        /**
         * Update existing record
         */
        Task<BankIntegrationResponse> Update(long id, BankIntegrationRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
