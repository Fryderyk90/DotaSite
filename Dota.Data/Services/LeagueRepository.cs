using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public class LeagueRepository : IDotaLeagueRepository
    {
        async Task<DotaLeague[]> IDotaLeagueRepository.GetAllLeguesAsync()
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync("https://api.opendota.com/api/leagues");
            string dotaString = await getDotaStringTask;
            var allLeagues = DotaLeague.FromJson(dotaString);

            return allLeagues;
        }       
    }
}
