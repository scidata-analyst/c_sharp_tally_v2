using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @interface IGSTReturnRepository
     * @description Defines database contract for GSTReturn entity operations.
     */
    public interface IGSTReturnRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all GSTReturn records from database.
         * @returns {Task<List<GSTReturn>>}
         */
        Task<List<GSTReturn>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<GSTReturn>}
         */
        Task<GSTReturn> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {GSTReturn} entity - Entity model
         */
        Task AddAsync(GSTReturn entity);

        /**
         * @method UpdateAsync
         * @param {GSTReturn} entity - Updated entity model
         */
        Task UpdateAsync(GSTReturn entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
