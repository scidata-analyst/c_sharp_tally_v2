using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @interface ISecuritySettingsRepository
     * @description Defines database contract for SecuritySettings entity operations.
     */
    public interface ISecuritySettingsRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all SecuritySettings records from database.
         * @returns {Task<List<SecuritySettings>>}
         */
        Task<List<SecuritySettings>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<SecuritySettings>}
         */
        Task<SecuritySettings> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {SecuritySettings} entity - Entity model
         */
        Task AddAsync(SecuritySettings entity);

        /**
         * @method UpdateAsync
         * @param {SecuritySettings} entity - Updated entity model
         */
        Task UpdateAsync(SecuritySettings entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
