using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Interface: IGSTReturnService
     * =====================================================
     *
     * Purpose:
     * Defines contract for GSTReturn business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IGSTReturnService
    {
        /**
         * Get all records
         */
        Task<List<GSTReturnResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<GSTReturnResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<GSTReturnResponse> View(long id);

        /**
         * Create new record
         */
        Task<GSTReturnResponse> Create(GSTReturnRequest request);

        /**
         * Update existing record
         */
        Task<GSTReturnResponse> Update(long id, GSTReturnRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
