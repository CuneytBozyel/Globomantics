using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Services;

namespace Globomantics.ViewComponents
{
    public class StatisticsViewComponent : ViewComponent
    {
        private readonly IConferenceService service;

        public StatisticsViewComponent(IConferenceService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await service.GetStatistics());
        }
    }
}
