using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public class DotaTeamRepository : IDotaTeamRepository
    {
        public List<DotaTeamRoster> TeamRoster(List<DotaTeam> teams, List<DotaProPlayer> proPlayers)
        {
            List<DotaTeamRoster> teamRoster = new List<DotaTeamRoster>();
            foreach (var player in proPlayers)
            {
                var team = teams.Find(t => t.TeamId == player.TeamId);
               
                    DotaTeamRoster roster = new DotaTeamRoster
                    {
                        Player = player,
                        Team = team
                    };

                    teamRoster.Add(roster);
               
               
            }
            return teamRoster;
        }

        async Task<List<DotaTeam>> IDotaTeamRepository.AllTeamsAsync(string teamUri)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(teamUri);
            string teamInfo = await getDotaStringTask;
            var allteams = DotaTeam.FromJson(teamInfo).ToList();
            client.Dispose();
            allteams.OrderByDescending(t => t.Rating);
            return allteams;
        }

        
    }
}