using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Interface: IGSTEntryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for GSTEntry business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IGSTEntryService
    {
        /**
         * Get all records
         */
        Task<List<GSTEntryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<GSTEntryResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<GSTEntryResponse> View(long id);

        /**
         * Create new record
         */
        Task<GSTEntryResponse> Create(GSTEntryRequest request);

        /**
         * Update existing record
         */
        Task<GSTEntryResponse> Update(long id, GSTEntryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
