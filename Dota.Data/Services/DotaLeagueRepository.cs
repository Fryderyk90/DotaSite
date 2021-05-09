using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public class DotaLeagueRepository : IDotaLeagueRepository
    {
        async Task<DotaLeague[]> IDotaLeagueRepository.GetAllLeaguesAsync(string leagueUri)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(leagueUri);
            string dotaString = await getDotaStringTask;
            var allLeagues = DotaLeague.FromJson(dotaString);

            return allLeagues;
        }       

        
    }
}
