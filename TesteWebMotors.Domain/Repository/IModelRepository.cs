using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Domain.Repository
{
    public interface IModelRepository
    {
        Task<IEnumerable<Model>> GetByMake(Make make);

    }
}
