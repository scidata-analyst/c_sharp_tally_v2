using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TALLY_APP.Interfaces.Dashboard;
using TALLY_APP.DTOs.Response.Dashboard;
using TALLY_APP.Repositories.AccountingFinance;
using TALLY_APP.Repositories.ReportingAnalytics;
using TALLY_APP.Repositories.RemoteAccessSecurity;
using System.Linq;

namespace TALLY_APP.Services.Dashboard
{
    public class DashboardService : IDashboardService
    {
        // Mocking data for now as we don't have a dedicated "Summary" repo, 
        // but in a real app, this would aggregate from multiple repos.
        public async Task<DashboardSummaryResponse> GetSummary()
        {
            await Task.Delay(100); // Simulate DB work
            return new DashboardSummaryResponse
            {
                NetRevenue = 4820000,
                Expenses = 3140000,
                NetProfit = 1680000,
                TotalReceivable = 1240000,
                TotalPayable = 780000,
                StockValue = 3420000,
                GstLiability = 360000,
                RecentActivities = new List<DashboardActivityResponse>
                {
                    new DashboardActivityResponse { Title = "Payment Voucher #PV-2024-891", Description = "Recorded against Supplier ABC", TimeAgo = "2 min ago", Type = "primary", Amount = "₹45,000" },
                    new DashboardActivityResponse { Title = "Sales Invoice #SI-2024-3421", Description = "Created for Client XYZ", TimeAgo = "18 min ago", Type = "accent2", Amount = "₹1,20,000" },
                    new DashboardActivityResponse { Title = "Stock Transfer", Description = "Main Godown → Delhi Branch", TimeAgo = "1 hour ago", Type = "accent", Amount = "150 units" }
                },
                BankBalances = new List<BankSummaryResponse>
                {
                    new BankSummaryResponse { BankName = "HDFC Bank — Current A/c", Balance = 1842300, IsPositive = true },
                    new BankSummaryResponse { BankName = "ICICI Bank — Savings A/c", Balance = 610000, IsPositive = true },
                    new BankSummaryResponse { BankName = "SBI Bank — OD Account", Balance = -250000, IsPositive = false }
                }
            };
        }
    }
}
