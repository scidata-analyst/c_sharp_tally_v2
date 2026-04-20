using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class PayslipService
     * @description Business logic layer for Payslip module.
     */
    public class PayslipService
    {
        private readonly PayslipRepository _repository;

        /**
         * @constructor
         * @param {PayslipRepository} repository
         */
        public PayslipService(PayslipRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<Payslip>>}
         */
        public async Task<List<Payslip>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<Payslip>}
         */
        public async Task<Payslip> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {Payslip} entity
         */
        public async Task<Payslip> Create(Payslip entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Payslip} entity
         */
        public async Task<Payslip> Update(long id, Payslip entity)
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
