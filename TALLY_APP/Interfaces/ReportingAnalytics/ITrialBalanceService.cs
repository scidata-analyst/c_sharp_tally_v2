using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: ITrialBalanceService
     * =====================================================
     *
     * Purpose:
     * Defines contract for TrialBalance business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ITrialBalanceService
    {
        /**
         * Get all records
         */
        Task<List<TrialBalanceResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<TrialBalanceResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<TrialBalanceResponse> View(long id);

        /**
         * Create new record
         */
        Task<TrialBalanceResponse> Create(TrialBalanceRequest request);

        /**
         * Update existing record
         */
        Task<TrialBalanceResponse> Update(long id, TrialBalanceRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
