using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace DNTFrameworkCore.TestWebApp.Application.Academy.Models
{
    public class AcademyMapProfile : Profile
    {
        public AcademyMapProfile()
        {
            CreateMap<Domain.Academy.Academy, AcademyModel>(MemberList.None)
                 .ReverseMap()
                 .ForMember(d => d.NormalizedTitle, m => m.MapFrom(s => s.AcademyName.ToUpperInvariant()));
        }
    }
}
