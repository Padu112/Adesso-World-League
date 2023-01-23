
using Adesso_World_League.Entities;
using Adesso_World_League.Models;
using AutoMapper;

public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
        CreateMap<Countries, CountriesModel>()
            .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
            .ForMember(d => d.Teams, o => o.MapFrom(s => s.Teams));

        CreateMap<Team, TeamModel>()
           .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
           .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
           .ForMember(d => d.CountriesId, o => o.MapFrom(s => s.CountriesId));




    }
    }
