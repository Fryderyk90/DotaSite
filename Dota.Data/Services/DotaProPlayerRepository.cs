using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public class DotaProPlayerRepository : IDotaProPlayerRepository
    {
    
        public async Task<List<DotaProPlayer>> AllProPlayers(string playerUri)
        {
             var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(playerUri);
            string playerInfo = await getDotaStringTask;
            var allPlayers = DotaProPlayer.FromJson(playerInfo).ToList();
            client.Dispose();
            return allPlayers;
        }
    }
}