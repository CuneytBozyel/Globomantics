using Shared.Models;

namespace GlobomanticsApi.Services
{
    public interface IStatisticsRepo
    {
        StatisticsModel GetStatistics();
    }
}