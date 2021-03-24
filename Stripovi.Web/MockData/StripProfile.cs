using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stripovi.Web.MockData
{
    public class StripProfile : Profile
    {
        public StripProfile()
        {
            CreateMap<Strip, Korpa>();
            CreateMap<Korpa, Strip>();
        }
    }
}
