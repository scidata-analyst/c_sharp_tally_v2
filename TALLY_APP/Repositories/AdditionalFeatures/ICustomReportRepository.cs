using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Repositories.AdditionalFeatures
{
    /**
     * @interface ICustomReportRepository
     * @description Defines database contract for CustomReport entity operations.
     */
    public interface ICustomReportRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all CustomReport records from database.
         * @returns {Task<List<CustomReport>>}
         */
        Task<List<CustomReport>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<CustomReport>}
         */
        Task<CustomReport> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {CustomReport} entity - Entity model
         */
        Task AddAsync(CustomReport entity);

        /**
         * @method UpdateAsync
         * @param {CustomReport} entity - Updated entity model
         */
        Task UpdateAsync(CustomReport entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
