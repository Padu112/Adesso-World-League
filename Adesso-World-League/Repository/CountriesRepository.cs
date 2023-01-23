using Adesso_World_League.Entities;
using Adesso_World_League.Helpers;
using Adesso_World_League.Models;
using Adesso_World_League.Repository.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Adesso_World_League.Repository
{
    public class CountriesRepository : ICountriesRepository
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public CountriesRepository(
            DataContext context,
           IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountriesModel>> GetAllCountries()
        {
            return await _context.Countries.Include(x => x.Teams).ProjectTo<CountriesModel>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return await _context.Team.ToListAsync();
        }

        public async Task<SavedGroups> SaveGroups(SavedGroups savedGroup)
        {
             _context.SavedGroups.Add(savedGroup);
             _context.SaveChangesAsync();
            
            return savedGroup;
        }
    }
}