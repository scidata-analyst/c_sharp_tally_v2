using System.Collections.Generic;
using System.Threading.Tasks;
using AdditionalFeatures.DTOs.Request;
using AdditionalFeatures.DTOs.Response;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Interface: ICustomReportService
     * =====================================================
     *
     * Purpose:
     * Defines contract for CustomReport business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface ICustomReportService
    {
        /**
         * Get all records
         */
        Task<List<CustomReportResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<CustomReportResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<CustomReportResponse> View(long id);

        /**
         * Create new record
         */
        Task<CustomReportResponse> Create(CustomReportRequest request);

        /**
         * Update existing record
         */
        Task<CustomReportResponse> Update(long id, CustomReportRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
