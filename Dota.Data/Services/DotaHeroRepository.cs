using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public class DotaHeroRepository : IDotaHeroRepository
    {
         
        async Task<DotaHero[]> IDotaHeroRepository.GetDotaHeroesAsync(string heroUri)
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync(heroUri);
            string heroInfo = await getDotaStringTask;
            var allHeroes = DotaHero.FromJson(heroInfo);

            return allHeroes;
        }


    }
}
