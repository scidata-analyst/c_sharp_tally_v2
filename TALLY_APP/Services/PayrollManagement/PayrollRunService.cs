using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.PayrollManagement;
using TALLY_APP.Models.PayrollManagement;

namespace TALLY_APP.Services.PayrollManagement
{
    /**
     * @class PayrollRunService
     * @description Business logic layer for PayrollRun module.
     */
    public class PayrollRunService
    {
        private readonly PayrollRunRepository _repository;

        /**
         * @constructor
         * @param {PayrollRunRepository} repository
         */
        public PayrollRunService(PayrollRunRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<PayrollRun>>}
         */
        public async Task<List<PayrollRun>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<PayrollRun>}
         */
        public async Task<PayrollRun> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {PayrollRun} entity
         */
        public async Task<PayrollRun> Create(PayrollRun entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PayrollRun} entity
         */
        public async Task<PayrollRun> Update(long id, PayrollRun entity)
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
