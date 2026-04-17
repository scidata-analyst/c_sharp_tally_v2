using System.Collections.Generic;
using System.Threading.Tasks;
using ReportingAnalytics.DTOs.Request;
using ReportingAnalytics.DTOs.Response;

namespace TALLY_APP.Interfaces.ReportingAnalytics
{
    /**
     * =====================================================
     * Interface: IStockReportService
     * =====================================================
     *
     * Purpose:
     * Defines contract for StockReport business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IStockReportService
    {
        /**
         * Get all records
         */
        Task<List<StockReportResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<StockReportResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<StockReportResponse> View(long id);

        /**
         * Create new record
         */
        Task<StockReportResponse> Create(StockReportRequest request);

        /**
         * Update existing record
         */
        Task<StockReportResponse> Update(long id, StockReportRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
