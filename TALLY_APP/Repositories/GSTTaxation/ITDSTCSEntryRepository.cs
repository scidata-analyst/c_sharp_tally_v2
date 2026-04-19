using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @interface ITDSTCSEntryRepository
     * @description Defines database contract for TDSTCSEntry entity operations.
     */
    public interface ITDSTCSEntryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all TDSTCSEntry records from database.
         * @returns {Task<List<TDSTCSEntry>>}
         */
        Task<List<TDSTCSEntry>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<TDSTCSEntry>}
         */
        Task<TDSTCSEntry> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {TDSTCSEntry} entity - Entity model
         */
        Task AddAsync(TDSTCSEntry entity);

        /**
         * @method UpdateAsync
         * @param {TDSTCSEntry} entity - Updated entity model
         */
        Task UpdateAsync(TDSTCSEntry entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
