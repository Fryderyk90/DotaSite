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
        Task<DotaMatchInfo> GetAllMatchInfo();
        List<DotaHero> GetHeroesInMatch(DotaHero[] allHeroes, DotaMatchInfo matchInfo);
        DotaHero PlayerHero(long playerHeroId, List<DotaHero> dotaHeroes);
    }
}
