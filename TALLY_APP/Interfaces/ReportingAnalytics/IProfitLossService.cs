using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: IProfitLossService
     * =====================================================
     *
     * Purpose:
     * Defines contract for ProfitLoss business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IProfitLossService
    {
        /**
         * Get all records
         */
        Task<List<ProfitLossResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<ProfitLossResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<ProfitLossResponse> View(long id);

        /**
         * Create new record
         */
        Task<ProfitLossResponse> Create(ProfitLossRequest request);

        /**
         * Update existing record
         */
        Task<ProfitLossResponse> Update(long id, ProfitLossRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
