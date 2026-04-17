using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @interface IBranchConsolidationRepository
     * @description Defines database contract for BranchConsolidation entity operations.
     */
    public interface IBranchConsolidationRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BranchConsolidation records from database.
         * @returns {Task<List<BranchConsolidation>>}
         */
        Task<List<BranchConsolidation>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BranchConsolidation>}
         */
        Task<BranchConsolidation> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BranchConsolidation} entity - Entity model
         */
        Task AddAsync(BranchConsolidation entity);

        /**
         * @method UpdateAsync
         * @param {BranchConsolidation} entity - Updated entity model
         */
        Task UpdateAsync(BranchConsolidation entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
