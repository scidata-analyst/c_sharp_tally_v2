using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.MultiLocationBranch;
using TALLY_APP.DTOs.Response.MultiLocationBranch;

namespace TALLY_APP.Interfaces.MultiLocationBranch
{
    /**
     * =====================================================
     * Interface: IBranchService
     * =====================================================
     *
     * Purpose:
     * Defines contract for Branch business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IBranchService
    {
        /**
         * Get all records
         */
        Task<List<BranchResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<BranchResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<BranchResponse> View(long id);

        /**
         * Create new record
         */
        Task<BranchResponse> Create(BranchRequest request);

        /**
         * Update existing record
         */
        Task<BranchResponse> Update(long id, BranchRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
