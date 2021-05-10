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
        Task<IEnumerable<DotaLiveMatch>> GetLiveMatches(string LiveUri);
        List<DotaHero> GetHeroesInMatch(DotaHero[] allHeroes, DotaMatchInfo matchInfo);
        DotaHero PlayerHero(long playerHeroId, List<DotaHero> dotaHeroes);
        List<HeroAndPlayer> HeroesPlayedByPlayer(List<DotaHero> dotaHeroes, Players[] players);
        IEnumerable<DotaLiveMatchInfo> HeroesInLiveMatches(List<DotaHero> dotaheroes, List<DotaLiveMatch> dotaLiveMatches);
    }
}
