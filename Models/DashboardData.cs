using System;

namespace RedisDemo.Models
{
    [Serializable]
    public class DashboardData
    {
        public int TotalCustomerCount { get; set; }

        public int TotalRevenue { get; set; }

        public string TopSellingProductName { get; set; }

        public string TopSellingCountryName { get; set; }
    }
}
