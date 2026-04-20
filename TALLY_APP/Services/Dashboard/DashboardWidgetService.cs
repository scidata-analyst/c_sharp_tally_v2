using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.Dashboard;

using Mapster;
using TALLY_APP.Interfaces.Dashboard;
using TALLY_APP.DTOs.Request.Dashboard;
using TALLY_APP.DTOs.Response.Dashboard;

using TALLY_APP.Models.Dashboard;

namespace TALLY_APP.Services.Dashboard
{
    /**
     * @class DashboardWidgetService
     * @description Business logic layer for DashboardWidget module.
     */
    public class DashboardWidgetService : IDashboardWidgetService
    {
        private readonly DashboardWidgetRepository _repository;

        /**
         * @constructor
         * @param {DashboardWidgetRepository} repository
         */
        public DashboardWidgetService(DashboardWidgetRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<DashboardWidget>>}
         */
        

        public async Task<List<DashboardWidgetResponse>> All()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<DashboardWidgetResponse>>();
        }

        public async Task<List<DashboardWidgetResponse>> Index()
        {
            var entities = await _repository.GetAllAsync();
            return entities.Adapt<List<DashboardWidgetResponse>>();
        }


        /**
         * @method View
         * @param {long} id
         * @returns {Task<DashboardWidget>}
         */
        public async Task<DashboardWidgetResponse> View(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity.Adapt<DashboardWidgetResponse>();
        }

        /**
         * @method Create
         * @param {DashboardWidget} entity
         */
        public async Task<DashboardWidgetResponse> Create(DashboardWidgetRequest request)
        {
            var entity = request.Adapt<DashboardWidget>();
            await _repository.AddAsync(entity);
            return entity.Adapt<DashboardWidgetResponse>();
        }

        /**
         * @method Update
         * @param {long} id
         * @param {DashboardWidget} entity
         */
        public async Task<DashboardWidgetResponse> Update(long id, DashboardWidgetRequest request)
        {
            var entity = request.Adapt<DashboardWidget>();
            entity.Id = id;
            await _repository.UpdateAsync(entity);
            return entity.Adapt<DashboardWidgetResponse>();
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



