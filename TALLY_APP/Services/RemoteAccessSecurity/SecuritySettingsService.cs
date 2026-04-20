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
     * @class SecuritySettingsService
     * @description Business logic layer for SecuritySettings module.
     */
    public class SecuritySettingsService : ISecuritySettingsService
    {
        private readonly SecuritySettingsRepository _repository;

        /**
         * @constructor
         * @param {SecuritySettingsRepository} repository
         */
        public SecuritySettingsService(SecuritySettingsRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SecuritySettings>>}
         */
        

        public async Task<List<SecuritySettingsResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SecuritySettingsResponse>>();
        }

        public async Task<List<SecuritySettingsResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SecuritySettingsResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<SecuritySettings>}
         */
        public async Task<SecuritySettingsResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<SecuritySettingsResponse>();
        }

        /**
         * @method Create
         * @param {SecuritySettings} entity
         */
        public async Task<SecuritySettingsResponse> Create(SecuritySettingsRequest request)
        {
            var entity = request.Adapt<SecuritySettings>();
            await _repository.AddAsync(entity);
            return entity.Adapt<SecuritySettingsResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SecuritySettings} entity
         */
        public async Task<SecuritySettingsResponse> Update(long id, SecuritySettingsRequest request)
        {
            var entity = request.Adapt<SecuritySettings>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<SecuritySettingsResponse>();
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



