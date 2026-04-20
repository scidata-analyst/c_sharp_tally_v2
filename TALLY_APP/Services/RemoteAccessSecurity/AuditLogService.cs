using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Services.RemoteAccessSecurity
{
    /**
     * @class AuditLogService
     * @description Business logic layer for AuditLog module.
     */
    public class AuditLogService
    {
        private readonly AuditLogRepository _repository;

        /**
         * @constructor
         * @param {AuditLogRepository} repository
         */
        public AuditLogService(AuditLogRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<AuditLog>>}
         */
        public async Task<List<AuditLog>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<AuditLog>}
         */
        public async Task<AuditLog> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {AuditLog} entity
         */
        public async Task<AuditLog> Create(AuditLog entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {AuditLog} entity
         */
        public async Task<AuditLog> Update(long id, AuditLog entity)
        {
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity;
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task Delete(long id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
