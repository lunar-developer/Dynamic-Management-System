using Microsoft.AspNetCore.Mvc;

namespace LunarSoft.Dms.Modules.MasterData.Controllers
{
    public class MasterDataController : Controller
    {
        public IActionResult Load()
        {
            ViewData["Message"] = "Master Data Management";
            return View("TableView");
        }
    }
}