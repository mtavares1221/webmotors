using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Domain.Repository
{
    public interface IVersionRepository
    {
        Task<IEnumerable<Entities.Version>> GetByModel(Model model);
    }
}
