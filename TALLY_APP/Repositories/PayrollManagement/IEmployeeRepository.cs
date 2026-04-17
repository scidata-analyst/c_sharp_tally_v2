using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Entities.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @interface IEmployeeRepository
     * @description Defines database contract for Employee entity operations.
     */
    public interface IEmployeeRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all Employee records from database.
         * @returns {Task<List<Employee>>}
         */
        Task<List<Employee>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<Employee>}
         */
        Task<Employee> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {Employee} entity - Entity model
         */
        Task AddAsync(Employee entity);

        /**
         * @method UpdateAsync
         * @param {Employee} entity - Updated entity model
         */
        Task UpdateAsync(Employee entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
