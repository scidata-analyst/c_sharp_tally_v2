using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: ICashFlowStatementService
     * =====================================================
     *
     * Purpose:
     * Defines contract for CashFlowStatement business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ICashFlowStatementService
    {
        /**
         * Get all records
         */
        Task<List<CashFlowStatementResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<CashFlowStatementResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<CashFlowStatementResponse> View(long id);

        /**
         * Create new record
         */
        Task<CashFlowStatementResponse> Create(CashFlowStatementRequest request);

        /**
         * Update existing record
         */
        Task<CashFlowStatementResponse> Update(long id, CashFlowStatementRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
