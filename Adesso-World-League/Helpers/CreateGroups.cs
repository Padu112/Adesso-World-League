using Adesso_World_League.Entities;

namespace Adesso_World_League.Helpers
{
    public static class CreateGroup
    {
        public static AllocatedGroups CreateGrouping(int groupSize, List<Team> teams, string firstName, string lastName)
        {
            var teamCapacity = 4;

            if (groupSize == 4)
            {
                teamCapacity = 8;
            }

            var groupLetter = new Dictionary<int, string>()
        {
            {0,"A"},
            {1,"B"},
            {2,"C"},
            {3,"D"},
            {4,"E"},
            {5,"F"},
            {6,"G"},
            {7,"H"}
        };

            var teamsCopy = teams;
            var groups = new List<Group>();

            for (int i = 0; i < groupSize; i++)
            {
                var groupedTeams = teamsCopy.GroupBy(x => x.CountriesId).Select(y => y.First()).Take(teamCapacity);

                var group = new Group
                {
                    GroupName = groupLetter[i],
                    Teams = groupedTeams.ToList(),
                };
                groups.Add(group);
                foreach (var team in groupedTeams)
                {
                    teamsCopy.Remove(team);
                }
            }

            return new AllocatedGroups { Groups = groups };
        }
    }
}