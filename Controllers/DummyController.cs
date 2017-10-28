using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;

using TriNimbus_SimpleAPI.Models;

namespace TriNimbus_SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    public class DummyController : Controller
    {
        
        public DummyController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";            
        }

    }
}