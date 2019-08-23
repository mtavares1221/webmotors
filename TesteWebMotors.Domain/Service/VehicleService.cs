using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;
using TesteWebMotors.Domain.Repository;

namespace TesteWebMotors.Domain.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IMakeRepository _makeRepository;
        private readonly IModelRepository _modelRepository;
        private readonly IVersionRepository _versionRepository;

        public VehicleService( IMakeRepository makeRepository,IModelRepository modelRepository,IVersionRepository versionRepository)
        {
            _makeRepository = makeRepository;
            _modelRepository = modelRepository;
            _versionRepository = versionRepository;
        }

        public async Task<IEnumerable<Make>> GetMakes()
        {
            var makes = await _makeRepository.GetAll();

            return makes;
        }

        public async Task<Make> GetMakeById(int makeId)
        {
            var makes = await _makeRepository.GetAll();
            var make = makes.Where(x => x.ID == makeId).FirstOrDefault();

            return make;
        }

        public async  Task<IEnumerable<Model>> GetModelsByMake(int makeId)
        {
            var make = await GetMakeById(makeId);
            var models = await _modelRepository.GetByMake(make);
            return models;
        }

        public async Task<Model> GetModel(int modelId, Make make)
        {
            var models = await _modelRepository.GetByMake(make);
            var model = models.Where(x => x.ID == modelId).FirstOrDefault();
            return model;
        }

        public async Task<IEnumerable<Entities.Version>> GetVersions(int makeId,int modelId)
        {
            var make = await GetMakeById(makeId);
            var model = await GetModel(modelId,make);
            var version = await _versionRepository.GetByModel(model);
            return version;
        }
    }
}
