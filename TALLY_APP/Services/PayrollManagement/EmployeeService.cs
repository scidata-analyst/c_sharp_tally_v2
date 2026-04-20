using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;

using Mapster;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.DTOs.Request.PayrollManagement;
using TALLY_APP.DTOs.Response.PayrollManagement;

using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class EmployeeService
     * @description Business logic layer for Employee module.
     */
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _repository;

        /**
         * @constructor
         * @param {EmployeeRepository} repository
         */
        public EmployeeService(EmployeeRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Employee>>}
         */
        

        public async Task<List<EmployeeResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<EmployeeResponse>>();
        }

        public async Task<List<EmployeeResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<EmployeeResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<Employee>}
         */
        public async Task<EmployeeResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<EmployeeResponse>();
        }

        /**
         * @method Create
         * @param {Employee} entity
         */
        public async Task<EmployeeResponse> Create(EmployeeRequest request)
        {
            var entity = request.Adapt<Employee>();
            await _repository.AddAsync(entity);
            return entity.Adapt<EmployeeResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Employee} entity
         */
        public async Task<EmployeeResponse> Update(long id, EmployeeRequest request)
        {
            var entity = request.Adapt<Employee>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<EmployeeResponse>();
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



