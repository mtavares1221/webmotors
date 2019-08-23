using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;
using TesteWebMotors.Domain.Repository;
using TesteWebMotors.Domain.Service;

namespace TesteWebMotors.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("make")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            var makes = await _vehicleService.GetMakes();

            return makes;
        }
        [HttpGet("make/{makeId}/model")]
        public async Task<IEnumerable<Model>> GetModels([FromRoute]int makeId)
        {
            var models = await _vehicleService.GetModelsByMake(makeId);
            return models;
        }

        [HttpGet("make/{makeId}/model/{modelId}/version")]
        public async Task<IEnumerable<Domain.Entities.Version>> GetVersion([FromRoute]int makeId, [FromRoute]int modelId)
        {
            var versions = await _vehicleService.GetVersions(makeId, modelId);
            return versions;
        }
    }
}