using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    class HeroRepository : IHeroRepository
    {
        async Task<DotaHero[]> IHeroRepository.GetDotaHeroesAsync()
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync("https://api.opendota.com/api/heroes");
            string heroInfo = await getDotaStringTask;
            var allHeroes = DotaHero.FromJson(heroInfo);

            return allHeroes;
        }
    }
}
