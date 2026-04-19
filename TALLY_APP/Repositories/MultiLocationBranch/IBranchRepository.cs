using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.MultiLocationBranch;

namespace TALLY_APP.Repositories.MultiLocationBranch
{
    /**
     * @interface IBranchRepository
     * @description Defines database contract for Branch entity operations.
     */
    public interface IBranchRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all Branch records from database.
         * @returns {Task<List<Branch>>}
         */
        Task<List<Branch>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<Branch>}
         */
        Task<Branch> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {Branch} entity - Entity model
         */
        Task AddAsync(Branch entity);

        /**
         * @method UpdateAsync
         * @param {Branch} entity - Updated entity model
         */
        Task UpdateAsync(Branch entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
