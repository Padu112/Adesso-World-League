using Adesso_World_League.Entities;
using Adesso_World_League.Repository.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Adesso_World_League.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class GroupingController : ControllerBase
    {
        private ICountriesRepository _repository;
        private readonly IMapper _mapper;

        public GroupingController(ICountriesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("GetAllCountries")]
        public IActionResult GetAllCountries()
        {
            return Ok(_repository.GetAllCountries());
        }

        [HttpGet("GetAllTeams")]
        public IActionResult GetAllTeams()
        {
            return Ok(_repository.GetAllTeams());
        }

        [HttpGet("CreateGroupingAsync/{GroupSize}/{firstName}/{lastName}")]
        public async Task<IActionResult> CreateGroupingAsync(int GroupSize, string firstName, string lastName)
        {
            var teams = await _repository.GetAllTeams();

            var createdGroups = Helpers.CreateGroup.CreateGrouping(GroupSize, teams, firstName, lastName);
            await _repository.SaveGroups(new SavedGroups
            {
                FirstName = firstName,
                LastName = lastName,
                Grouping = JsonConvert.SerializeObject(createdGroups)
            });

            //to do unit tests

            return Ok(createdGroups);
        }
    }
}