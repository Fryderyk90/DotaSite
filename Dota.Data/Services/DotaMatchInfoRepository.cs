using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dota.Core.Models;

namespace Dota.Data.Services
{
    public class DotaMatchInfoRepository : IDotaMatchInfoRepository
    {
        public List<DotaHero> GetHeroesInMatch(DotaHero[] allHeroes, DotaMatchInfo matchInfo)
        {
            var heroesInMatch = new List<DotaHero>();
            foreach (var player in matchInfo.Players)
            {
                var heroInMatch = allHeroes.ToList().Find(hero => hero.Id == player.HeroId);
                heroesInMatch.Add(heroInMatch);
            }
            return heroesInMatch;
        }

        async Task<DotaMatchInfo> IDotaMatchInfoRepository.GetAllMatchInfo()
        {
            var client = new HttpClient();
            Task<string> getDotaStringTask = client.GetStringAsync("https://api.opendota.com/api/matches/5977269883");
            string dotaMatchJson = await getDotaStringTask;
            var matchInfo = DotaMatchInfo.FromJson(dotaMatchJson);

            return matchInfo;
        }

        public DotaHero PlayerHero(long playerHeroId, List<DotaHero> dotaHeroes)
        {
            foreach (var hero in dotaHeroes)
            {
                if (playerHeroId == hero.Id)
                {
                    return hero;
                }
            }
            return null;
        }
    }
    
}
