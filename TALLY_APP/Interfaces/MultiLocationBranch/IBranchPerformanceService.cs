using System.Collections.Generic;
using System.Threading.Tasks;
using MultiLocationBranch.DTOs.Request;
using MultiLocationBranch.DTOs.Response;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Interface: IBranchPerformanceService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BranchPerformance business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBranchPerformanceService
    {
        /**
         * Get all records
         */
        Task<List<BranchPerformanceResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BranchPerformanceResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BranchPerformanceResponse> View(long id);

        /**
         * Create new record
         */
        Task<BranchPerformanceResponse> Create(BranchPerformanceRequest request);

        /**
         * Update existing record
         */
        Task<BranchPerformanceResponse> Update(long id, BranchPerformanceRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
