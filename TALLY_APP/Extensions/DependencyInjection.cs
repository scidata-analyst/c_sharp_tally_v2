using Microsoft.Extensions.DependencyInjection;
using TALLY_APP.Services.AccountingFinance;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Interfaces.AccountingFinance;
using TALLY_APP.Services.AdditionalFeatures;
using TALLY_APP.Repositories.AdditionalFeatures;
using TALLY_APP.Interfaces.AdditionalFeatures;
using TALLY_APP.Services.BankingPayments;
using TALLY_APP.Repositories.BankingPayments;
using TALLY_APP.Interfaces.BankingPayments;
using TALLY_APP.Services.Dashboard;
using TALLY_APP.Repositories.Dashboard;
using TALLY_APP.Interfaces.Dashboard;
using TALLY_APP.Services.GstTaxation;
using TALLY_APP.Repositories.GstTaxation;
using TALLY_APP.Interfaces.GstTaxation;
using TALLY_APP.Services.InventoryManagement;
using TALLY_APP.Repositories.InventoryManagement;
using TALLY_APP.Interfaces.InventoryManagement;
using TALLY_APP.Services.MultiLocationBranch;
using TALLY_APP.Repositories.MultiLocationBranch;
using TALLY_APP.Interfaces.MultiLocationBranch;
using TALLY_APP.Services.PayrollManagement;
using TALLY_APP.Repositories.PayrollManagement;
using TALLY_APP.Interfaces.PayrollManagement;
using TALLY_APP.Services.RemoteAccessSecurity;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using TALLY_APP.Interfaces.RemoteAccessSecurity;
using TALLY_APP.Services.ReportingAnalytics;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Interfaces.ReportingAnalytics;

namespace TALLY_APP.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            // AccountingFinance
            services.AddScoped<IBankAccountService, BankAccountService>();
            services.AddScoped<IBankReconciliationService, BankReconciliationService>();
            services.AddScoped<ICurrencyExchangeService, CurrencyExchangeService>();
            services.AddScoped<ILedgerAccountService, LedgerAccountService>();
            services.AddScoped<IPartyDirectoryService, PartyDirectoryService>();
            services.AddScoped<IVoucherEntryService, VoucherEntryService>();
            services.AddScoped<BankAccountRepository>();
            services.AddScoped<BankReconciliationRepository>();
            services.AddScoped<CurrencyExchangeRepository>();
            services.AddScoped<LedgerAccountRepository>();
            services.AddScoped<PartyDirectoryRepository>();
            services.AddScoped<VoucherEntryRepository>();

            // AdditionalFeatures
            services.AddScoped<IAutomationRuleService, AutomationRuleService>();
            services.AddScoped<IBudgetService, BudgetService>();
            services.AddScoped<ICustomReportService, CustomReportService>();
            services.AddScoped<IForexTransactionService, ForexTransactionService>();
            services.AddScoped<AutomationRuleRepository>();
            services.AddScoped<BudgetRepository>();
            services.AddScoped<CustomReportRepository>();
            services.AddScoped<ForexTransactionRepository>();

            // BankingPayments
            services.AddScoped<IBankIntegrationService, BankIntegrationService>();
            services.AddScoped<IPaymentEntryService, PaymentEntryService>();
            services.AddScoped<IPaymentReminderService, PaymentReminderService>();
            services.AddScoped<BankIntegrationRepository>();
            services.AddScoped<PaymentEntryRepository>();
            services.AddScoped<PaymentReminderRepository>();

            // Dashboard
            services.AddScoped<IDashboardWidgetService, DashboardWidgetService>();
            services.AddScoped<DashboardWidgetRepository>();

            // GstTaxation
            services.AddScoped<IGSTEntryService, GSTEntryService>();
            services.AddScoped<IGSTReturnService, GSTReturnService>();
            services.AddScoped<ITDSTCSEntryService, TDSTCSEntryService>();
            services.AddScoped<IVATServiceTaxService, VATServiceTaxService>();
            services.AddScoped<GSTEntryRepository>();
            services.AddScoped<GSTReturnRepository>();
            services.AddScoped<TDSTCSEntryRepository>();
            services.AddScoped<VATServiceTaxRepository>();

            // InventoryManagement
            services.AddScoped<IBatchRegisterService, BatchRegisterService>();
            services.AddScoped<IGodownService, GodownService>();
            services.AddScoped<IStockGroupService, StockGroupService>();
            services.AddScoped<IStockItemService, StockItemService>();
            services.AddScoped<IStockMovementService, StockMovementService>();
            services.AddScoped<BatchRegisterRepository>();
            services.AddScoped<GodownRepository>();
            services.AddScoped<StockGroupRepository>();
            services.AddScoped<StockItemRepository>();
            services.AddScoped<StockMovementRepository>();

            // MultiLocationBranch
            services.AddScoped<IBranchConsolidationService, BranchConsolidationService>();
            services.AddScoped<IBranchPerformanceService, BranchPerformanceService>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<BranchConsolidationRepository>();
            services.AddScoped<BranchPerformanceRepository>();
            services.AddScoped<BranchRepository>();

            // PayrollManagement
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPayrollRunService, PayrollRunService>();
            services.AddScoped<IPayslipService, PayslipService>();
            services.AddScoped<IStatutoryDeductionService, StatutoryDeductionService>();
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<PayrollRunRepository>();
            services.AddScoped<PayslipRepository>();
            services.AddScoped<StatutoryDeductionRepository>();

            // RemoteAccessSecurity
            services.AddScoped<IAuditLogService, AuditLogService>();
            services.AddScoped<ISecuritySettingsService, SecuritySettingsService>();
            services.AddScoped<ISystemUserService, SystemUserService>();
            services.AddScoped<AuditLogRepository>();
            services.AddScoped<SecuritySettingsRepository>();
            services.AddScoped<SystemUserRepository>();

            // ReportingAnalytics
            services.AddScoped<IBalanceSheetService, BalanceSheetService>();
            services.AddScoped<ICashFlowStatementService, CashFlowStatementService>();
            services.AddScoped<IProfitLossService, ProfitLossService>();
            services.AddScoped<ISalesPurchaseSummaryService, SalesPurchaseSummaryService>();
            services.AddScoped<IStockReportService, StockReportService>();
            services.AddScoped<ITrialBalanceService, TrialBalanceService>();
            services.AddScoped<BalanceSheetRepository>();
            services.AddScoped<CashFlowStatementRepository>();
            services.AddScoped<ProfitLossRepository>();
            services.AddScoped<SalesPurchaseSummaryRepository>();
            services.AddScoped<StockReportRepository>();
            services.AddScoped<TrialBalanceRepository>();


            return services;
        }
    }
}
