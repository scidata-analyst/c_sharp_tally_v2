using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.RemoteAccessSecurity;
using TALLY_APP.DTOs.Response.RemoteAccessSecurity;

namespace TALLY_APP.Interfaces.RemoteAccessSecurity
{
    public interface ISecuritySettingsService
    {
        Task<List<SecuritySettingsResponse>> All();
        Task<PaginatedSecuritySettingsResponse> Index(int page = 1, int pageSize = 10, string search = "", string sortColumn = "Id", string sortDirection = "desc");
        Task<SecuritySettingsResponse> View(long id);
        Task<SecuritySettingsResponse> Create(SecuritySettingsRequest request);
        Task<SecuritySettingsResponse> Update(long id, SecuritySettingsRequest request);
        Task<bool> Delete(long id);
    }
}
