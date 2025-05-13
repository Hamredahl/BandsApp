using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandsService = new BandService();

    [Route("")]
    public IActionResult Index()
    {
        var model = bandsService.GetAllBands();
        return View(model);
    }
}
