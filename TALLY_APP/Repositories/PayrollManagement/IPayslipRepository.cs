using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Repositories.PayrollManagement
{
    /**
     * @interface IPayslipRepository
     * @description Defines database contract for Payslip entity operations.
     */
    public interface IPayslipRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all Payslip records from database.
         * @returns {Task<List<Payslip>>}
         */
        Task<List<Payslip>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<Payslip>}
         */
        Task<Payslip> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {Payslip} entity - Entity model
         */
        Task AddAsync(Payslip entity);

        /**
         * @method UpdateAsync
         * @param {Payslip} entity - Updated entity model
         */
        Task UpdateAsync(Payslip entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
