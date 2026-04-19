using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Services.RemoteAccessSecurity
{
    /**
     * @class SystemUserService
     * @description Business logic layer for SystemUser module.
     */
    public class SystemUserService
    {
        private readonly ISystemUserRepository _repository;

        /**
         * @constructor
         * @param {ISystemUserRepository} repository
         */
        public SystemUserService(ISystemUserRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SystemUser>>}
         */
        public async Task<List<SystemUser>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<SystemUser>}
         */
        public async Task<SystemUser> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {SystemUser} entity
         */
        public async Task<SystemUser> Create(SystemUser entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SystemUser} entity
         */
        public async Task<SystemUser> Update(long id, SystemUser entity)
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
