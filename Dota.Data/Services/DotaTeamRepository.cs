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

        async Task<List<DotaProPlayer>> IDotaTeamRepository.PlayersInTeam(long teamId, List<DotaProPlayer> proPlayers)
        {
            List<DotaProPlayer> teamMembers = new List<DotaProPlayer>();
            foreach (var player in proPlayers)
            {
                if (player.TeamId == teamId)
                {
                    teamMembers.Add(player);    
                }
                
            }
            return teamMembers;
        }
    }
}