using System.Threading.Tasks;
using Kontent.Ai.Boilerplate.Models.ContentTypes;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Urls.Delivery.QueryParameters;
 using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Kontent.Ai.Boilerplate.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        public HomeController(IDeliveryClient deliveryClient, ILogger<HomeController> logger) : base(deliveryClient, logger)
        {

        }

        public async Task<ViewResult> Index()
        {
            var response = await DeliveryClient.GetItemsAsync<Blog>(
                new LimitParameter(6),
                new DepthParameter(1),
                new OrderParameter($"elements.{Blog.TitleCodename}")
            );

            return View(response.Items);
        }
    }
}
