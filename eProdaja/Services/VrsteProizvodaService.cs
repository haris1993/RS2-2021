using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class VrsteProizvodaService : BaseReadService<Model.VrsteProizvoda, Database.VrsteProizvoda, object>, IVrsteProizvodaService
    {
        //public eProdajaContext _context { get; set; }
        //protected readonly IMapper _mapper;

        public VrsteProizvodaService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        //public IEnumerable<Model.VrsteProizvoda> Get()
        //{
        //    return _context.VrsteProizvoda.ToList().Select(x => _mapper.Map<Model.VrsteProizvoda>(x)).ToList();
        //}

        //public Model.VrsteProizvoda GetById(int id)
        //{
        //    var entity = _context.VrsteProizvoda.Find(id);

        //    return _mapper.Map<Model.VrsteProizvoda>(entity);
        //}
    }
}
