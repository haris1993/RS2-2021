using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodController : BaseCRUDController<Model.Proizvodi, Model.ProizvodSearchObject, Model.Requests.ProizvodiInsertRequest, Model.Requests.ProizvodiUpdateRequest>
    {
        public ProizvodController(IProizvodService proizvodService) : base(proizvodService)
        {

        }
    }
}
