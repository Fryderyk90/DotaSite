using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dota.Core.Models;

namespace Dota.Data.Services
{
    class DotaMatchInfoRepository : IDotaMatchInfoRepository
    {      
        async Task<DotaMatchInfo> IDotaMatchInfoRepository.GetAllMatchInfo(string matchId)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync("https://api.opendota.com/api/matches/5977269883");
            string dotaMatchJson = await getDotaStringTask;
            var allMatchInfo = DotaMatchInfo.FromJson(dotaMatchJson);

            return allMatchInfo;
        }
    }
}
