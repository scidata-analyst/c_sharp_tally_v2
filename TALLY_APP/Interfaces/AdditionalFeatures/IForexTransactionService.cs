using System.Collections.Generic;
using System.Threading.Tasks;
using AdditionalFeatures.DTOs.Request;
using AdditionalFeatures.DTOs.Response;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Interface: IForexTransactionService
     * =====================================================
     *
     * Purpose:
     * Defines contract for ForexTransaction business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IForexTransactionService
    {
        /**
         * Get all records
         */
        Task<List<ForexTransactionResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<ForexTransactionResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<ForexTransactionResponse> View(long id);

        /**
         * Create new record
         */
        Task<ForexTransactionResponse> Create(ForexTransactionRequest request);

        /**
         * Update existing record
         */
        Task<ForexTransactionResponse> Update(long id, ForexTransactionRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
