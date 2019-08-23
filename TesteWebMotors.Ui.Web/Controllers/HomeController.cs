using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using TesteWebMotors.Ui.Web.Helper;
using TesteWebMotors.Ui.Web.Models;
using WebMotors.Infra.DTO;

namespace TesteWebMotors.Ui.Web.Controllers
{
    public class HomeController : Controller
    {
        AdAPI _api = new AdAPI();
        public async  Task<IActionResult> Index()
        {
            List<MakeDTO> makes = new List<MakeDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/vehicle/make");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                makes = JsonConvert.DeserializeObject<List<MakeDTO>>(result);
            }

            makes.Insert(0, new MakeDTO { ID = 0, Name = "Selecione" });

            ViewBag.Makes = makes;

            return View();
        }

        public async Task<JsonResult> GetModelsByMake(int MakeID)
        {
            List<ModelDTO> models = new List<ModelDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/vehicle/make/"+MakeID+"/model");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                models = JsonConvert.DeserializeObject<List<ModelDTO>>(result);
            }

            models.Insert(0, new ModelDTO { ID = 0, Name = "Selecione" });

            ViewBag.ListModels = models;

            return Json(new SelectList(models,"ID","Name"));
        }


        public async Task<JsonResult> GetVersions(int MakeID,int ModelID)
        {
            List<VersionDTO> versions = new List<VersionDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/vehicle/make/"+ MakeID + "/model/"+ ModelID + "/version");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                versions = JsonConvert.DeserializeObject<List<VersionDTO>>(result);
            }

            versions.Insert(0, new VersionDTO { ID = 0, Name = "Selecione" });

            ViewBag.ListModels = versions;

            return Json(new SelectList(versions, "ID", "Name"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
