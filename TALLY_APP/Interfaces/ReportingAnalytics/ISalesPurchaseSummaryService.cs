using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: ISalesPurchaseSummaryService
     * =====================================================
     *
     * Purpose:
     * Defines contract for SalesPurchaseSummary business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ISalesPurchaseSummaryService
    {
        /**
         * Get all records
         */
        Task<List<SalesPurchaseSummaryResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<SalesPurchaseSummaryResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<SalesPurchaseSummaryResponse> View(long id);

        /**
         * Create new record
         */
        Task<SalesPurchaseSummaryResponse> Create(SalesPurchaseSummaryRequest request);

        /**
         * Update existing record
         */
        Task<SalesPurchaseSummaryResponse> Update(long id, SalesPurchaseSummaryRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
