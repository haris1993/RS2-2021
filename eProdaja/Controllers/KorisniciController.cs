using eProdaja.Database;
using eProdaja.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private IKorisniciService _korisniciService { get; set; }

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get()
        {
            return _korisniciService.Get();
        }
    }
}
