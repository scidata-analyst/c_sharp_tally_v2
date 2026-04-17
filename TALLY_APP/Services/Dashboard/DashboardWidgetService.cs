using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.Dashboard;
using TALLY_APP.Models.Entities.Dashboard;

namespace TALLY_APP.Services.Dashboard
{
    /**
     * @class DashboardWidgetService
     * @description Business logic layer for DashboardWidget module.
     */
    public class DashboardWidgetService
    {
        private readonly IDashboardWidgetRepository _repository;

        /**
         * @constructor
         * @param {IDashboardWidgetRepository} repository
         */
        public DashboardWidgetService(IDashboardWidgetRepository repository)
        {
            _repository = repository;
        }

        /**
         * @method All
         * @returns {Task<List<DashboardWidget>>}
         */
        public async Task<List<DashboardWidget>> All()
        {
            return await _repository.GetAllAsync();
        }

        /**
         * @method View
         * @param {long} id
         * @returns {Task<DashboardWidget>}
         */
        public async Task<DashboardWidget> View(long id)
        {
            return await _repository.GetByIdAsync(id);
        }

        /**
         * @method Create
         * @param {DashboardWidget} entity
         */
        public async Task<DashboardWidget> Create(DashboardWidget entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        /**
         * @method Update
         * @param {long} id
         * @param {DashboardWidget} entity
         */
        public async Task<DashboardWidget> Update(long id, DashboardWidget entity)
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
