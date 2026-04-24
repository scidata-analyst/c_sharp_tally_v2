using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    public interface IAutomationRuleService
    {
        Task<PaginatedAutomationRuleResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<AutomationRuleResponse> Create(AutomationRuleRequest request);
        Task<AutomationRuleResponse> Update(long id, AutomationRuleRequest request);
        Task<bool> Delete(long id);
    }
}
