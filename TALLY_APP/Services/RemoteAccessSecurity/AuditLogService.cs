using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.RemoteAccessSecurity;

using Mapster;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Services.RemoteAccessSecurity
{
    /**
     * @class AuditLogService
     * @description Business logic layer for AuditLog module.
     */
    public class AuditLogService : IAuditLogService
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
        

        public async Task<List<AuditLogResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<AuditLogResponse>>();
        }

        public async Task<List<AuditLogResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<AuditLogResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<AuditLog>}
         */
        public async Task<AuditLogResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<AuditLogResponse>();
        }

        /**
         * @method Create
         * @param {AuditLog} entity
         */
        public async Task<AuditLogResponse> Create(AuditLogRequest request)
        {
            var entity = request.Adapt<AuditLog>();
            await _repository.AddAsync(entity);
            return entity.Adapt<AuditLogResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {AuditLog} entity
         */
        public async Task<AuditLogResponse> Update(long id, AuditLogRequest request)
        {
            var entity = request.Adapt<AuditLog>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<AuditLogResponse>();
        }

        /**
         * @method Delete
         * @param {long} id
         */
        public async Task<bool> Delete(long id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }
    }
}



