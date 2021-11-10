using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RedisDemo.Models;
using System;
using System.Threading.Tasks;

namespace RedisDemo.Controllers
{
    public class HomeController : Controller
    {
        private IDistributedCache _distributedCache;

        public HomeController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public async Task<ActionResult> SaveRedisCache()
        {
            var dashboadData = new DashboardData
            {
                TotalCustomerCount = 100450,
                TotalRevenue = 12908092,
                TopSellingCountryName = "United States",
                TopSellingProductName = "Macbook Pro"
            };

            var tomorrow = DateTime.Now.Date.AddDays(1);
            var totalSeconds = tomorrow.Subtract(DateTime.Now).TotalSeconds;

            var distributedCacheEntryOptions = new DistributedCacheEntryOptions();
            distributedCacheEntryOptions.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(totalSeconds);
            distributedCacheEntryOptions.SlidingExpiration = null;

            var jsonData = JsonConvert.SerializeObject(dashboadData);
            await _distributedCache.SetStringAsync("DashboardData", jsonData, distributedCacheEntryOptions);

            return View();
        }

        public async Task<ActionResult> Dashboard()
        {
            var jsonData = await _distributedCache.GetStringAsync("DashboardData");
            var dashboardData = JsonConvert.DeserializeObject<DashboardData>(jsonData);
            ViewBag.DashboardData = dashboardData;
            return View();
        }
    }
}
