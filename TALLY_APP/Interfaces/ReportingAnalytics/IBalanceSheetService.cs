using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.ReportingAnalytics;
using TALLY_APP.DTOs.Response.ReportingAnalytics;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: IBalanceSheetService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BalanceSheet business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBalanceSheetService
    {
        /**
         * Get all records
         */
        Task<List<BalanceSheetResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BalanceSheetResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BalanceSheetResponse> View(long id);

        /**
         * Create new record
         */
        Task<BalanceSheetResponse> Create(BalanceSheetRequest request);

        /**
         * Update existing record
         */
        Task<BalanceSheetResponse> Update(long id, BalanceSheetRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
