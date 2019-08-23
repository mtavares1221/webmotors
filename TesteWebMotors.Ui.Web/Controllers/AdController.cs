using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using TesteWebMotors.Domain.Entities;
using TesteWebMotors.Ui.Web.Helper;
using WebMotors.Infra.DTO;

namespace TesteWebMotors.Ui.Web.Controllers
{
    public class AdController : Controller
    {
        AdAPI _api = new AdAPI();
        public async Task<IActionResult> Index()
        {
            List<Ad> ads = new List<Ad>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/ad/getall");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                ads = JsonConvert.DeserializeObject<List<Ad>>(result);
            }
            return View(ads);
        }


        public async Task<List<ModelDTO>> ModelsByMake(int MakeID)
        {
            List<ModelDTO> models = new List<ModelDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/vehicle/make/" + MakeID + "/model");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                models = JsonConvert.DeserializeObject<List<ModelDTO>>(result);
            }

            models.Insert(0, new ModelDTO { ID = 0, Name = "Selecione" });

            return models;
        }

        public async Task<JsonResult> GetModelsByMake(int MakeID)
        {
            var models = await ModelsByMake(MakeID);

            return Json(new SelectList(models, "ID", "Name"));
        }



        public async Task<List<VersionDTO>> Versions(int MakeID, int ModelID)
        {
            List<VersionDTO> versions = new List<VersionDTO>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/vehicle/make/" + MakeID + "/model/" + ModelID + "/version");

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                versions = JsonConvert.DeserializeObject<List<VersionDTO>>(result);
            }

            versions.Insert(0, new VersionDTO { ID = 0, Name = "Selecione" });

            return versions;
        }

        public async Task<JsonResult> GetVersions(int MakeID, int ModelID)
        {
            var versions = await Versions(MakeID, ModelID);

            return Json(new SelectList(versions, "ID", "Name"));
        }


        public async Task<JsonResult> Register(Ad AdJs)
        {
            HttpClient client = _api.Initial();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));


            var jsonContent = JsonConvert.SerializeObject(AdJs);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage res = await client.PostAsync("api/Ad/Create", contentString);
            return Json("ok");
        }


        public async Task<JsonResult> Update(Ad AdJs)
        {
            HttpClient client = _api.Initial();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));


            var jsonContent = JsonConvert.SerializeObject(AdJs);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            HttpResponseMessage res = await client.PostAsync("api/Ad/Update", contentString);
            return Json("ok");
        }



        // GET: Ad/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var ad = new Ad();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/ad/getById/" + id);

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                ad = JsonConvert.DeserializeObject<Ad>(result);
            }
            return View(ad);
        }

        public async Task<List<MakeDTO>> GetMakes()
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

            return makes;
        }

        // GET: Ad/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.ListMake = await GetMakes();

            return View();
        }

        // GET: Ad/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var ad = new Ad();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/ad/getById/" + id);

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                ad = JsonConvert.DeserializeObject<Ad>(result);
            }

            var makes = await GetMakes();
            var make = makes.ToList().Where(x => x.Name == ad.Make).FirstOrDefault();

            var models = await ModelsByMake(make.ID);
            var model = models.ToList().Where(x => x.Name == ad.Model).FirstOrDefault();

            var versions = await Versions(make.ID, model.ID);

            SetSelecteds(makes, models, versions,ad);

            return View(ad);
        }

        private void SetSelecteds(List<MakeDTO> makes, List<ModelDTO> models, List<VersionDTO> versions, Ad ad)
        {
            var makesTotal = new SelectList(makes, "ID", "Name","Selected").ToList();
            var modelsTotal = new SelectList(models, "ID", "Name","Selected").ToList();
            var versionsTotal = new SelectList(versions, "ID", "Name","Selected").ToList();

            foreach (var makeT in makesTotal)
            {
                if (makeT.Text == ad.Make)
                {
                    makeT.Selected = true;
                }
            }

            foreach (var modelT in modelsTotal)
            {
                if (modelT.Text == ad.Make)
                {
                    modelT.Selected = true;
                }
            }

            foreach (var versonT in versionsTotal)
            {
                if (versonT.Text == ad.Make)
                {
                    versonT.Selected = true;
                }
            }
            ViewBag.ListMake = makesTotal;
            ViewBag.ListModel = modelsTotal;
            ViewBag.ListVersion = versionsTotal;
        }


        // GET: Ad/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            HttpClient client = _api.Initial();

            HttpResponseMessage response = await client.DeleteAsync("api/Ad?id=" + id);

            return RedirectToAction("Index");
        }


    }
}