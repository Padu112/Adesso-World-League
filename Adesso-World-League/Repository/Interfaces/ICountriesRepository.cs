using Adesso_World_League.Entities;
using Adesso_World_League.Models;

namespace Adesso_World_League.Repository.Interfaces
{
    public interface ICountriesRepository
    {
        Task<IEnumerable<CountriesModel>> GetAllCountries();

        Task<List<Team>> GetAllTeams();

        Task<SavedGroups> SaveGroups(SavedGroups savedGroup);
    }
}