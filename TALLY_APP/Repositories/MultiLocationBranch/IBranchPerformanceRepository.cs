using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @interface IBranchPerformanceRepository
     * @description Defines database contract for BranchPerformance entity operations.
     */
    public interface IBranchPerformanceRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BranchPerformance records from database.
         * @returns {Task<List<BranchPerformance>>}
         */
        Task<List<BranchPerformance>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BranchPerformance>}
         */
        Task<BranchPerformance> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BranchPerformance} entity - Entity model
         */
        Task AddAsync(BranchPerformance entity);

        /**
         * @method UpdateAsync
         * @param {BranchPerformance} entity - Updated entity model
         */
        Task UpdateAsync(BranchPerformance entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
