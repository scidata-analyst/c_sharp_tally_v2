using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.AdditionalFeatures;
using Mapster;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.DTOs.Request.AdditionalFeatures;
using TALLY_APP.DTOs.Response.AdditionalFeatures;
using TALLY_APP.Models.AdditionalFeatures;

namespace TALLY_APP.Services.AdditionalFeatures
{
    public class AutomationRuleService : IAutomationRuleService
    {
        private readonly AutomationRuleRepository _repository;
        public AutomationRuleService(AutomationRuleRepository repository) => _repository = repository;

        public async Task<PaginatedAutomationRuleResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            return new PaginatedAutomationRuleResponse { Data = items.Adapt<List<AutomationRuleResponse>>(), TotalCount = totalCount, Page = page, PageSize = pageSize, TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), HasPreviousPage = page > 1, HasNextPage = page < (int)Math.Ceiling(totalCount / (double)pageSize) };
        }

        public async Task<AutomationRuleResponse> Create(AutomationRuleRequest request) { var e = request.Adapt<AutomationRule>(); e.CreatedAt = e.UpdatedAt = DateTime.UtcNow; await _repository.Create(e); return e.Adapt<AutomationRuleResponse>(); }
        public async Task<AutomationRuleResponse> Update(long id, AutomationRuleRequest request) { var e = request.Adapt<AutomationRule>(); e.Id = id; e.UpdatedAt = DateTime.UtcNow; await _repository.Update(e); return e.Adapt<AutomationRuleResponse>(); }
        public async Task<bool> Delete(long id) { await _repository.Delete(id); return true; }
    }
}
