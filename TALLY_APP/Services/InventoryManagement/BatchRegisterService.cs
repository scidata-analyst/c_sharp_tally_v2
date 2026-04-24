using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Repositories.InventoryManagement;
using Mapster;
using TALLY_APP.Interfaces.InventoryManagement;
using TALLY_APP.DTOs.Request.InventoryManagement;
using TALLY_APP.DTOs.Response.InventoryManagement;
using TALLY_APP.Models.InventoryManagement;

namespace TALLY_APP.Services.InventoryManagement
{
    public class BatchRegisterService : IBatchRegisterService
    {
        private readonly BatchRegisterRepository _repository;

        public BatchRegisterService(BatchRegisterRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BatchRegisterResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<BatchRegisterResponse>>();
        }

        public async Task<PaginatedBatchRegisterResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<BatchRegisterResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedBatchRegisterResponse
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

        public async Task<BatchRegisterResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<BatchRegisterResponse>();
        }

        public async Task<BatchRegisterResponse> Create(BatchRegisterRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BatchRegister>();
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<BatchRegisterResponse>();
        }

        public async Task<BatchRegisterResponse> Update(long id, BatchRegisterRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<BatchRegister>();
            entity.Id = id;
            entity.UpdatedAt = DateTime.UtcNow;
            await _repository.Update(entity);
            return entity.Adapt<BatchRegisterResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
