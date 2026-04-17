using Microsoft.EntityFrameworkCore;
using TALLY_APP.Models;

namespace TALLY_APP.Data
{
    /**
     * =====================================================
     * APPLICATION DB CONTEXT
     * =====================================================
     *
     * Description:
     * Central EF Core DbContext for TALLY system.
     * Auto-generated from database_schema.json
     *
     * Includes:
     * - DbSet mappings
     * - Model configuration entry point
     */
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /**
         * DbSet for DashboardWidget
         */
        public DbSet<DashboardWidget> DashboardWidget { get; set; }
        /**
         * DbSet for LedgerAccount
         */
        public DbSet<LedgerAccount> LedgerAccount { get; set; }
        /**
         * DbSet for VoucherEntry
         */
        public DbSet<VoucherEntry> VoucherEntry { get; set; }
        /**
         * DbSet for PartyDirectory
         */
        public DbSet<PartyDirectory> PartyDirectory { get; set; }
        /**
         * DbSet for BankAccount
         */
        public DbSet<BankAccount> BankAccount { get; set; }
        /**
         * DbSet for BankReconciliation
         */
        public DbSet<BankReconciliation> BankReconciliation { get; set; }
        /**
         * DbSet for CurrencyExchange
         */
        public DbSet<CurrencyExchange> CurrencyExchange { get; set; }
        /**
         * DbSet for StockItem
         */
        public DbSet<StockItem> StockItem { get; set; }
        /**
         * DbSet for StockGroup
         */
        public DbSet<StockGroup> StockGroup { get; set; }
        /**
         * DbSet for BatchRegister
         */
        public DbSet<BatchRegister> BatchRegister { get; set; }
        /**
         * DbSet for StockMovement
         */
        public DbSet<StockMovement> StockMovement { get; set; }
        /**
         * DbSet for Godown
         */
        public DbSet<Godown> Godown { get; set; }
        /**
         * DbSet for GSTEntry
         */
        public DbSet<GSTEntry> GSTEntry { get; set; }
        /**
         * DbSet for VATServiceTax
         */
        public DbSet<VATServiceTax> VATServiceTax { get; set; }
        /**
         * DbSet for GSTReturn
         */
        public DbSet<GSTReturn> GSTReturn { get; set; }
        /**
         * DbSet for TDSTCSEntry
         */
        public DbSet<TDSTCSEntry> TDSTCSEntry { get; set; }
        /**
         * DbSet for Employee
         */
        public DbSet<Employee> Employee { get; set; }
        /**
         * DbSet for PayrollRun
         */
        public DbSet<PayrollRun> PayrollRun { get; set; }
        /**
         * DbSet for Payslip
         */
        public DbSet<Payslip> Payslip { get; set; }
        /**
         * DbSet for StatutoryDeduction
         */
        public DbSet<StatutoryDeduction> StatutoryDeduction { get; set; }
        /**
         * DbSet for PaymentEntry
         */
        public DbSet<PaymentEntry> PaymentEntry { get; set; }
        /**
         * DbSet for PaymentReminder
         */
        public DbSet<PaymentReminder> PaymentReminder { get; set; }
        /**
         * DbSet for BankIntegration
         */
        public DbSet<BankIntegration> BankIntegration { get; set; }
        /**
         * DbSet for TrialBalance
         */
        public DbSet<TrialBalance> TrialBalance { get; set; }
        /**
         * DbSet for BalanceSheet
         */
        public DbSet<BalanceSheet> BalanceSheet { get; set; }
        /**
         * DbSet for ProfitLoss
         */
        public DbSet<ProfitLoss> ProfitLoss { get; set; }
        /**
         * DbSet for CashFlowStatement
         */
        public DbSet<CashFlowStatement> CashFlowStatement { get; set; }
        /**
         * DbSet for StockReport
         */
        public DbSet<StockReport> StockReport { get; set; }
        /**
         * DbSet for SalesPurchaseSummary
         */
        public DbSet<SalesPurchaseSummary> SalesPurchaseSummary { get; set; }
        /**
         * DbSet for Branch
         */
        public DbSet<Branch> Branch { get; set; }
        /**
         * DbSet for BranchConsolidation
         */
        public DbSet<BranchConsolidation> BranchConsolidation { get; set; }
        /**
         * DbSet for BranchPerformance
         */
        public DbSet<BranchPerformance> BranchPerformance { get; set; }
        /**
         * DbSet for SystemUser
         */
        public DbSet<SystemUser> SystemUser { get; set; }
        /**
         * DbSet for AuditLog
         */
        public DbSet<AuditLog> AuditLog { get; set; }
        /**
         * DbSet for SecuritySettings
         */
        public DbSet<SecuritySettings> SecuritySettings { get; set; }
        /**
         * DbSet for AutomationRule
         */
        public DbSet<AutomationRule> AutomationRule { get; set; }
        /**
         * DbSet for Budget
         */
        public DbSet<Budget> Budget { get; set; }
        /**
         * DbSet for ForexTransaction
         */
        public DbSet<ForexTransaction> ForexTransaction { get; set; }
        /**
         * DbSet for CustomReport
         */
        public DbSet<CustomReport> CustomReport { get; set; }


        /**
         * Model configuration entry point
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==============================
            // AUTO GENERATED CONFIG SECTION
            // ==============================

            // Relationships and constraints can be extended here
        }
    }
}
