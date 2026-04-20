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
     * @class PayrollRunService
     * @description Business logic layer for PayrollRun module.
     */
    public class PayrollRunService : IPayrollRunService
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
        

        public async Task<List<PayrollRunResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PayrollRunResponse>>();
        }

        public async Task<List<PayrollRunResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PayrollRunResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<PayrollRun>}
         */
        public async Task<PayrollRunResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<PayrollRunResponse>();
        }

        /**
         * @method Create
         * @param {PayrollRun} entity
         */
        public async Task<PayrollRunResponse> Create(PayrollRunRequest request)
        {
            var entity = request.Adapt<PayrollRun>();
            await _repository.AddAsync(entity);
            return entity.Adapt<PayrollRunResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {PayrollRun} entity
         */
        public async Task<PayrollRunResponse> Update(long id, PayrollRunRequest request)
        {
            var entity = request.Adapt<PayrollRun>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<PayrollRunResponse>();
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



