using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @interface IGodownRepository
     * @description Defines database contract for Godown entity operations.
     */
    public interface IGodownRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all Godown records from database.
         * @returns {Task<List<Godown>>}
         */
        Task<List<Godown>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<Godown>}
         */
        Task<Godown> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {Godown} entity - Entity model
         */
        Task AddAsync(Godown entity);

        /**
         * @method UpdateAsync
         * @param {Godown} entity - Updated entity model
         */
        Task UpdateAsync(Godown entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
