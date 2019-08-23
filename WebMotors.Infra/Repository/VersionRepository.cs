using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;
using TesteWebMotors.Domain.Repository;
using WebMotors.Infra.DTO;
using Version = TesteWebMotors.Domain.Entities.Version;

namespace WebMotors.Infra.Repository
{
    public class VersionRepository : IVersionRepository
    {
        private readonly HttpClient _httpClient;

        public VersionRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Version>> GetByModel(Model model)
        {
            var response = await _httpClient.GetAsync("http://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=" + model.ID);
            var content = await response.Content.ReadAsStringAsync();
            var versionsInfos = JsonConvert.DeserializeObject<IList<VersionDTO>>(content);

            return versionsInfos.Select(versionInfo => new Version()
            {
                ID = versionInfo.ID,
                Model = model,
                Name = versionInfo.Name
            });


        }
    }
}
