using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Interface: IBudgetService
     * =====================================================
     *
     * Purpose:
     * Defines contract for Budget business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBudgetService
    {
        /**
         * Get all records
         */
        Task<List<BudgetResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BudgetResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BudgetResponse> View(long id);

        /**
         * Create new record
         */
        Task<BudgetResponse> Create(BudgetRequest request);

        /**
         * Update existing record
         */
        Task<BudgetResponse> Update(long id, BudgetRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
