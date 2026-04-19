using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class EmployeeService
     * @description Business logic layer for Employee module.
     */
    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;

        /**
         * @constructor
         * @param {IEmployeeRepository} repository
         */
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Employee>>}
         */
        public async Task<List<Employee>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<Employee>}
         */
        public async Task<Employee> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {Employee} entity
         */
        public async Task<Employee> Create(Employee entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Employee} entity
         */
        public async Task<Employee> Update(long id, Employee entity)
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
