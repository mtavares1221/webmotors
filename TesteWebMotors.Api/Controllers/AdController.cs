using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteWebMotors.Api.Models;
using TesteWebMotors.Domain.Entities;

namespace TesteWebMotors.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdController : Controller
    {
        private readonly AdContext _context;
        public AdController(AdContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Ad>> GetAll()
        {
            var ads = await _context.Ads.ToListAsync();
            return ads;
        }

        [HttpGet("GetById/{id}")]
        public async Task<Ad> GetById([FromRoute] int id)
        {
            var ad = await _context.Ads.FirstOrDefaultAsync(m => m.ID == id);
            return ad;
        }

        [HttpPost("Update")]
        public async Task Update([FromBody] Ad ad)
        {
            _context.Update(ad);
            await _context.SaveChangesAsync();
        }


        [HttpPost("Create")]
        public async  Task Create([FromBody] Ad ad)
        {
            _context.Add(ad);
            await _context.SaveChangesAsync();
        }

    
        public async Task Delete(int id)
        {
            var ad = await GetById(id);
            _context.Remove(ad);
            await _context.SaveChangesAsync();
        }


    }
}