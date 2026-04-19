using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @interface IPayrollRunRepository
     * @description Defines database contract for PayrollRun entity operations.
     */
    public interface IPayrollRunRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all PayrollRun records from database.
         * @returns {Task<List<PayrollRun>>}
         */
        Task<List<PayrollRun>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<PayrollRun>}
         */
        Task<PayrollRun> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {PayrollRun} entity - Entity model
         */
        Task AddAsync(PayrollRun entity);

        /**
         * @method UpdateAsync
         * @param {PayrollRun} entity - Updated entity model
         */
        Task UpdateAsync(PayrollRun entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
