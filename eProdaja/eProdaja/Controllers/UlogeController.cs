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
    public class UlogeController : BaseReadController<Model.Uloge, object>
    {
        public UlogeController(IReadService<Model.Uloge, object> service)
            : base(service)
        {
        }

    }
}
