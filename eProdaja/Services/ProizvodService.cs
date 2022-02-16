using AutoMapper;
using eProdaja.Controllers;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi, Model.ProizvodSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodService
    {
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IEnumerable<Model.Proizvodi> Get(Model.ProizvodSearchObject search = null)
        {
            var entity = _context.Set<Database.Proizvodi>().AsQueryable();

            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            if (search.VsrtaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VsrtaId);
            }

            if (search?.IncludeJedinicaMjere == true)
            {
                entity = entity.Include(x => x.JedinicaMjere);
            }

            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Proizvodi>>(list);
        }


        //BAD---
        //public override IEnumerable<Model.Proizvodi> Get()
        //{
        //    return base.Get();
        //}

        //public IEnumerable<Model.Proizvodi> GetByName(string name)
        //{
        //    return base.Get().Where(x => x.Naziv.Contains(name)).ToList();
        //}

        //public IEnumerable<Model.Proizvodi> GetByVrstaId(int vrstaId)
        //{
        //    return base.Get().Where(x => x.VrstaId == vrstaId).ToList();
        //}

        //public IEnumerable<Model.Proizvodi> GetByIdAndNaziv(int vrstaId, string name)
        //{
        //    return base.Get().Where(x => x.VrstaId == vrstaId && x.Naziv.Contains(name)).ToList();
        //}
    }
}
