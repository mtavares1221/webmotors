using System.Collections.Generic;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Domain.Repository
{
    public interface IMakeRepository
    {
        Task<IEnumerable<Make>> GetAll();
        Task<Make> GetById(int makeId);
    }
}
