using System.Collections.Generic;
using System.Threading.Tasks;

namespace TALLY_APP.Repositories.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Repository Interface: IVATServiceTaxRepository
     * =====================================================
     *
     * Purpose:
     * Defines DB contract for VATServiceTax entity.
     */
    public interface IVATServiceTaxRepository
    {
        Task<List<VATServiceTax>> GetAllAsync();
        Task<VATServiceTax> GetByIdAsync(long id);
        Task AddAsync(VATServiceTax entity);
        Task UpdateAsync(VATServiceTax entity);
        Task DeleteAsync(long id);
    }
}
