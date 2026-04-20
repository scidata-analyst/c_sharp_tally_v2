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
     * @class PayslipService
     * @description Business logic layer for Payslip module.
     */
    public class PayslipService : IPayslipService
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
        

        public async Task<List<PayslipResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PayslipResponse>>();
        }

        public async Task<List<PayslipResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<PayslipResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<Payslip>}
         */
        public async Task<PayslipResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<PayslipResponse>();
        }

        /**
         * @method Create
         * @param {Payslip} entity
         */
        public async Task<PayslipResponse> Create(PayslipRequest request)
        {
            var entity = request.Adapt<Payslip>();
            await _repository.AddAsync(entity);
            return entity.Adapt<PayslipResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {Payslip} entity
         */
        public async Task<PayslipResponse> Update(long id, PayslipRequest request)
        {
            var entity = request.Adapt<Payslip>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<PayslipResponse>();
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



