using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using Mapster;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;
using TALLY_APP.Models.RemoteAccessSecurity;

namespace TALLY_APP.Services.RemoteAccessSecurity
{
    public class SecuritySettingsService : ISecuritySettingsService
    {
        private readonly SecuritySettingsRepository _repository;

        public SecuritySettingsService(SecuritySettingsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<SecuritySettingsResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<SecuritySettingsResponse>>();
        }

        public async Task<PaginatedSecuritySettingsResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<SecuritySettingsResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedSecuritySettingsResponse
            {
                Data = data,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                TotalPages = totalPages,
                HasPreviousPage = page > 1,
                HasNextPage = page < totalPages
            };
        }

        public async Task<SecuritySettingsResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<SecuritySettingsResponse>();
        }

        public async Task<SecuritySettingsResponse> Create(SecuritySettingsRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<SecuritySettings>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<SecuritySettingsResponse>();
        }

        public async Task<SecuritySettingsResponse> Update(long id, SecuritySettingsRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<SecuritySettings>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<SecuritySettingsResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
