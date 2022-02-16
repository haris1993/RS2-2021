using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaProfile : Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<Database.VrsteProizvoda, Model.VrsteProizvoda>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Model.Requests.ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<Model.Requests.ProizvodiUpdateRequest, Database.Proizvodi>();
        }
    }
}
