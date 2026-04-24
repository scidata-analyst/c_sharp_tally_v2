using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    public interface ISystemUserService
    {
        Task<List<SystemUserResponse>> All();
        Task<PaginatedSystemUserResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "asc");
        Task<SystemUserResponse> View(long id);
        Task<SystemUserResponse> Create(SystemUserRequest request);
        Task<SystemUserResponse> Update(long id, SystemUserRequest request);
        Task<bool> Delete(long id);
    }
}
