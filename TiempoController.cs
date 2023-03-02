using Microsoft.AspNetCore.Mvc;
using Layer.Entity;
using Layer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSeoga.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TiempoController : Controller
    {
        [HttpGet("Listar")]
        public List<TiempoEntity> Listar()
        {
            TiempoDomain oTiempoDomain = new TiempoDomain();
            return oTiempoDomain.Listar();
        }
    }
}
