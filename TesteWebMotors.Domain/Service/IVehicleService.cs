using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Domain.Service
{ 
    public interface IVehicleService
    {
        //Task<IEnumerable<Make>> GetAllMakes();
        //Task<Make> GetMakeById(int makeId);

        //Task<IEnumerable<Model>> GetModelByMake(Make make);

        //Task<IEnumerable<Entities.Version>> GetVersionByModel(Model model);

        Task<IEnumerable<Make>> GetMakes();

        Task<Make> GetMakeById(int makeId);

        Task<IEnumerable<Model>> GetModelsByMake(int makeId);
        Task<Model> GetModel(int modelId, Make make);

        Task<IEnumerable<Entities.Version>> GetVersions(int makeId, int modelId);
    }
}
