namespace Adesso_World_League.Entities
{
    public class Countries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
    }
}