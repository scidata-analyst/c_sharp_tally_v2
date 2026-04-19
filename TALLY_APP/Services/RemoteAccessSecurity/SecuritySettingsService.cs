using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Services.RemoteAccessSecurity
{
    /**
     * @class SecuritySettingsService
     * @description Business logic layer for SecuritySettings module.
     */
    public class SecuritySettingsService
    {
        private readonly ISecuritySettingsRepository _repository;

        /**
         * @constructor
         * @param {ISecuritySettingsRepository} repository
         */
        public SecuritySettingsService(ISecuritySettingsRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SecuritySettings>>}
         */
        public async Task<List<SecuritySettings>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<SecuritySettings>}
         */
        public async Task<SecuritySettings> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {SecuritySettings} entity
         */
        public async Task<SecuritySettings> Create(SecuritySettings entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SecuritySettings} entity
         */
        public async Task<SecuritySettings> Update(long id, SecuritySettings entity)
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
