using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RayWebAPI.EF;
using RayWebAPI.Entities;

namespace RayWebAPI.Services
{
    public interface IHospiceService
    {
        Task<List<Hospice>> GetAll();
    }

    public class HospiceService : IHospiceService
    {
        private readonly RayDbContext _context;

        public HospiceService(RayDbContext context)
        {
            _context = context;
        }
        
        public Task<List<Hospice>> GetAll()
        {
            return _context.Hospices.ToListAsync();
        }
    }
}