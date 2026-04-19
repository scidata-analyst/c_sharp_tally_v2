using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @interface ISystemUserRepository
     * @description Defines database contract for SystemUser entity operations.
     */
    public interface ISystemUserRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all SystemUser records from database.
         * @returns {Task<List<SystemUser>>}
         */
        Task<List<SystemUser>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<SystemUser>}
         */
        Task<SystemUser> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {SystemUser} entity - Entity model
         */
        Task AddAsync(SystemUser entity);

        /**
         * @method UpdateAsync
         * @param {SystemUser} entity - Updated entity model
         */
        Task UpdateAsync(SystemUser entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
