using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace OrgChartJSGenerateNewNodesIdsFromServerSide.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(string id, string pid)
        {
            System.Threading.Thread.Sleep(1500);

            Random rnd = new Random();
            int serverId = rnd.Next();//Generate id from the server it could be SQL server

            return Json(new
            {
                id = serverId
            });
        }
    }
}