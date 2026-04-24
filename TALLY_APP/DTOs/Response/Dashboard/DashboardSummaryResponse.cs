using System.Collections.Generic;

namespace TALLY_APP.DTOs.Response.Dashboard
{
    public class DashboardSummaryResponse
    {
        public decimal NetRevenue { get; set; }
        public decimal Expenses { get; set; }
        public decimal NetProfit { get; set; }
        public decimal TotalReceivable { get; set; }
        public decimal TotalPayable { get; set; }
        public decimal StockValue { get; set; }
        public decimal GstLiability { get; set; }
        public List<DashboardActivityResponse> RecentActivities { get; set; }
        public List<BankSummaryResponse> BankBalances { get; set; }
    }

    public class DashboardActivityResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeAgo { get; set; }
        public string Type { get; set; } // Success, Danger, Info, Warning
        public string Amount { get; set; }
    }

    public class BankSummaryResponse
    {
        public string BankName { get; set; }
        public decimal Balance { get; set; }
        public bool IsPositive { get; set; }
    }
}
