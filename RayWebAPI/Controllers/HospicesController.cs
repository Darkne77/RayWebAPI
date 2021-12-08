using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RayWebAPI.EF;
using RayWebAPI.Entities;
using RayWebAPI.Models.Users;
using RayWebAPI.Services;

namespace RayWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospicesController : ControllerBase
    {
        private readonly IHospiceService _hospiceService;

        public HospicesController(
            IHospiceService hospiceService)
        {
            _hospiceService = hospiceService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var hospices = await _hospiceService.GetAll();
            return Ok(hospices);
        }
    }
}