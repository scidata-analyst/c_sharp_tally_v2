using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.GSTTaxation;

namespace TALLY_APP.Repositories.GSTTaxation
{
    /**
     * @interface IGSTEntryRepository
     * @description Defines database contract for GSTEntry entity operations.
     */
    public interface IGSTEntryRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all GSTEntry records from database.
         * @returns {Task<List<GSTEntry>>}
         */
        Task<List<GSTEntry>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<GSTEntry>}
         */
        Task<GSTEntry> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {GSTEntry} entity - Entity model
         */
        Task AddAsync(GSTEntry entity);

        /**
         * @method UpdateAsync
         * @param {GSTEntry} entity - Updated entity model
         */
        Task UpdateAsync(GSTEntry entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
