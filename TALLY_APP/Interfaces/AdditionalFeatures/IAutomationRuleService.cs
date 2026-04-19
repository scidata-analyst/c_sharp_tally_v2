using System.Collections.Generic;
using System.Threading.Tasks;
using AdditionalFeatures.DTOs.Request;
using AdditionalFeatures.DTOs.Response;

namespace TALLY_APP.Interfaces.AdditionalFeatures
{
    /**
     * =====================================================
     * Interface: IAutomationRuleService
     * =====================================================
     *
     * Purpose:
     * Defines contract for AutomationRule business operations.
     * Acts as abstraction layer between Controller and Service.
     *
     * Architecture:
     * Controller  Interface  Service Implementation
     */
    public interface IAutomationRuleService
    {
        /**
         * Get all records
         */
        Task<List<AutomationRuleResponse>> All();

        /**
         * Get paginated records
         */
        Task<List<AutomationRuleResponse>> Index();

        /**
         * Get single record by ID
         */
        Task<AutomationRuleResponse> View(long id);

        /**
         * Create new record
         */
        Task<AutomationRuleResponse> Create(AutomationRuleRequest request);

        /**
         * Update existing record
         */
        Task<AutomationRuleResponse> Update(long id, AutomationRuleRequest request);

        /**
         * Delete record
         */
        Task<bool> Delete(long id);
    }
}
