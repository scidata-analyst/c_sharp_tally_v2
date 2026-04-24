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
    public class SystemUserService : ISystemUserService
    {
        private readonly SystemUserRepository _repository;

        public SystemUserService(SystemUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<SystemUserResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<SystemUserResponse>>();
        }

        public async Task<PaginatedSystemUserResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<SystemUserResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedSystemUserResponse
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

        public async Task<SystemUserResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<SystemUserResponse>();
        }

        public async Task<SystemUserResponse> Create(SystemUserRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<SystemUser>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<SystemUserResponse>();
        }

        public async Task<SystemUserResponse> Update(long id, SystemUserRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<SystemUser>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<SystemUserResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
