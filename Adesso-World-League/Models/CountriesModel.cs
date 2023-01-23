namespace Adesso_World_League.Models
{
    public class CountriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamModel> Teams { get; set; }
    }
}