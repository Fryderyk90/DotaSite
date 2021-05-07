using Dota.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota.Data.Services
{
    public interface IDotaMatchInfoRepository
    {
        Task<DotaMatchInfo> GetAllMatchInfo(string matchUri);
        List<DotaHero> GetHeroesInMatch(DotaHero[] allHeroes, DotaMatchInfo matchInfo);
        DotaHero PlayerHero(long playerHeroId, List<DotaHero> dotaHeroes);
        List<HeroAndPlayer> HeroesPlayedByPlayer(List<DotaHero> dotaHeroes, Players[] players);
        List<DotaHero> HeroesByTeam(List<DotaHero> heroesInMatch, Players[] players);
    }
}
