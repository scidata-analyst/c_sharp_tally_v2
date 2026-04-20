using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.DTOs.Request.GSTTaxation;
using TALLY_APP.DTOs.Response.GSTTaxation;

namespace TALLY_APP.Interfaces.GSTTaxation
{
    /**
     * =====================================================
     * Interface: IVATServiceTaxService
     * =====================================================
     *
     * Purpose:
     * Defines contract for VATServiceTax business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IVATServiceTaxService
    {
        /**
         * Get all records
         */
        Task<List<VATServiceTaxResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<VATServiceTaxResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<VATServiceTaxResponse> View(long id);

        /**
         * Create new record
         */
        Task<VATServiceTaxResponse> Create(VATServiceTaxRequest request);

        /**
         * Update existing record
         */
        Task<VATServiceTaxResponse> Update(long id, VATServiceTaxRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
