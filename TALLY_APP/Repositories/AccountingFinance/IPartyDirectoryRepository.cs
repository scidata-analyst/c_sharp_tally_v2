using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.AccountingFinance;

namespace TALLY_APP.Repositories.AccountingFinance
{
    /**
     * @interface IPartyDirectoryRepository
     * @description Defines database contract for PartyDirectory entity operations.
     */
    public interface IPartyDirectoryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all PartyDirectory records from database.
         * @returns {Task<List<PartyDirectory>>}
         */
        Task<List<PartyDirectory>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<PartyDirectory>}
         */
        Task<PartyDirectory> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {PartyDirectory} entity - Entity model
         */
        Task AddAsync(PartyDirectory entity);

        /**
         * @method UpdateAsync
         * @param {PartyDirectory} entity - Updated entity model
         */
        Task UpdateAsync(PartyDirectory entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
