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
    public class StockMovementService : IStockMovementService
    {
        private readonly StockMovementRepository _repository;

        public StockMovementService(StockMovementRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StockMovementResponse>> All()
        {
            var entities = await _repository.All();
            return entities.Adapt<List<StockMovementResponse>>();
        }

        public async Task<PaginatedStockMovementResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc")
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 10;
            if (pageSize > 100) pageSize = 100;

            var (items, totalCount) = await _repository.Index(page, pageSize, search, sortColumn, sortDirection);
            var data = items.Adapt<List<StockMovementResponse>>();
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            return new PaginatedStockMovementResponse
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

        public async Task<StockMovementResponse> View(long id)
        {
            var entity = await _repository.View(id);
            return entity.Adapt<StockMovementResponse>();
        }

        public async Task<StockMovementResponse> Create(StockMovementRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<StockMovement>();
            entity.CreatedAt = DateTime.UtcNow;
            await _repository.Create(entity);
            return entity.Adapt<StockMovementResponse>();
        }

        public async Task<StockMovementResponse> Update(long id, StockMovementRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            var entity = request.Adapt<StockMovement>();
            entity.Id = id;
            await _repository.Update(entity);
            return entity.Adapt<StockMovementResponse>();
        }

        public async Task<bool> Delete(long id)
        {
            await _repository.Delete(id);
            return true;
        }
    }
}
