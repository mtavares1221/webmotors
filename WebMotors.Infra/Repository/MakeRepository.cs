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
    public class MakeRepository : IMakeRepository
    {
        private readonly HttpClient _httpClient;

        public MakeRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Make>> GetAll()
        {
            var response = await _httpClient.GetAsync("http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");
            var content = await response.Content.ReadAsStringAsync();
            var makesInfos = JsonConvert.DeserializeObject<IList<MakeDTO>>(content);

            return makesInfos.Select(makesInfo => new Make()
            {
                ID = makesInfo.ID,
                Name = makesInfo.Name
            });
        }

        public async Task<Make> GetById(int makeId)
        {
            var response = await _httpClient.GetAsync("http://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");
            var content = await response.Content.ReadAsStringAsync();
            var makesInfos = JsonConvert.DeserializeObject<IList<MakeDTO>>(content);

            var makeInfo = makesInfos.Where(makesInfo => makesInfo.ID == makeId).FirstOrDefault();

            return new Make()
            {
                ID = makeInfo.ID,
                Name = makeInfo.Name
            };

        }
    }
}
