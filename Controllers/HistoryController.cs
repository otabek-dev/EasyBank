﻿using EasyBank.DB;
using EasyBank.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin,Director")]
    public class HistoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HistoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<HistoryController>
        [HttpGet]
        public IEnumerable<History> Get()
        {
            return _context.History.ToList();
        }
    }
}
