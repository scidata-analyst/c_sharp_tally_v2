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
     * @class SystemUserService
     * @description Business logic layer for SystemUser module.
     */
    public class SystemUserService : ISystemUserService
    {
        private readonly SystemUserRepository _repository;

        /**
         * @constructor
         * @param {SystemUserRepository} repository
         */
        public SystemUserService(SystemUserRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<SystemUser>>}
         */
        

        public async Task<List<SystemUserResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SystemUserResponse>>();
        }

        public async Task<List<SystemUserResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<SystemUserResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<SystemUser>}
         */
        public async Task<SystemUserResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<SystemUserResponse>();
        }

        /**
         * @method Create
         * @param {SystemUser} entity
         */
        public async Task<SystemUserResponse> Create(SystemUserRequest request)
        {
            var entity = request.Adapt<SystemUser>();
            await _repository.AddAsync(entity);
            return entity.Adapt<SystemUserResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {SystemUser} entity
         */
        public async Task<SystemUserResponse> Update(long id, SystemUserRequest request)
        {
            var entity = request.Adapt<SystemUser>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<SystemUserResponse>();
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



