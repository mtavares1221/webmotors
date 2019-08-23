using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;
using TesteWebMotors.Domain.Repository;
using WebMotors.Infra.DTO;

namespace WebMotors.Infra.Repository
{
    public class ModelRepository : IModelRepository
    {
        private readonly HttpClient _httpClient;
        public ModelRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Model>> GetByMake(Make make)
        {
            var response = await _httpClient.GetAsync("http://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID=" + make.ID);
            var content = await response.Content.ReadAsStringAsync();
            var modelsInfos = JsonConvert.DeserializeObject<IList<ModelDTO>>(content);

            return modelsInfos.Select(modelsInfo => new Model()
            {
                ID = modelsInfo.ID,
                Make = make,
                Name = modelsInfo.Name
            });
        }
    }
}
