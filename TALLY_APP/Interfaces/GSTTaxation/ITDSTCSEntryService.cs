using System.Collections.Generic;
using System.Threading.Tasks;
using GSTTaxation.DTOs.Request;
using GSTTaxation.DTOs.Response;

namespace TALLY_APP.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Interface: ITDSTCSEntryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for TDSTCSEntry business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ITDSTCSEntryService
    {
        /**
         * Get all records
         */
        Task<List<TDSTCSEntryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<TDSTCSEntryResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<TDSTCSEntryResponse> View(long id);

        /**
         * Create new record
         */
        Task<TDSTCSEntryResponse> Create(TDSTCSEntryRequest request);

        /**
         * Update existing record
         */
        Task<TDSTCSEntryResponse> Update(long id, TDSTCSEntryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
