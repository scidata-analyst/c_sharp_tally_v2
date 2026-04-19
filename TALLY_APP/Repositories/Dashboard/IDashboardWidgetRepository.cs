using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Models.Dashboard;

namespace TALLY_APP.Repositories.Dashboard
{
    /**
     * @interface IDashboardWidgetRepository
     * @description Defines database contract for DashboardWidget entity operations.
     */
    public interface IDashboardWidgetRepository
    {
        /**
         * @method GetAllAsync
         * @description Retrieves all DashboardWidget records from database.
         * @returns {Task<List<DashboardWidget>>}
         */
        Task<List<DashboardWidget>> GetAllAsync();

        /**
         * @method GetByIdAsync
         * @param {long} id - Primary key identifier
         * @returns {Task<DashboardWidget>}
         */
        Task<DashboardWidget> GetByIdAsync(long id);

        /**
         * @method AddAsync
         * @param {DashboardWidget} entity - Entity model
         */
        Task AddAsync(DashboardWidget entity);

        /**
         * @method UpdateAsync
         * @param {DashboardWidget} entity - Updated entity model
         */
        Task UpdateAsync(DashboardWidget entity);

        /**
         * @method DeleteAsync
         * @param {long} id - Primary key identifier
         */
        Task DeleteAsync(long id);
    }
}
