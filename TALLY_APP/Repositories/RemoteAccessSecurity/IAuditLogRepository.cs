using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Repositories.RemoteAccessSecurity
{
    /**
     * @interface IAuditLogRepository
     * @description Defines database contract for AuditLog entity operations.
     */
    public interface IAuditLogRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all AuditLog records from database.
         * @returns {Task<List<AuditLog>>}
         */
        Task<List<AuditLog>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<AuditLog>}
         */
        Task<AuditLog> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {AuditLog} entity - Entity model
         */
        Task AddAsync(AuditLog entity);

        /**
         * @method UpdateAsync
         * @param {AuditLog} entity - Updated entity model
         */
        Task UpdateAsync(AuditLog entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
