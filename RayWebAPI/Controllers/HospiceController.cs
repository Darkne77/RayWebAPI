using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RayWebAPI.EF;
using RayWebAPI.Models;

namespace RayWebAPI.Controllers
{
    [ApiController]
    [Route("api/Hospice")]
    public class HospiceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Hospice> GetHospices()
        {
            var hospices = new List<Hospice>();
            using (var dbContext = new RayDbContext())
            {
                hospices.AddRange(dbContext.Hospices.ToList());
            }
            return hospices;
        }
    }
}