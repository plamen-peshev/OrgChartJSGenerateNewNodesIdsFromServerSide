using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace OrgChartJSGenerateNewNodesIdsFromServerSide.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update([FromBody] JsonElement args)
        {
            System.Threading.Thread.Sleep(1500);
            var clientId = args.GetProperty("data").GetProperty("id").ToString();

            Random rnd = new Random();
            int serverId = rnd.Next();//Generate id from the server it could be SQL server

            var old_new_ids = new Dictionary<string, string>();
            old_new_ids.Add(clientId, serverId.ToString());
            return Json(old_new_ids);
        }
    }
}