using static _05.TeamworkProjects.Program;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split("-");
                string leader = arguments[0];
                string teamName = arguments[1];

                Team team = new Team(leader, teamName);

                Team teamExist = teams.Find(team => team.TeamName == teamName);
                Team leaderExist = teams.Find(x => x.Leader == leader);

                if (teamExist != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (leaderExist != null)
                {
                    Console.WriteLine($"{leader} cannot create another team!");
                }
                else
                {
                Console.WriteLine($"Team {teamName} has been created by {leader}!");
                teams.Add(team);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = input.Split("->");
                string memberName = arguments[0];
                string teamName = arguments[1];

                Team foundTeam = teams.Find(team => team.TeamName == teamName);
                Team foundMember = teams.Find(team => team.Members.Contains(memberName));

                if (Team.MemberExist(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }                
                else if (foundTeam != null)
                {
                    foundTeam.Members.Add(memberName);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<Team> validTeams = teams.FindAll(x => x.Members.Count > 0);
            List<Team> disbandTeams = teams.FindAll(x => x.Members.Count == 0);
            validTeams = validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName).ToList();
            disbandTeams = disbandTeams.OrderBy(x => x.TeamName).ToList();
            
            
            foreach (Team t in validTeams)
            {
                t.Members.Sort();
                Console.WriteLine($"{t.TeamName}");
                Console.WriteLine($"- {t.Leader}");
                Console.WriteLine($"-- {string.Join("\n-- ", t.Members)}");
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team t in disbandTeams)
            {
                Console.WriteLine(t.TeamName);
            }
        }

        public class Team
        {
            public Team(string leader, string teamName)
            {
                TeamName = teamName;
                Leader = leader;
                Members = new List<string>();
            }

            public string TeamName { get; set; }
            public string Leader { get; set; }
            public List<string> Members { get; set; }

            public static bool MemberExist(List<Team> teams, string memberName)
            {
                bool isExist = true;

                Team existingMember = teams.Find(team => team.Members.Contains(memberName));

                
                if (existingMember == null)
                {
                    existingMember = teams.Find(team => team.Leader.Contains(memberName));
                    if (existingMember == null)
                    {
                    isExist = false;
                    }
                }

                return isExist;
            }
        }
    }
}