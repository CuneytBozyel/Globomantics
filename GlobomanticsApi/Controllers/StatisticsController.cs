using GlobomanticsApi.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace GlobomanticsApi.Controllers
{
    [Route("v1/[controller]")]
    public class StatisticsController: Controller
    {
        private readonly IStatisticsRepo repo;

        public StatisticsController(IStatisticsRepo repo)
        {
            this.repo = repo;
        }
        public StatisticsModel Get()
        {
            return repo.GetStatistics();
        }
    }
}
