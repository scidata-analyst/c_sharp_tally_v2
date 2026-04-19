using System.Collections.Generic;
using System.Threading.Tasks;
using MultiLocationBranch.DTOs.Request;
using MultiLocationBranch.DTOs.Response;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Interface: IBranchConsolidationService
     * =====================================================
     *
     * Purpose:
     * Defines contract for BranchConsolidation business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBranchConsolidationService
    {
        /**
         * Get all records
         */
        Task<List<BranchConsolidationResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BranchConsolidationResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BranchConsolidationResponse> View(long id);

        /**
         * Create new record
         */
        Task<BranchConsolidationResponse> Create(BranchConsolidationRequest request);

        /**
         * Update existing record
         */
        Task<BranchConsolidationResponse> Update(long id, BranchConsolidationRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
