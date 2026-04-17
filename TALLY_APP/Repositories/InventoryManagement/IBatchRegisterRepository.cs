using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.InventoryManagement;

namespace TALLY_APP.Repositories.InventoryManagement
{
    /**
     * @interface IBatchRegisterRepository
     * @description Defines database contract for BatchRegister entity operations.
     */
    public interface IBatchRegisterRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all BatchRegister records from database.
         * @returns {Task<List<BatchRegister>>}
         */
        Task<List<BatchRegister>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<BatchRegister>}
         */
        Task<BatchRegister> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {BatchRegister} entity - Entity model
         */
        Task AddAsync(BatchRegister entity);

        /**
         * @method UpdateAsync
         * @param {BatchRegister} entity - Updated entity model
         */
        Task UpdateAsync(BatchRegister entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
