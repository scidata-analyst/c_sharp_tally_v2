using System.Collections.Generic;
using System.Threading.Tasks;
using Dashboard.DTOs.Request;
using Dashboard.DTOs.Response;

namespace TALLY_APP.Interfaces.Dashboard
{
    /**
     * =====================================================
     * Interface: IDashboardWidgetService
     * =====================================================
     *
     * Purpose:
     * Defines contract for DashboardWidget business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IDashboardWidgetService
    {
        /**
         * Get all records
         */
        Task<List<DashboardWidgetResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<DashboardWidgetResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<DashboardWidgetResponse> View(long id);

        /**
         * Create new record
         */
        Task<DashboardWidgetResponse> Create(DashboardWidgetRequest request);

        /**
         * Update existing record
         */
        Task<DashboardWidgetResponse> Update(long id, DashboardWidgetRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
