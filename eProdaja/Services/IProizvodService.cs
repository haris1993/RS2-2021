using eProdaja.Controllers;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodService : ICRUDService<Model.Proizvodi, Model.ProizvodSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {

    }
}
